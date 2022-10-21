using System.Linq;
using System.Windows;
using System.Windows.Controls;
using TortugasNazarova.EF;

namespace TortugasNazarova.Windows
{
    /// <summary>
    /// Логика взаимодействия для MenuWindow.xaml
    /// </summary>
    public partial class MenuWindow : Window
    {
        public static int OrderId;

        public MenuWindow()
        {
            InitializeComponent();
            //int Count=6;

            LVCategory.ItemsSource = ClassHelper.AppData.context.Category.ToList();

            //Order order = new Order();
            //order.TableId = MainWindow.Numb;
            //order.OrderDate = DateTime.Now;
            //order.FinalCost = 0;
            //order.EmployeeId = 5;
            //order.Id = Count+1;
            //ClassHelper.AppData.context.Order.Add(order);
            //ClassHelper.AppData.context.SaveChanges();
            //order.Id = OrderId;
        }

        private void LVCategory_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var category = LVCategory.SelectedItem as Category;
            LVItems.ItemsSource = ClassHelper.AppData.context.Dish.Where(i => i.CategoryId == category.Id).ToList();
        }

        private void LVItems_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var dish = LVItems.SelectedItem as Dish;
            if (dish != null)
            {
                CardWindow cardWindow = new CardWindow(dish.Id);
                this.Opacity = 0.2;
                cardWindow.ShowDialog();
                this.Opacity = 1;
            }

        }
    }
}
