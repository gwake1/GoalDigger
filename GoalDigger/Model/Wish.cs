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
        public static ObservableCollection<Wish> Wishes = new ObservableCollection<Wish>();

        public string Date;
        public string Name;
        public int Price;

        public Wish()
        {
            //wish
        }

        public Wish(string WishName, string WishDate, int WishPrice)
        {
            this.Date = WishDate;
            this.Name = WishName;
            this.Price = WishPrice;
            Wishes.Add(this);
        }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
