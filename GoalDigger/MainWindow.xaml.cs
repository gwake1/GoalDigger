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
            ClearWishForm();
        }
        private void AddWish_Click(object sender, RoutedEventArgs e)
        {
            string shortDate = WishDate.SelectedDate.Value.ToShortDateString();
            repo.Add(new Wish(WishName.Text, shortDate, int.Parse(WishPrice.Text)));
            ClearWishForm();
        }

        private void ClearWishForm()
        {
            WishName.Clear();
            WishName.Text = "Name";
            WishPrice.Clear();
            WishPrice.Text = "Price";
            WishDate.Text = System.DateTime.Today.ToString();
        }

        private void EditWish_click(object sender, RoutedEventArgs e)
        {
            var a = new EditWish();
            a.Show();
        }
    }
}
