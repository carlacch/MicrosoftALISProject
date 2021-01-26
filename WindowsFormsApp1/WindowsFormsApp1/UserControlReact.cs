using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using Microsoft.CognitiveServices.Speech;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Net.Http;
using System.Net.Http.Headers;
//using System.Net.Http.Formatting;
using Newtonsoft.Json;
using DocumentFormat.OpenXml.ExtendedProperties;

namespace WindowsFormsApp1
{
    public partial class UserControlReact : UserControl
    {
        public UserControlReact()
        {
            InitializeComponent();
            Global.SPEECH_API_KEY = Environment.GetEnvironmentVariable("speech_key");
            Global.SPEECH_SERVICE_REGION = Environment.GetEnvironmentVariable("service_region");
            getParameters();
        }

        public void AddListToView(List<Theme> listTheme)
        {
            ThemeView.Clear();
            wordCloudlistView.Clear();
            var items = ThemeView.Items;
            var words = wordCloudlistView.Items;

            int themeIndex = 0;

            foreach (var value in listTheme)
            {
                //color assignement
                Color themeColor = value.colorList[themeIndex];
                themeIndex++;

                ListViewItem item = new ListViewItem(value.Title);
                item.BackColor = themeColor;
                item.Checked = true;
                items.Add(item);
                List<ListViewItem> allWords = new List<ListViewItem>();
                foreach (var w in value.Words)
                {
                    ListViewItem itemword = new ListViewItem(w);

                    itemword.BackColor = themeColor;
                    words.Add(itemword);
                    allWords.Add(itemword);
                }
                item.Tag = Tuple.Create(value, allWords);
            }
        }

        private void btnSmiley_Click(object sender, EventArgs e)
        {

        }

        private void btnOui_Click(object sender, EventArgs e)
        {
            Form1 parentForm = (this.Parent as Form1);
            parentForm.finalSentence.Text = "Oui ";
            parentForm.finalSentence.ForeColor = Color.Black;
        }
        
        private void btnNon_Click(object sender, EventArgs e)
        {
            Form1 parentForm = (this.Parent as Form1);
            parentForm.finalSentence.Text = "Non ";
            parentForm.finalSentence.ForeColor = Color.Black;
        }

        private void wordCloudlistView_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            var tuple = (Tuple<Theme, List<ListViewItem>>)ThemeView.Items[e.Index].Tag;
            if (e.NewValue == CheckState.Unchecked)
            {
                //unchecked
                var wordstheme = tuple.Item2;
                foreach (var w in wordstheme)
                {
                    wordCloudlistView.Items.Remove(w);
                }
            }
            else if (e.NewValue == CheckState.Checked)
            {
                //checked
                if (tuple != null)
                {
                    var wordstheme = tuple.Item2;
                    foreach (var w in wordstheme)
                    {
                        wordCloudlistView.Items.Add(w);
                    }
                }
            }
        }

        private void wordCloudlistView_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedItem = wordCloudlistView.SelectedItems;
            if (selectedItem.Count > 0) 
            {
                var temp = selectedItem[0].Text;
                Form1 parentForm = (this.Parent as Form1);
                parentForm.finalSentence_GotFocus(sender, e);
                parentForm.finalSentence.Text += temp + " ";
            }
        }

        

        public async Task GetSpeech(bool userClick)
        {
            await voiceRecognition(userClick);
            // At the end of each voiceRecognition, the automatic listening start again so userClick is set to false
            if (!Global.STOP_AUTOMATIC) await GetSpeech(false);
        }

        public static async Task<string> stringFromMic(bool listen)
        {
            var speech_key = Global.SPEECH_API_KEY;
            var service_region = Global.SPEECH_SERVICE_REGION;

            var config = SpeechConfig.FromSubscription(speech_key, service_region);
            config.SpeechRecognitionLanguage = "fr-FR";

            var recognizer = new SpeechRecognizer(config);

            var result = await recognizer.RecognizeOnceAsync();

            if (listen == false)
            {
                System.Diagnostics.Debug.WriteLine("Ecoute passive...");
            }
            else
            {
                System.Diagnostics.Debug.WriteLine("Humain: " + result.Text);
            }

            return result.Text;

        }

        public static Tuple<string, bool> stopRecognition(string text, List<string> stopWords)
        {
            bool listeningStatus = true;
            foreach (string word in stopWords)
            {
                if (text.Contains(word))
                {
                    System.Diagnostics.Debug.WriteLine("stopWord found");
                    listeningStatus = false;
                }
                text = text.Replace(word, "");
            }
            return Tuple.Create(text, listeningStatus);
        }

        public async Task voiceRecognition(bool userClick)
        {
            bool activate = true;
            bool listen = false;
            string startWord = Global.USERNAME;
            List<string> stopWords = Global.STOP_WORDS;

            if (userClick)
            {
                listen = true;
                Global.STOP_AUTOMATIC = true;
            }

            while (activate)
            {
                if (Global.STOP_AUTOMATIC && !userClick)
                {
                    return;
                }

                string text = startWord;
                bool stopOnGoFirstListeningStatus = true;
                if (!userClick)
                {
                    text = await stringFromMic(listen);
                    var stopOnGoFirst = stopRecognition(text, stopWords);
                    text = stopOnGoFirst.Item1;
                    stopOnGoFirstListeningStatus = stopOnGoFirst.Item2;
                }

                if (text.Contains(startWord))
                {
                    listen = true;

                    // Condition to lead the user to the react tab where the sentences are heard
                    Form1 parentForm = this.Parent as Form1;
                    if (parentForm.Controls.GetChildIndex(parentForm.userControlReact) != 0)
                    {
                        parentForm.userControlReact.BringToFront();
                    }
                    SentenceslistView.Clear();

                    if (userClick) text = ""; else SentenceslistView.Items.Add(text);
                    // If the user say the starting word and a stopping word in the same sentence then
                    // the automatic recognition has to restart
                    if (!stopOnGoFirstListeningStatus) return;

                    while (listen)
                    {
                        text = await stringFromMic(listen);
                        var stopOnGoSecond = stopRecognition(text, stopWords);

                        if (!stopOnGoSecond.Item2)
                        {
                            activate = false;
                            listen = false;
                        }

                        if (stopOnGoSecond.Item1.Length != 0) SentenceslistView.Items.Add(stopOnGoSecond.Item1);
                    }
                }
            }

            if (userClick) Global.STOP_AUTOMATIC = false;
        }

        public static void getParameters()
        {
            string backKeys = "";
            string projectPath = Path.GetDirectoryName(Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, backKeys)));

            while (!Directory.Exists(@projectPath + "\\Config"))
            {
                backKeys += "..\\";
                projectPath = Path.GetDirectoryName(Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, backKeys)));
            }

            System.Diagnostics.Debug.WriteLine(projectPath);

            string[] lines = File.ReadAllLines(projectPath + "\\Config\\configFile");

            foreach (string line in lines)
            {
                if (line.Contains("USERNAME")) Global.USERNAME = line.Split('=')[1];
                if (line.Contains("STOP_WORDS"))
                {
                    string[] values = line.Split('=')[1].Split('/');
                    Array.Sort(values, (x, y) => y.Length.CompareTo(x.Length));
                    Global.STOP_WORDS = values.ToList();
                }
            }
        }

        public async Task<List<List<String>>> GetPredict(String sentence)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:5001/");
            string json = JsonConvert.ToString(sentence);

            HttpResponseMessage response = await client.PostAsync("api/predictNext", new StringContent(sentence, Encoding.UTF8, "text/plain"));

            return JsonConvert.DeserializeObject<List<List<string>>>(response.Content.ReadAsStringAsync().Result);
        }

        private void SentenceslistView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

    public static class Global
    {
        public static bool STOP_AUTOMATIC { get; set; }
        public static string SPEECH_API_KEY { get; set; }
        public static string SPEECH_SERVICE_REGION { get; set; }        
        public static string USERNAME { get; set; }
        public static List<string> STOP_WORDS { get; set; }
    }
}
