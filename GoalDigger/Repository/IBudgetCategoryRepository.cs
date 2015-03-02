using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using GoalDigger.Model;

namespace GoalDigger.Repository
{
    public interface IBudgetCategoryRepository
    {
        int GetCount(); //
        void Add(BudgetCategory Cat); //
        void Delete(int CategoryId); //
        void Clear(); //
        int CalculateMonth(BudgetCategory Cat); //
        IEnumerable<BudgetCategory> All(); //
        BudgetCategory GetById(int WishId); //
        BudgetCategory GetByDate(string date); //
        IQueryable<BudgetCategory> SearchFor(Expression<Func<BudgetCategory, bool>> predicate);
    }
}
