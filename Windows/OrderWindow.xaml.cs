using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace TortugasNazarova.Windows
{
    public partial class OrderWindow : Window
    {
        int qty;
        EF.OrderDish orderD;
        public static decimal finalCost;
        decimal cost;
        public OrderWindow()
        {
            InitializeComponent();
            txbFinalCost.Text = "Итого: " + finalCost;
            ClassHelper.AppData.context.SaveChanges();
            LVOrder.ItemsSource = ClassHelper.AppData.context.OrderDish.Where(i=> i.OrderId == MainWindow.OrderId).ToList();
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            MenuWindow menuWindow = new MenuWindow();
            menuWindow.ShowDialog();
            this.Close();
        }

        private void BtnMinus_Click(object sender, RoutedEventArgs e)
        {
            if (qty == 1)
            {
                MessageBox.Show("Нельзя");
            }
            else
            {
                qty -= 1;
                orderD.Qty = qty;
                orderD.Cost = cost * qty;
                
                ClassHelper.AppData.context.SaveChanges();
                finalCost -= cost;
                txbFinalCost.Text = finalCost.ToString();
                LVOrder.ItemsSource = ClassHelper.AppData.context.OrderDish.Where(i => i.OrderId == MainWindow.OrderId).ToList();
            }
            
        }

        private void BtnPlus_Click(object sender, RoutedEventArgs e)
        {
            qty += 1;
            orderD.Qty = qty;
            orderD.Cost = cost * qty;
            
            ClassHelper.AppData.context.SaveChanges();
            finalCost += cost;
            txbFinalCost.Text = finalCost.ToString();
            LVOrder.ItemsSource = ClassHelper.AppData.context.OrderDish.Where(i => i.OrderId == MainWindow.OrderId).ToList();

        }

        private void LVOrder_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var orderDish = LVOrder.SelectedItem as EF.OrderDish;
            qty = orderDish.Qty;
            orderD = orderDish;
            cost = ClassHelper.AppData.context.Dish.Where(i => i.Id == orderDish.DishId).First().Price;

        }

        //public void SumCost()
        //{
        //    double sum = 0;
        //    foreach (var item in collection)
        //    {

        //    }
        //}
    }
}
