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

namespace GoalDigger
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Wish> Wishes;

        public MainWindow()
        {
            Wishes = new ObservableCollection<Wish>();
            Wishes.Add(new Wish("SurfBoard", "02/14/2015", 80));
            InitializeComponent();
            WishList.DataContext = Wishes;
        }
    }
}
