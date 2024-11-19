using System.Windows;

namespace WpfApp1
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void OpenZadanie1_Click(object sender, RoutedEventArgs e)
        {
            Zadanie1 zadanie1 = new Zadanie1();
            zadanie1.Show();
        }

        private void OpenZadanie2_Click(object sender, RoutedEventArgs e)
        {
            Zadanie2 zadanie2 = new Zadanie2();
            zadanie2.Show();
        }

        private void OpenZadanie3_Click(object sender, RoutedEventArgs e)
        {
            Zadanie3 zadanie3 = new Zadanie3();
            zadanie3.Show();
        }

        private void OpenZadanie4_Click(object sender, RoutedEventArgs e)
        {
            Zadanie4 zadanie4 = new Zadanie4();
            zadanie4.Show();
        }
    }
}
