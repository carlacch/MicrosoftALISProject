using System;
using System.Collections.Generic;
using System.Text;

namespace WindowsFormsApp1
{
    public class Theme
    {
        private string title;
        private List<string> words;

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
