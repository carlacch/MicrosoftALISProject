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
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

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
    }
}
