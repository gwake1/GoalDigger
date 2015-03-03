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

        private ObservableCollection<Model.Wish> _WishListData;
        public ObservableCollection<Model.Wish> WishListData
        {
            get
            {
                return _WishListData;
            }
            set
            {
                _WishListData = value;
            }
        }
      
        public MainWindow()
        {
            InitializeComponent();
            WishList.DataContext = repo.GetDbSet().Local;
            ClearBudgetForm();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            repo.GetDbSet();
    
            var IncomeView = new ListCollectionView(repo.GetDbSet().Local);
            //IncomeView.Filter = ;
            this.DataContext = IncomeView;
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
            //string shortDate = BudgetDate.SelectedDate.Value.ToShortDateString();
            NewBudgetCategory.Text = BudgetCategory_Combo.SelectionBoxItem.ToString();
            int BudgetAmountValue = int.Parse(BudgetAmount.Text);
            repo.Add(new Wish(BudgetName.Text, BudgetDate.SelectedDate.Value, BudgetAmountValue, BudgetCategory_Combo.Text, BudgetFlow.Text));
            ClearBudgetForm();
        }

        private void BudgetFlow_MouseDown(object sender, MouseButtonEventArgs e)
        {
            var ger = BudgetCategory_Combo.SelectedItem;
            
        }

        private void CheckBox_Click(object sender, RoutedEventArgs e)
        {
            int edit = int.Parse(this.Tag.ToString());
            //EditList.Add(edit);
        }

        public void Dashboard_Click(object sender, RoutedEventArgs e)
        {

        }

        public void Detail_Click(object sender, RoutedEventArgs e)
        {
            Budget.Visibility = Visibility.Visible;
            Home.Visibility = Visibility.Collapsed;
        }

        public void Expense_Click(object sender, RoutedEventArgs e)
        {
            Budget.Visibility = Visibility.Visible;
            Home.Visibility = Visibility.Collapsed;
            Budget.IsEnabled = true;
            BudgetFlow.Text = "Expense";
            BudgetFlow.IsEnabled = false;
            BudgetCategory_Combo.ItemsSource = repoCat.GetCategories("Expense");
            WishListData = repo.FilterData("Income");
            WishList.DataContext = WishListData;
        }

        public void Income_Click(object sender, RoutedEventArgs e)
        {
            Budget.Visibility = Visibility.Visible;
            Home.Visibility = Visibility.Collapsed;
            BudgetFlow.IsEnabled = true;
            BudgetFlow.Text = "Income";
            BudgetFlow.IsEnabled = false;
            BudgetCategory_Combo.ItemsSource = repoCat.GetCategories("Income");
            WishListData = repo.FilterData("Expense");
            WishList.DataContext = WishListData;
        }

        public void BudgetToHome_Click(object sender, RoutedEventArgs e)
        {
            Home.Visibility = Visibility.Visible;
            Budget.Visibility = Visibility.Collapsed;
        }
    }
}
