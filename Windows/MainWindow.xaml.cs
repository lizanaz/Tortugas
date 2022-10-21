using System.Windows;
using TortugasNazarova.Windows;


namespace TortugasNazarova
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public static int Numb;


        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn12(object sender, RoutedEventArgs e)
        {
            Numb = 11;
            MenuWindow menuWindow = new MenuWindow();
            menuWindow.Show();
            this.Close();
        }

        private void btn41(object sender, RoutedEventArgs e)
        {
            Numb = 1;
            MenuWindow menuWindow = new MenuWindow();
            menuWindow.Show();
            this.Close();
        }

        private void btn42(object sender, RoutedEventArgs e)
        {
            Numb = 2;
            MenuWindow menuWindow = new MenuWindow();
            menuWindow.Show();
            this.Close();
        }

        private void btn43(object sender, RoutedEventArgs e)
        {
            Numb = 3;
            MenuWindow menuWindow = new MenuWindow();
            menuWindow.Show();
            this.Close();
        }

        private void btn44(object sender, RoutedEventArgs e)
        {
            Numb = 4;
            MenuWindow menuWindow = new MenuWindow();
            menuWindow.Show();
            this.Close();
        }

        private void btn21(object sender, RoutedEventArgs e)
        {
            Numb = 5;
            MenuWindow menuWindow = new MenuWindow();
            menuWindow.Show();
            this.Close();
        }

        private void btn22(object sender, RoutedEventArgs e)
        {
            Numb = 6;
            MenuWindow menuWindow = new MenuWindow();
            menuWindow.Show();
            this.Close();
        }

        private void btn23(object sender, RoutedEventArgs e)
        {
            Numb = 7;
            MenuWindow menuWindow = new MenuWindow();
            menuWindow.Show();
            this.Close();
        }

        private void btn24(object sender, RoutedEventArgs e)
        {
            Numb = 8;
            MenuWindow menuWindow = new MenuWindow();
            menuWindow.Show();
            this.Close();
        }

        private void btn101(object sender, RoutedEventArgs e)
        {
            Numb = 9;
            MenuWindow menuWindow = new MenuWindow();
            menuWindow.Show();
            this.Close();
        }

        private void btn102(object sender, RoutedEventArgs e)
        {
            Numb = 10;
            MenuWindow menuWindow = new MenuWindow();
            menuWindow.Show();
            this.Close();
        }
    }
}
