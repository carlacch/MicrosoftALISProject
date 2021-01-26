using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using Microsoft.CognitiveServices.Speech;

namespace WindowsFormsApp1
{
    public partial class UserControlStandard : UserControl
    {
        public UserControlStandard()
        {
            InitializeComponent();
        }

        public void AddListToView(List<Theme> listTheme)
        {
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

        private void btnInterpellate_Click(object sender, EventArgs e)
        {

        }

        private void ThemeView_ItemCheck(object sender, ItemCheckEventArgs e)
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

        private void btnListen_Click(object sender, EventArgs e)
        {
            Form1 parentForm = this.Parent as Form1;
            parentForm.userControlReact.BringToFront();
            var task = parentForm.userControlReact.GetSpeech(true);
        }

        public static async Task Speak(string text)
        {
            // Creates an instance of a speech config with specified subscription key and service region.
            // Replace with your own subscription key and service region (e.g., "westus").
            var speech_key = Environment.GetEnvironmentVariable("speech_key");
            var service_region = Environment.GetEnvironmentVariable("service_region");

            var config = SpeechConfig.FromSubscription(speech_key, service_region);
            config.SpeechSynthesisLanguage = "fr-FR";
            config.SpeechSynthesisVoiceName = "fr-FR-Paul";

            // Creates a speech synthesizer using the default speaker as audio output.
            using (var synthesizer = new SpeechSynthesizer(config))
            {
                using (var result = await synthesizer.SpeakTextAsync(text))
                {
                    if (result.Reason == ResultReason.SynthesizingAudioCompleted)
                    {
                        Console.WriteLine($"Speech synthesized to speaker for text [{text}]");
                    }
                    else if (result.Reason == ResultReason.Canceled)
                    {
                        var cancellation = SpeechSynthesisCancellationDetails.FromResult(result);
                        Console.WriteLine($"CANCELED: Reason={cancellation.Reason}");

                        if (cancellation.Reason == CancellationReason.Error)
                        {
                            Console.WriteLine($"CANCELED: ErrorCode={cancellation.ErrorCode}");
                            Console.WriteLine($"CANCELED: ErrorDetails=[{cancellation.ErrorDetails}]");
                            Console.WriteLine($"CANCELED: Did you update the subscription info?");
                        }
                    }
                }
            }
        }

        private async void btnInterpellate_Click_1(object sender, EventArgs e)
        {
            await Speak("Excusez moi, j'ai besoin de votre attention s'il vous plait");
        }
    }
}
