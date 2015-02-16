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
using GoalDigger.Model;
using GoalDigger;

namespace GoalDigger
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            using (var _dbContext = new WishContext())
            {
                _dbContext.Wishes.Add(new Wish("New Year's Eve", "12/31/2015", 1500));
                _dbContext.Wishes.Add(new Wish("Birthday", "12/25/2015", 75));
                _dbContext.SaveChanges();
            }
                InitializeComponent();
        }
    }
}
