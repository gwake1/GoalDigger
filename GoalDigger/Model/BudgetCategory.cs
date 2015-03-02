using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;  

namespace GoalDigger.Model
{
    public class BudgetCategory: INotifyPropertyChanged
    {
        [Key]
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string BudgetFlow { get; set; }

        public BudgetCategory()
        {
            // Do Something
        }
        public BudgetCategory(string Name, string Flow)
        {
            this.CategoryName = Name;
            this.BudgetFlow = Flow;
        }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
