using System;
using System.Collections.Generic;

namespace Human_Sizov2.Classes
{
    public class English : Human
    {
        private List<Phrase> PhrasesOnEnglish { get; set; }
        private int stepAudio;
        private int StepAudio
        {
            get { return stepAudio; }
            set
            {
                stepAudio = value;
                if (stepAudio > PhrasesOnEnglish.Count - 1)
                {
                    stepAudio = 0;
                }
            }
        }
        public English(string Name, string Img) : base(Name, Img)
        {
            PhrasesOnEnglish = AllPhrases();
        }

        public override void Speek(System.Windows.Controls.Label Phrase)
        {
            Phrase.Content = PhrasesOnEnglish[StepAudio]._Phrase;
            MainWindow.MediaPlayer.Open(new Uri(PhrasesOnEnglish[StepAudio].Src));
            MainWindow.MediaPlayer.Play();
            StepAudio++;
        }
        public static List<Phrase> AllPhrases()
        {
            List<Phrase> allPrasesOnEnglish = new List<Phrase>();
            allPrasesOnEnglish.Add(new Phrase("whatsapp", @"C:\Users\student-a502.PERMAVIAT\Desktop\Zadanie\Human_Sizov2\Human_Sizov2\Voices\whaaaatsapppp.mp3"));
            allPrasesOnEnglish.Add(new Phrase("howareyu?", @"C:\Users\student-a502.PERMAVIAT\Desktop\Zadanie\Human_Sizov2\Human_Sizov2\Voices\howareyoutoday.mp3"));
            allPrasesOnEnglish.Add(new Phrase("i`m dima", @"C:\Users\student-a502.PERMAVIAT\Desktop\Zadanie\Human_Sizov2\Human_Sizov2\Voices\i`mDima.mp3"));
            return allPrasesOnEnglish;

        }
    }
}
