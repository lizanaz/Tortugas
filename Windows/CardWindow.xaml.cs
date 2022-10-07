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
    /// <summary>
    /// Логика взаимодействия для CardWindow.xaml
    /// </summary>
    public partial class CardWindow : Window
    {
        public CardWindow(int dishId)
        {
            InitializeComponent();
            LVCard.ItemsSource = ClassHelper.AppData.context.Dish.Where(i => i.Id == dishId).ToList();
        }
        public CardWindow()
        {
            InitializeComponent();
        }

        private void tbClose_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.Close();
            

        }
    }
}
