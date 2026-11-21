using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Windows.Documents;

namespace Human_Sizov2.Classes
{
    public class Russian : Human
    {
        private List<Phrase> Phrases { get; set; }
        private int stepAudio;
        private int StepAudio
        {
            get {  return stepAudio; }
            set
            {
                stepAudio = value;
                if (stepAudio > Phrases.Count - 1)
                {
                    stepAudio = 0;
                }
            }
        }
        public Russian(string Name, string Img) : base(Name, Img)
        {
            Phrases = AllPhrases();
        }

        public override void Speek(Label Phrase)
        {
            Phrase.Content = Phrases[StepAudio]._Phrase;
            MainWindow.MediaPlayer.Open(new Uri(Phrases[StepAudio].Src));
            MainWindow.MediaPlayer.Play();
            StepAudio++;
        }
        public static List<Phrase> AllPhrases()
        {
            List<Phrase> allPrases = new List<Phrase>();
            allPrases.Add(new Phrase("Вотсап", @"..."));
            allPrases.Add(new Phrase("каак делаа?", @"..."));
            allPrases.Add(new Phrase("всем привет я дима", @"..."));
            return allPrases;

        }
    }
}
