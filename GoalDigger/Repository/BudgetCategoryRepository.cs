using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoalDigger.Repository
{
    class BudgetCategoryRepository: IBudgetCategoryRepository
    {
        public int GetCount()
        {
            throw new NotImplementedException();
        }

        public void Add(Model.BudgetCategory Cat)
        {
            throw new NotImplementedException();
        }

        public void Delete(int CategoryId)
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public int CalculateMonth(Model.BudgetCategory Cat)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Model.BudgetCategory> All()
        {
            throw new NotImplementedException();
        }

        public Model.BudgetCategory GetById(int WishId)
        {
            throw new NotImplementedException();
        }

        public Model.BudgetCategory GetByDate(string date)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Model.BudgetCategory> SearchFor(System.Linq.Expressions.Expression<Func<Model.BudgetCategory, bool>> predicate)
        {
            throw new NotImplementedException();
        }
    }
}
