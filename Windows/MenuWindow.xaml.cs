using System.Linq;
using System.Windows;
using System.Windows.Controls;
using TortugasNazarova.EF;

namespace TortugasNazarova.Windows
{

    public partial class MenuWindow : Window
    {
        public static int dishId;
        //Dish dish;

        public MenuWindow()
        {
            InitializeComponent();

            LVCategory.ItemsSource = ClassHelper.AppData.context.Category.ToList();
        }


        private void LVCategory_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var category = LVCategory.SelectedItem as Category;
            LVItems.ItemsSource = ClassHelper.AppData.context.Dish.Where(i => i.CategoryId == category.Id).ToList();
        }

        private void LVItems_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var Dish = LVItems.SelectedItem as Dish;
            dishId = Dish.Id;
            if (Dish != null)
            {
                CardWindow cardWindow = new CardWindow(Dish.Id);
                this.Opacity = 0.2;
                cardWindow.ShowDialog();
                this.Opacity = 1;
            }
        }

        private void TextBlock_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            OrderWindow orderWindow = new OrderWindow();
            orderWindow.Show();
            this.Close();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            //decimal cost = ClassHelper.AppData.context.Dish.Where(i => i.Id == dishId).First().Price;
            OrderDish orderDish = new OrderDish()
            {
                OrderId = MainWindow.OrderId,
                DishId = dishId,
                Qty = 1
            };

            ClassHelper.AppData.context.OrderDish.Add(orderDish);
            ClassHelper.AppData.context.SaveChanges();

            MessageBox.Show("Блюдо добавлено");

        }
    }
}
