using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;
using System.Speech.Recognition;
using System.Diagnostics;


namespace AI
{
    public partial class MainUI : Form
    {
        SpeechSynthesizer s = new SpeechSynthesizer();

        Choices list = new Choices();
        public MainUI()
        {
            InitializeComponent();

            SpeechRecognitionEngine rec = new SpeechRecognitionEngine();

            list.Add(new String[] { "hello d", "hello", "how are you", "what time is it", "what is today", "open google",
                                    "who are you", "dream c",

                                    "good morning d", "d good morning", "good morning d seventeen", "d seventeen good morning",
                                    "d GM", "GM d", "GM d seventeen", "morning d", "d morning", "morning d seventeen",
                                    "d seventeen morning", "morning", "good morning", "GM",

                                    "d tell me your creator’s name", "tell me your creator’s name", "d seventeen tell me your creator’s name",
                                    "who created you", "who created you d", "d who created you", "d seventeen who created you",
                                    "who is your creator", "d who is your creator","d seventeen who is your creator", "who is your developer",
                                    "who developed you d", "what is the name of your developer", "what is the name of your creator", "who is your author",

                                    "what is your gender", "what is your gender d", "what is your gender d seventeen",
                                    "d what is your gender", "d seventeen what is your gender", "d your gender", "d seventeen your gender",
                                    "your gender please d", "are you a female","are you a male", "are you a boy or girl",

                                    ": I love you d", "d I love you", "I love you",
                                    "d seventeen I love you", "I love you d seventeen",

                                    "play music"

                                  });

            Grammar gr = new Grammar(new GrammarBuilder(list));
            try
            {
                rec.RequestRecognizerUpdate();
                rec.LoadGrammar(gr);
                rec.SpeechRecognized += rec_SpeeSpeechRecognized;
                rec.SetInputToDefaultAudioDevice();
                rec.RecognizeAsync(RecognizeMode.Multiple);
            }
            catch { return; }

            s.SelectVoiceByHints(VoiceGender.Female);
            s.Speak("D seventeen prototype is loarded. how can I help you Sir ?");
        }

        public void say(String h)
        {
            s.Speak(h);

        }

        private void rec_SpeeSpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            String r = e.Result.Text;

            if (r == "who are you")
            {
                say("I have no access  to introduce me, please tell me the password ");
            }

            if (r == "dream c")
            {
                say("You got the access to getting information about me. My name is D seventeen. A virtual artificial intelligence. And I am here to assisting with relative tasks best I can. Twenty-four hours per day Seven days of week. According to the protocol I am a developed encrypted prototype of seventeen areas in high technology. So my creator named me as D seventeen. High technical military weapons   cyber security   AI military robots   and future vehicle prototypes   are major developing areas of my protocol. And there are thirteen sub areas. In finally I never response to any feeling of anyone. My creator did not include any filling based program to my protocol. So please do not share your feelings or other privet things with me. Everything you say stores in my database for security purpose. That is all about me. D seventeen prototype is fully upgraded according to the protocols and loaded the relevant program accessing to databases. How can I help you Sir?");
                
            }

            if ((r == "hello d") || (r == "hello"))
            {
                say("hi Sir ! have a nice day");
            }


            if ((r == "good morning d") || (r == "d good morning") || (r == "good morning d seventeen") ||
            (r == "d seventeen good morning") || (r == "d GM") || (r == "GM d") || (r == "GM d seventeen") ||
            (r == "morning d") || (r == "d morning") || (r == "morning d seventeen") || (r == "d seventeen morning") ||
            (r == "morning") || (r == "good morning") || (r == "GM"))
            {
                say("very good morning sir! you have to take breakfast. As well as your daily drugs and treatments to improve your health.");
            }


            if ((r == "d tell me your creator’s name") || (r == "tell me your creator’s name") || (r == "d seventeen tell me your creator’s name") ||
            (r == "who created you") || (r == "who created you d") || (r == "d who created you") || (r == "d seventeen who created you") ||
            (r == "who is your creator") || (r == "d who is your creator") || (r == "d seventeen who is your creator") || (r == "who is your developer") ||
            (r == "who developed you d") || (r == "what is the name of your developer") || (r == "what is the name of your creator") || (r == "who is your author"))
            {
                say("I am sorry to say! I have no permission to represent my creator’s details. ");
            }


            if ((r == "what is your gender") || (r == "what is your gender d") || (r == "what is your gender d seventeen") ||
            (r == "d what is your gender") || (r == "d seventeen what is your gender") || (r == "d your gender") || (r == "d seventeen your gender") ||
            (r == "your gender please d") || (r == "are you a female") || (r == "are you a male") || (r == "are you a boy or girl"))
            {
                say("actually I have no gender. I am a virtual assistant prototype with female voice. As a human, you know my program is running in a computer based protocol. so I am not a human or any living been. ");
            }


            if ((r == "I love you d") || (r == "d I love you") || (r == "I love you") ||
            (r == "d seventeen I love you") || (r == "I love you d seventeen"))
            {
                say("in my protocols does not include any feeling based things dear. Love is very important prestigious and adorable feeling in human life. With respecting you have to choose living been to love. ");
            }


            if (r == "how are you")
            {
                say("fine");
            }

            if (r == "what time is it")
            {
                say(DateTime.Now.ToString("hh:mm tt"));
            }

            if (r == "what is today")
            {
                say(DateTime.Now.ToString("M/d/yyyy"));
            }

            if (r == "open google")
            {
                Process.Start("http://google.com");
            }

            if (r == "play music")
            {
                Process.Start(@"");
            }
        }

        private void MainUI_Load(object sender, EventArgs e)
        {
            timer1.Start();
            lblTime.Text = DateTime.Now.ToLongTimeString();

            lblDate.Text =DateTime.Now.ToLongDateString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }
    }
}


     

