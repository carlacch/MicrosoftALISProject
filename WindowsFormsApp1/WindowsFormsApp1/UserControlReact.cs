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

        public async Task GetSpeech(string uri, bool userClick, bool automatic)
        {
            System.Diagnostics.Debug.WriteLine("Test execution");

            await voiceRecognition(userClick, automatic);

            

            //using (StreamReader reader = new StreamReader(stream))
            //{
            //    string result = await reader.ReadToEndAsync();
            //    if (result.IndexOf("Arthur") != -1)
            //    {
            //        Form1 parentForm = this.Parent as Form1;
            //        parentForm.userControlReact.BringToFront();
            //        // Si vous voyez ça, soyez indulgent l'intégration de la reconnaissance vocale à été faites à 5h du matin donc le code est peut être pas parfait ;)
            //    }

            //    if (result == "Automatic recognition stopped by the user") { fixAutomaticRequestLoopWhenUserClick = true; }

            //    SentenceslistView.Clear();
            //    if (!fixAutomaticRequestLoopWhenUserClick)
            //    {
            //        string[] sentences = result.Split('/');
            //        foreach (var sentence in sentences)
            //        {
            //            SentenceslistView.Items.Add(sentence);
            //        }
            //    }
            //    else
            //    {
            //        SentenceslistView.Items.Add("Phase en cours de détection...");
            //    }
            //}
            //if (!fixAutomaticRequestLoopWhenUserClick) { await GetSpeech("http://localhost:5000/getSpeechAutomatic"); }
        }

        public static async Task<string> stringFromMic(bool listen)
        {
            var speech_key = "c06aeb4d93b24003a125aa2adef59aaa";
            var service_region = "francecentral";

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

        public static class Global
        {
             public static bool STOP_AUTOMATIC { get; set; }
        }

        public async Task voiceRecognition(bool userClick, bool automatic)
        {
            bool activate = true;
            bool listen = false;
            string startWord = "Arthur";
            List<string> stopWords = new List<string> { "Stop", "stop" };

            if (userClick) listen = true;

            //bool startResponse = false;
            List<string> response = new List<string>();

            if (userClick) Global.STOP_AUTOMATIC = true;

            System.Diagnostics.Debug.WriteLine("AUTOMATIC: "+Global.STOP_AUTOMATIC);

            while (activate)
            {
                if (Global.STOP_AUTOMATIC && automatic)
                {
                    response.Clear();
                    response.Add("Automatic recognition stopped by the user");
                }

                string text = startWord;
                if (!userClick) text = await stringFromMic(listen);

                if (text.Contains(startWord))
                {
                    listen = true;
                    //if (!userClick) response.Add(text);

                    // Condition to lead the user to the react tab where the sentences are heard
                    Form1 parentForm = this.Parent as Form1;
                    if (parentForm.Controls.GetChildIndex(parentForm.userControlReact) != 0)
                    {
                        parentForm.userControlReact.BringToFront();
                        SentenceslistView.Clear();
                    }

                    if (!automatic) text = ""; else SentenceslistView.Items.Add(text);

                    while (listen)
                    {
                        text = await stringFromMic(listen);
                        var stopOnGo = stopRecognition(text, stopWords);

                        if (stopOnGo.Item2)
                        {
                            activate = false;
                            listen = false;
                        }

                        SentenceslistView.Items.Add(stopOnGo.Item1);
                    }
                }
            }

            if (userClick) Global.STOP_AUTOMATIC = false;

            return;
        }

        private void SentenceslistView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

}
