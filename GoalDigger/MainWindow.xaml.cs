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
        public static BudgetCategoryRepository repoCat = new BudgetCategoryRepository();
        public List<int> EditList = new List<int>();

        public MainWindow()
        {
            InitializeComponent();
            WishList.DataContext = repo.GetDbSet().Local;
            ClearBudgetForm();
            BudgetCategory_Combo.DataContext = repoCat.GetDbSet().Local;
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

        private void AddToBudget_Click(object sender, RoutedEventArgs e)
        {
            string shortDate = BudgetDate.SelectedDate.Value.ToShortDateString();
            //repo.Add(new Wish(BudgetName.Text, shortDate, BudgetAmount, ))
            ClearBudgetForm();
        }

        private void BudgetFlow_MouseDown(object sender, MouseButtonEventArgs e)
        {
            var ger = BudgetCategory_Combo.SelectedItem;
            
        }

        private void CheckBox_Click(object sender, RoutedEventArgs e)
        {
            int edit = int.Parse(this.Tag.ToString());
            EditList.Add(edit);
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            foreach (var edit in EditList)
            {
                repo.Delete(edit);
            }
        }
    }
}
