using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Collections;

namespace WindowsFormsApp1
{
    public class Theme
    {
        private string title;
        private List<string> words;


        // colors possible
        public List<Color> colorList = new List<Color>{  Color.LightBlue, Color.LightGreen, Color.LightSalmon, Color.RosyBrown, Color.YellowGreen, Color.OrangeRed, Color.Yellow,   Color.Cyan};

        public Theme(string title) {
            this.title = title;
        }

        public Theme(string title, string word)
        {
            this.title = title;
            this.words.Add(word);
        }

        public Theme(string title, List<string> words)
        {
            this.title = title;
            this.words = words;
        }

        public string Title
        {
            get { return this.title; }
        }

        public List<string> Words
        {
            get { return this.words; }
        }

        public void AddWord(string word)
        {
            words.Add(word);
        }

        public void DeleteWord(string word)
        {
            words.Remove(word);
        }
    }
}
