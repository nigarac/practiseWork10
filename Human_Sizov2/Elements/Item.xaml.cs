using System;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media.Imaging;

namespace Human_Sizov2.Elements
{
    /// <summary>
    /// Логика взаимодействия для Item.xaml
    /// </summary>
    public partial class Item : UserControl
    {

        Classes.Human Human;
        public Item(object Data)
        {
            InitializeComponent();
            this.Human = Data as Classes.Human;
            Img.Source = new BitmapImage(new Uri(this.Human.Img));
            lName.Content = this.Human.Name;
            lRace.Content = Data.GetType().Name;
        }

        private void Speek(object sender, MouseButtonEventArgs e)
        {
            Human.Speek(lText);
        }

        public void SpeekOnElements()
        {
            Human.Speek(lText);
        }
    }
}
