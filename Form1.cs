using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Recognition;
using System.Speech.Synthesis;
using System.IO;

namespace VoiceApp
{
    public partial class Form1 : Form
    {
        SpeechRecognitionEngine _recognizer = new SpeechRecognitionEngine();
        SpeechSynthesizer Alis = new SpeechSynthesizer();
        SpeechRecognitionEngine startlistening = new SpeechRecognitionEngine();
        Random rmd = new Random();
        int RecTimeOut = 0;
        DateTime timenow = DateTime.Now;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _recognizer.SetInputToDefaultAudioDevice();
            _recognizer.LoadGrammarAsync(new Grammar(new GrammarBuilder(new Choices(File.ReadAllLines(@"DefaultCommands.txt")))));
            _recognizer.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(Default_SpeechRecognized);
            _recognizer.SpeechDetected += new EventHandler<SpeechDetectedEventArgs>(_recognizer_SpeechRecognized);
            _recognizer.RecognizeAsync(RecognizeMode.Multiple);

            startlistening.SetInputToDefaultAudioDevice();
            startlistening.LoadGrammarAsync(new Grammar(new GrammarBuilder(new Choices(File.ReadAllLines(@"DefaultCommands.txt")))));
            startlistening.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(startlistening_SpeechRecognized);
        }

        private void startlistening_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            string speech = e.Result.Text;

            if (speech == "wake up")
            {
                startlistening.RecognizeAsyncCancel();
                Alis.SpeakAsync("i am here");
                _recognizer.RecognizeAsync(RecognizeMode.Multiple);
            }
        }

        private void _recognizer_SpeechRecognized(object sender, SpeechDetectedEventArgs e)
        {
            RecTimeOut = 0;

        }

        private void Default_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            int ranNum;
            string speech = e.Result.Text;

            if (speech == "hello")
            {
                Alis.SpeakAsync("Hello, I am here");
            }
            if (speech == "how are you")
            {
                Alis.SpeakAsync("i am talking to you");
            }
            if (speech == "do you need something")
            {
                Alis.SpeakAsync("No I am fine");
            }
            if (speech == "what time is it")
            {
                Alis.SpeakAsync(DateTime.Now.ToString("h mm tt"));
            }
            if (speech == "stop talking")
            {
                Alis.SpeakAsyncCancelAll();
                ranNum = rmd.Next(1);
                if (ranNum == 1)
                {
                    Alis.SpeakAsync("alright");
                }
                if (ranNum == 2)
                {
                    Alis.SpeakAsync("fine");
                }
            }
            if (speech == "stop listening")
            {
                Alis.SpeakAsync("okay");
                _recognizer.RecognizeAsyncCancel();
                startlistening.RecognizeAsync(RecognizeMode.Multiple);
            }

            if (speech == "show commands")
            {
                string[] commands = (File.ReadAllLines(@"DefaultCommands.txt"));
                lstCommands.Items.Clear();
                lstCommands.SelectionMode = SelectionMode.None;
                lstCommands.Visible = true;
                foreach (string command in commands)
                {
                    lstCommands.Items.Add(command);
                }
            }
            if (speech == "hide commands")
            {
                lstCommands.Visible = false;
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (RecTimeOut == 10)
            {
                _recognizer.RecognizeAsyncCancel();
            }
            else if (RecTimeOut == 11)
            {
                tmrSpeaking.Stop();
                startlistening.RecognizeAsync(RecognizeMode.Multiple);
                RecTimeOut = 0;
            }
        }
    }
}
