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

        public async Task GetSpeech(string uri)
        {
            bool fixAutomaticRequestLoopWhenUserClick = false;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(uri);
            request.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;

            using (HttpWebResponse response = (HttpWebResponse)await request.GetResponseAsync())
            using (Stream stream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream))
            {
                string result = await reader.ReadToEndAsync();
                if (result.IndexOf("Arthur") != -1)
                {
                    Form1 parentForm = this.Parent as Form1;
                    parentForm.userControlReact.BringToFront();
                    // Si vous voyez ça, soyez indulgent l'intégration dpython APIe la reconnaissance vocale à été faites à 5h du matin donc le code est peut être pas parfait ;)
                }

                if (result == "Automatic recognition stopped by the user") { fixAutomaticRequestLoopWhenUserClick = true; }

                SentenceslistView.Clear();
                if (!fixAutomaticRequestLoopWhenUserClick)
                {
                    string[] sentences = result.Split('/');
                    foreach (var sentence in sentences)
                    {
                        SentenceslistView.Items.Add(sentence);
                    }
                }
                else
                {
                    SentenceslistView.Items.Add("Phase en cours de détection...");
                }
            }
            if (!fixAutomaticRequestLoopWhenUserClick) { await GetSpeech("http://localhost:5000/getSpeechAutomatic"); }
        }

        private void SentenceslistView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

}
