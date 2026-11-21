using System.Reflection.Emit;

namespace Human_Sizov2.Classes
{
    public abstract class Human
    {
        public string Name { get; set; }   
        public string Img { get; set; }
        public Human(string name, string img)
        {
            Name = name;
            Img = img;
        }

        public abstract void Speek(Label Phase);
    }
}
