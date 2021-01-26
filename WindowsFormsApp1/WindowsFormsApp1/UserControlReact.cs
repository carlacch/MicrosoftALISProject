using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using Microsoft.CognitiveServices.Speech;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class UserControlReact : UserControl
    {
        public UserControlReact()
        {
            InitializeComponent();
            Global.SPEECH_API_KEY = Environment.GetEnvironmentVariable("speech_key");
            Global.SPEECH_SERVICE_REGION = Environment.GetEnvironmentVariable("service_region");
        }

        public void AddListToView(List<Theme> listTheme)
        {
            var items = ThemeView.Items;
            var words = wordCloudlistView.Items;
            foreach (var value in listTheme)
            {
                ListViewItem item = new ListViewItem(value.Title);
                item.Checked = true;
                items.Add(item);
                List<ListViewItem> allWords = new List<ListViewItem>();
                foreach (var w in value.Words)
                {
                    ListViewItem itemword = new ListViewItem(w);
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
                Form1 parentForm = (this.Parent as Form1);
                parentForm.finalSentence_GotFocus(sender, e);
                parentForm.finalSentence.Text += selectedItem[0].Text + " ";
            }
        }

        public static class Global
        {
            public static bool STOP_AUTOMATIC { get; set; }
            public static string SPEECH_API_KEY { get; set; }
            public static string SPEECH_SERVICE_REGION { get; set; }
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
            string startWord = "Arthur";
            List<string> stopWords = new List<string> { "Stop", "stop" };

            if (userClick)
            {
                listen = true;
                Global.STOP_AUTOMATIC = true;
            }

            while (activate)
            {
                System.Diagnostics.Debug.WriteLine("AUTOMATIC ACTIVATION: " + !Global.STOP_AUTOMATIC);

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

        private void SentenceslistView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

}
