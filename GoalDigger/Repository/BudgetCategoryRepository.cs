using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GoalDigger;
using System.Data.Entity;

namespace GoalDigger.Repository
{
    public class BudgetCategoryRepository: IBudgetCategoryRepository
    {
         private WishContext _dbContext;

        public BudgetCategoryRepository()
        {
            _dbContext = new WishContext();
            _dbContext.BudgetCats.Load();
        }

        public WishContext Context()
        {
            return _dbContext;
        }

        public DbSet<Model.BudgetCategory> GetDbSet()
        {
            return _dbContext.BudgetCats;
        }

        public int GetCount()
        {
            throw new NotImplementedException();
        }

        public void Add(Model.BudgetCategory Cat)
        {
            _dbContext.BudgetCats.Add(Cat);
            _dbContext.SaveChanges();
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
            var query = from Category in _dbContext.BudgetCats
                        select Category;
            return query.ToList<Model.BudgetCategory>();
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
