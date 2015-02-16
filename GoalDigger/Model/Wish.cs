using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoalDigger.Model
{
    public class Wish
    {
        public int WishId { get; set; }
        public string Date { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }

        public Wish(string WishName, string WishDate, int WishPrice)
        {
            this.Date = WishDate;
            this.Name = WishName;
            this.Price = WishPrice;
        }
    }
}
