using System;
using System.Windows;
using TortugasNazarova.EF;
using TortugasNazarova.Windows;


namespace TortugasNazarova
{

    public partial class MainWindow : Window
    {
        public static int Numb { get; set; }
        public static int OrderId = 6;

        public void OrderAdd()
        {
            Order order = new Order();
            order.TableId = Numb;
            order.OrderDate = DateTime.Now;
            order.FinalCost = 0;
            order.EmployeeId = 5;
            //MenuWindow menuWindow = new MenuWindow(order.Id);
            ClassHelper.AppData.context.Order.Add(order);
            ClassHelper.AppData.context.SaveChanges();
            OrderId = order.Id;
            MessageBox.Show(OrderId.ToString());
        }

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn12(object sender, RoutedEventArgs e)
        {
            Numb = 11;
            MenuWindow menuWindow = new MenuWindow();
            OrderAdd();
            menuWindow.Show();
            this.Close();
        }

        private void btn41(object sender, RoutedEventArgs e)
        {
            Numb = 1;
            MenuWindow menuWindow = new MenuWindow();
            OrderAdd();
            menuWindow.Show();
            this.Close();
        }

        private void btn42(object sender, RoutedEventArgs e)
        {
            Numb = 2;
            MenuWindow menuWindow = new MenuWindow();
            OrderAdd();
            menuWindow.Show();
            this.Close();
        }

        private void btn43(object sender, RoutedEventArgs e)
        {
            Numb = 3;
            MenuWindow menuWindow = new MenuWindow();
            OrderAdd();
            menuWindow.Show();
            this.Close();
        }

        private void btn44(object sender, RoutedEventArgs e)
        {
            Numb = 4;
            MenuWindow menuWindow = new MenuWindow();
            OrderAdd();
            menuWindow.Show();
            this.Close();
        }

        private void btn21(object sender, RoutedEventArgs e)
        {
            Numb = 5;
            MenuWindow menuWindow = new MenuWindow();
            OrderAdd();
            menuWindow.Show();
            this.Close();
        }

        private void btn22(object sender, RoutedEventArgs e)
        {
            Numb = 6;
            MenuWindow menuWindow = new MenuWindow();
            OrderAdd();
            menuWindow.Show();
            this.Close();
        }

        private void btn23(object sender, RoutedEventArgs e)
        {
            Numb = 7;
            MenuWindow menuWindow = new MenuWindow();
            OrderAdd();
            menuWindow.Show();
            this.Close();
        }

        private void btn24(object sender, RoutedEventArgs e)
        {
            Numb = 8;
            MenuWindow menuWindow = new MenuWindow();
            OrderAdd();
            menuWindow.Show();
            this.Close();
        }

        private void btn101(object sender, RoutedEventArgs e)
        {
            Numb = 9;
            MenuWindow menuWindow = new MenuWindow();
            OrderAdd();
            menuWindow.Show();
            this.Close();
        }

        private void btn102(object sender, RoutedEventArgs e)
        {
            Numb = 10;
            MenuWindow menuWindow = new MenuWindow();
            OrderAdd();
            menuWindow.Show();
            this.Close();
        }
    }
}
