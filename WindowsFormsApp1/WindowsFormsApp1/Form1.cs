using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            finalSentence.Text = "Phrase en cours de composition";
            finalSentence.ForeColor = Color.Gray;
            finalSentence.GotFocus += new EventHandler(finalSentence_GotFocus);
            finalSentence.LostFocus += new EventHandler(finalSentence_LostFocus);
        }

        void finalSentence_LostFocus(object sender, EventArgs e)
        {
            if (finalSentence.Text.Equals(string.Empty))
            {
                finalSentence.Text = "Phrase en cours de composition";
                finalSentence.ForeColor = Color.Gray;
            }
        }

        internal void finalSentence_GotFocus(object sender, EventArgs e)
        {
            if (finalSentence.Text.Equals("Phrase en cours de composition"))
            {
                finalSentence.Text = string.Empty;
                finalSentence.ForeColor = Color.Black;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            userControlStandard.BringToFront();
        }

        private void btnActions_Click(object sender, EventArgs e)
        {
            userControlAction.BringToFront();
        }

        private void btnEmergency_Click(object sender, EventArgs e)
        {
            userControlUrgency.BringToFront();
        }

        private void btnLibrary_Click(object sender, EventArgs e)
        {
            userControlLibrary.BringToFront();
        }

        private void btnContact_Click(object sender, EventArgs e)
        {
            userControlContact.BringToFront();
        }

        private void btnLocation_Click(object sender, EventArgs e)
        {
            userControlLocation.BringToFront();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            userControlStandard.BringToFront();
        }

        List<Theme> GetThemes()
        {
            Theme thVerbe = new Theme("Verbe", new List<string> { "manger", "boire", "faire", "laver", "aller" });
            Theme thLocation = new Theme("Lieux", new List<string> { "maison", "dehors", "supermarché", "épicerie", "centre commercial", "parc" });
            Theme thAdverbeTemps = new Theme("Adverbe de Temps", new List<string> { "depuis", "hier", "longtemps", "demain", "maintenant", "parfois", "toujours" });
            Theme thAdverbe = new Theme("Adverbe de Manière", new List<string> { "lentement", "bien", "mieux", "pire", "plutôt", "mal", "comme" });
            List<Theme> listThemes = new List<Theme> { thVerbe, thLocation, thAdverbeTemps, thAdverbe };
            return listThemes;
        }

        List<Theme> GetThemesUrgency()
        {
            Theme thAssistance = new Theme("Assistance", new List<string> { "j'ai besoin d'aide", "aidez-moi", "à l'aide", "aide", "problème" });
            Theme thLocation = new Theme("Lieux", new List<string> { "maison", "dehors", "main", "oeil", "ventre", "dos", "pied", "coeur", "poumon" });
            Theme thMaux = new Theme("Maux", new List<string> { "mal", "douleur", "souffrance", "piqure", "gratte", "brûle" });
            List<Theme> listThemes = new List<Theme> { thAssistance, thLocation, thMaux };
            return listThemes;
        }

        private void userControlAction_Load(object sender, EventArgs e)
        {
            var listThemes = GetThemes();
            userControlAction.AddListToView(listThemes);      
        }

        private void userControlReact_Load(object sender, EventArgs e)
        {
            var listThemes = GetThemes();
            userControlReact.AddListToView(listThemes);
        }

        private void userControlLibrary_Load(object sender, EventArgs e)
        {
            var listThemes = GetThemes();
            userControlLibrary.AddListToView(listThemes);
        }

        private void userControlLocation_Load(object sender, EventArgs e)
        {
            var listThemes = GetThemes();
            userControlLocation.AddListToView(listThemes);
        }

        private void userControlStandard_Load(object sender, EventArgs e)
        {
            var listThemes = GetThemes();
            userControlStandard.AddListToView(listThemes);
        }

        private void userControlUrgency_Load(object sender, EventArgs e)
        {
            var listThemes = GetThemesUrgency();
            userControlUrgency.AddListToView(listThemes);
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            string sentence = finalSentence.Text;
            if (sentence == "Phrase en cours de composition" || String.IsNullOrEmpty(sentence))
            {
                finalSentence.Text = string.Empty;
                finalSentence_LostFocus(sender, e);
                return;
            }
            int index = sentence.LastIndexOf(" ");
            if (index == -1 && sentence.Length > 0)
            {
                index = sentence.Length - 1;
            }
            sentence = sentence.Remove(index);
            finalSentence.Text = sentence;
        }

        private void btnKeyboard_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"osk.exe"); //elevation issue
        }
    }
}
