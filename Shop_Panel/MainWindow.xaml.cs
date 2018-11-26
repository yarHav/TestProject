using MahApps.Metro.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data.Entity;

namespace Shop_Panel
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        public BindingList<Good> GoodLst { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            
            
            using (DatabaseContext ctx = new DatabaseContext())
            {
                var categories = ctx.Categories.Include(c => c.Goods).ToList();
                var goods = categories.FirstOrDefault()?.Goods;
                GoodLst = new BindingList<Good>(goods.ToList());
            }
            DataContext = this;
        }

        private void AddGood_Click(object sender, RoutedEventArgs e)
        {

        }

        private void EditGood_Click(object sender, RoutedEventArgs e)
        {

        }

        private void DeletGood_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
