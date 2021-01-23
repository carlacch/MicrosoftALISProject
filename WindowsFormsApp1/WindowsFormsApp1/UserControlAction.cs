using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class UserControlAction : UserControl
    {
        public UserControlAction()
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

        private void themeView_ItemCheck(object sender, ItemCheckEventArgs e)
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

        private void btnAgenda_Click(object sender, EventArgs e)
        {

        }

    }
}
