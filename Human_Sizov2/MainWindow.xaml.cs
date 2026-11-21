using System.Windows;
using System.Windows.Media;

namespace Human_Sizov2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static MediaPlayer MediaPlayer = new MediaPlayer();
        private Classes.Russian Russian = new Classes.Russian("дмитрий", @"C:\Users\student-a502.PERMAVIAT\Desktop\Zadanie\Human_Sizov2\Human_Sizov2\Images\ic_russian.png");
        public MainWindow()
        {
            InitializeComponent();
            Parent.Children.Add(new Elements.Item(Russian)); 
        }
    }
}
