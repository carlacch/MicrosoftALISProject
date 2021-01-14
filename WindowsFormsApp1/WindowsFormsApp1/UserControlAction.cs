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

        private void ThemeView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void wordCloudlistView_SelectedIndexChanged(object sender, EventArgs e)
        {

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

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAgenda_Click(object sender, EventArgs e)
        {

        }

        /*
        #region Properties

        private ListView _themeview;
        private Button _createTheme;
        private ListView _wordview;

        [Category("ControlAction")]
        public ListView ThemeView
        {
            get { return _themeview; }
            set { _themeview = value; }
        }


        [Category("ControlAction")]
        public Button CreateTheme
        {
            get { return _createTheme; }
            set { _createTheme = value; }
        }


        [Category("ControlAction")]
        public ListView WordView
        {
            get { return _wordview; }
            set { _wordview = value; }
        }

        #endregion
        */

    }
}
