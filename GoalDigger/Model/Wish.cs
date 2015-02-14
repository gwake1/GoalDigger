using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoalDigger.Model
{
    public class Wish
    {
        public string Date;
        public string Name;
        public int Price;

        public Wish(string WishName, string WishDate, int WishPrice)
        {
            this.Date = WishDate;
            this.Name = WishName;
            this.Price = WishPrice;
        }
    }
}
