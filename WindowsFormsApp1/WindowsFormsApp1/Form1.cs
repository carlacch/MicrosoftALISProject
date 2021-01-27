using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using Microsoft.CognitiveServices.Speech;

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
            var task = userControlReact.GetSpeech(false);
        }

        public void ExecuteAsAdmin(string fileName)
        {
            Process proc = new Process();
            proc.StartInfo.FileName = fileName;
            proc.StartInfo.UseShellExecute = true;
            proc.StartInfo.Verb = "runas";
            proc.Start();
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

        List<Theme> GetThemesStandard()
        {
            Theme thComplements = new Theme("Compléments", new List<string> { "Qui", "Quoi", "Quand", "Comment", "Combien" });
            Theme thPronouns = new Theme("Pronoms", new List<string> { "j'", "je", "tu", "il", "elle", "on", "nous", "vous", "ils", "elles" });
            Theme thVerbes = new Theme("Verbes", new List<string> { "être", "avoir", "faire", "donner", "voir", "aller", "prendre", "pouvoir", "passer", "tenir" });
            Theme thAdjectives = new Theme("Adjectifs", new List<string> { "super", "autre", "bizarre", "drôle", "facile", "grave", "impossible", "propre" });
            Theme thCommonNoun = new Theme("Noms Communs", new List<string> { "aide", "merci", "madame", "monsieur", "boite", "poche", "livre" });
            Theme thAdverbs = new Theme("Adverbe", new List<string> { "bien", "comme", "mal", "mieux", "lentement", "vite", "aussi", "plutôt" });
            Theme thNumbers = new Theme("Nombres", new List<string> { "1", "2", "3", "4", "5", "6", "7", "8", "9" });

            List<Theme> listThemes = new List<Theme> { thComplements, thPronouns, thVerbes, thAdjectives, thCommonNoun, thAdverbs, thNumbers };
            return listThemes;
        }

        List<Theme> GetThemesReact()
        {

            Theme thReactShort = new Theme("Réactions courtes", new List<string> { "merci", "s'il vous plait", "bonjour", "bonsoir", "au revoir", "à bientôt", });
            Theme thReactLong = new Theme("Réactions longues", new List<string> { "J'ai mal entendu", "Je n'ai pas bien compris", "pouvez vous répéter ?" });
            Theme thComplements = new Theme("Compléments", new List<string> { "qui", "quoi", "quand", "comment", "combien" });
            Theme thPronouns = new Theme("Pronoms", new List<string> { "j'", "je", "tu", "il", "elle", "on", "nous", "vous", "ils", "elles" });
            Theme thVerbes = new Theme("Verbes", new List<string> { "être", "avoir", "faire", "donner", "voir", "aller", "prendre", "pouvoir", "passer", "tenir" });

            List<Theme> listThemes = new List<Theme> { thReactShort, thReactLong, thComplements, thPronouns, thVerbes };
            return listThemes;
        }

        List<Theme> GetThemesUrgency()
        {
            Theme thAssistance = new Theme("Assistance", new List<string> { "j'ai besoin d'aide", "aidez-moi", "à l'aide", "aide", "problème" });
            Theme thBody = new Theme("Corps", new List<string> { "main", "oeil", "ventre", "dos", "pied", "coeur", "poumon", "tête" });
            Theme thMaux = new Theme("Maux", new List<string> { "mal", "douleur", "difficulté respiratoire", "souffrance", "piqure", "gratte", "brûle" });
            Theme thLocations = new Theme("Lieux", new List<string> { "maison", "escalier", "dehors", "intérieur", "parc" });


            List<Theme> listThemes = new List<Theme> { thAssistance, thBody, thMaux, thLocations };
            return listThemes;
        }
        List<Theme> GetThemesAction()
        {
            Theme thMedical = new Theme("Médical", new List<string> { "Docteur", "j'ai mal", "ventre", "médicament", "pansement", "guérir", "soin", "ça pique" });
            Theme thRepas = new Theme("Repas", new List<string> { "bon apétit", "faim", "boire", "puis je avoir", "dessert", "assaisonement", "viande", "légumes" });
            Theme thToilets = new Theme("Toilettes", new List<string> { "toilettes", "J'ai fini", "besoin d'uriner", "numéro deux", });
            Theme thHygiene = new Theme("Hygiène", new List<string> { "nettoyer les mains", "laver les dents", "brosser les cheveux", "raser", "maquiller" });

            List<Theme> listThemes = new List<Theme> { thMedical, thRepas, thToilets, thHygiene };
            return listThemes;
        }

        List<Theme> GetThemesLibrary()
        {
            Theme thWeather = new Theme("Météo", new List<string> { "météo", "température", "beau temps", "pluie", "chaud", "froid" });
            Theme thNews = new Theme("Actualités", new List<string> { "corona", "brexit", "elections", "incendie", "grèves", "discours", "journal télévisé" });
            Theme thGames = new Theme("Jeux", new List<string> { "jouer", "passer", "scrabble", "pioche", "tour", "carte" });
            Theme thFilms = new Theme("Films", new List<string> { "regarder", "comédie", "action", "horreur", "fantasy", "science-fiction", "pause" });


            List<Theme> listThemes = new List<Theme> { thWeather, thNews, thGames, thFilms };
            return listThemes;
        }

        List<Theme> GetThemesLocation()
        {
            Theme thLocations = new Theme("Lieux", new List<string> { "maison", "dehors", "intérieur", "supermarché", "boulangerie", "épicerie", "centre commercial", "parc" });
            Theme thLocations_House = new Theme("Maison", new List<string> { "chambre", "toilettes", "cuisine", "salon", "cave", "escalier" });
            Theme thLocations_Shop = new Theme("Shop", new List<string> { "Acheter", "Quel est le prix ?", "c'est un peu cher", "en plus grand", "c'est trop petit", "Où puis je trouver", "Avez vous" });
            Theme thLocations_Bakery = new Theme("Boulangerie", new List<string> { "baguette", "croissant", "pain au chocolat", "chouqettes", "feuilletés prâlinés" });

            List<Theme> listThemes = new List<Theme> { thLocations, thLocations_House, thLocations_Shop, thLocations_Bakery };
            return listThemes;
        }

        private void userControlAction_Load(object sender, EventArgs e)
        {
            var listThemes = GetThemesAction();
            userControlAction.AddListToView(listThemes);
        }

        private void userControlReact_Load(object sender, EventArgs e)
        {
            var listThemes = GetThemesReact();
            userControlReact.AddListToView(listThemes);
        }

        private void userControlLibrary_Load(object sender, EventArgs e)
        {
            var listThemes = GetThemesLibrary();
            userControlLibrary.AddListToView(listThemes);
        }

        private void userControlLocation_Load(object sender, EventArgs e)
        {
            var listThemes = GetThemesLocation();
            userControlLocation.AddListToView(listThemes);
        }

        private void userControlStandard_Load(object sender, EventArgs e)
        {
            var listThemes = GetThemesStandard();
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
            ExecuteAsAdmin(@"osk.exe");
            finalSentence.Focus();
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

        private async void btnSpeak_Click(object sender, EventArgs e)
        {
            await Speak(finalSentence.Text);
        }

        public Dictionary<string, string> getThemesDict()
        {
            Dictionary<string, string> dict = new Dictionary<string, string>();

            dict.Add("ADJ", "Adjectif");
            dict.Add("ADV", "Adverbe");
            dict.Add("ADP", "Determinant");
            dict.Add("DET", "Determinant");
            dict.Add("PRON", "Pronom");
            dict.Add("PROPN", "Nom Propre");
            dict.Add("NOUN", "Verbe");
            dict.Add("VERB", "Verbe");
            dict.Add("PUNCT", "Ponctuation");
            dict.Add("CCONJ", "Conjonction de coordination");
            dict.Add("SCONJ", "Conjonction de subordination");
            dict.Add("AUX", "Auxiliaire");
            dict.Add("X", "Pffff");
            dict.Add("NUM", "Nombre");

            return dict;
        }

        private async void finalSentence_TextChanged(object sender, EventArgs e)
        {
            List<Theme> listThemes = new List<Theme>();
            if (!finalSentence.Text.Equals(String.Empty) & !finalSentence.Text.Equals("Phrase en cours de composition"))
            {
                var a = userControlReact.GetPredict(finalSentence.Text);
                List<List<string>> mots = await userControlReact.GetPredict(finalSentence.Text);
                Dictionary<string, string> dict = getThemesDict();
                for (int i = 0; i < mots.Count(); i++)
                {
                    string value;
                    if (dict.TryGetValue(mots[i][1], out value))
                    {
                        if (dict[mots[i][1]].Equals("Pffff"))
                        {
                            continue;
                        }
                        if (dict[mots[i][1]].Equals("Ponctuation"))
                        {
                            continue;
                        }
                        if (mots[i][0].Length == 1)
                        {
                            continue;
                        }
                        Theme result = listThemes.Find(x => x.Title.Equals(dict[mots[i][1]]));
                        if (result != null)
                        {
                            result.AddWord(mots[i][0]);
                        }
                        else
                        {
                            Theme theme = new Theme(dict[mots[i][1]]);
                            theme.AddWord(mots[i][0]);
                            listThemes.Add(theme);
                        }
                    }
                }
            }
            userControlReact.AddListToView(listThemes);
            foreach (var i in listThemes)
            {
                System.Diagnostics.Debug.WriteLine(i.Title);
            }
            foreach (var i in GetThemesStandard())
            {
                listThemes.Add(i);
            }
        }
    }
}
