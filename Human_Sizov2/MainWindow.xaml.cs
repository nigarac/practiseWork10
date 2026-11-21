using System.Threading;
using System.Windows;
using System.Windows.Media;
using Human_Sizov2.Classes;
using Human_Sizov2.Elements;

namespace Human_Sizov2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Classes.Human Human;

        public static MediaPlayer MediaPlayer = new MediaPlayer();
        private Classes.Russian Russian = new Classes.Russian("дмитрий", @"C:\Users\student-a502.PERMAVIAT\Desktop\Zadanie\Human_Sizov2\Human_Sizov2\Images\ic_russian.png");
        private Classes.English English = new Classes.English("dmitriy", @"C:\Users\student-a502.PERMAVIAT\Desktop\Zadanie\Human_Sizov2\Human_Sizov2\Images\ic_english.png");

        public MainWindow()
        {
            InitializeComponent();
            Parent.Children.Add(new Elements.Item(Russian));
            Parent.Children.Add(new Elements.Item(English));

        }

        private void Dialog(object sender, RoutedEventArgs e)
        {
            Elements.Item item1 = Parent.Children[1] as Elements.Item;
            Elements.Item item2 = Parent.Children[2] as Elements.Item;

            //Human.Speek(item.lText);
            for (int i = 0; i < 3; i++)
            {
                item1.SpeekOnElements();
                Thread.Sleep(2000);
                item2.SpeekOnElements();
                Thread.Sleep(2000);

            }
            //item2.SpeekOnElements();

        }
    }
}
