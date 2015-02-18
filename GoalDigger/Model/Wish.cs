using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoalDigger.Model
{
    public class Wish: INotifyPropertyChanged
    {
        public int WishId { get; set; }
        public string Date { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }

        public Wish()
        {
            //something
        }

        public Wish(string WishName, string WishDate, int WishPrice)
        {
            this.Date = WishDate;
            this.Name = WishName;
            this.Price = WishPrice;
        }

        //public Wish(string p1, string p2, System.Windows.Controls.TextBox WishPrice)
        //{
        //    // TODO: Complete member initialization
        //    this.Date = p1;
        //    this.Name = p2;
        //    this.WishPrice = WishPrice;
        //}
        public event PropertyChangedEventHandler PropertyChanged;
        //private string p1;
        //private string p2;
        //private System.Windows.Controls.TextBox WishPrice;
    }
}
