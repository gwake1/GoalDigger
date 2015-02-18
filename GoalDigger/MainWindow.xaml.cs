using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using GoalDigger;
using GoalDigger.Model;
using GoalDigger.Repository;

namespace GoalDigger
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static WishRepository repo = new WishRepository();
        public MainWindow()
        {
            InitializeComponent();
            WishList.DataContext = repo.Context().Wishes.Local;
        }
        private void AddWish_Click(object sender, RoutedEventArgs e)
        {
            repo.Add(new Wish(WishName.Text, WishDate.SelectedDate.ToString(),Int32.Parse(WishPrice.Text)));
        }
    }
}
