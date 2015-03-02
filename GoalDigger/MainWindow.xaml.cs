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
using System.Xml;

namespace GoalDigger
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static WishRepository repo = new WishRepository();
        public static BudgetCategory repoCat = new BudgetCategory();
        //public Wish record;
        public MainWindow()
        {
            InitializeComponent();
            WishList.DataContext = repo.GetDbSet().Local;
            ClearBudgetForm();
        }
        private void AddWish_Click(object sender, RoutedEventArgs e)
        {
            //string shortDate = WishDate.SelectedDate.Value.ToShortDateString();
            //repo.Add(new Wish(WishName.Text, shortDate, int.Parse(WishPrice.Text)));
            //ClearWishForm();
        }

        private void ClearBudgetForm()
        {
            BudgetName.Text = "Name";
            BudgetAmount.Text = "Price";
            BudgetDate.Text = System.DateTime.Today.ToString();
        }

        public void DeleteWish_Click(object sender, RoutedEventArgs e)
        {

            //int unitTypeId = (this.WishList.SelectedItem as Wish).WishId;
            //ListBoxItem done = (ListBoxItem)WishList.SelectedItem;
            //repo.Delete(unitTypeId);
            //WishList.Items.Refresh();
        }

        public void ActuallyDelete_Click(object sender, RoutedEventArgs e)
        {
            ListItemCollection wish = (ListItemCollection)WishList.SelectedItem;
            //TextBlock g = wish.ToList<TextBlock>();

            //TextBlock g = wish.Content as TextBlock;

        }

        private void AddToBudget_Click(object sender, RoutedEventArgs e)
        {
            string shortDate = BudgetDate.SelectedDate.Value.ToShortDateString();
            //repo.Add(new Wish(BudgetName.Text, shortDate, BudgetAmount, ))
            ClearBudgetForm();
        }
    }
}
