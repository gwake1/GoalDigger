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
            return _dbContext.BudgetCats.Count<Model.BudgetCategory>();
        }

        public void Add(Model.BudgetCategory Cat)
        {
            _dbContext.BudgetCats.Add(Cat);
            _dbContext.SaveChanges();
        }

        public void Delete(int CategoryId)
        {
            var cat = _dbContext.BudgetCats.Where(x => x.CategoryId == CategoryId);
            _dbContext.BudgetCats.RemoveRange(cat);
            _dbContext.SaveChanges();
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

        public Model.BudgetCategory GetById(int CategoryId)
        {
            var query = from Cat in _dbContext.BudgetCats
                        where Cat.CategoryId == CategoryId
                        select Cat;
            return query.First<Model.BudgetCategory>();
        }

        public IQueryable<Model.BudgetCategory> SearchFor(System.Linq.Expressions.Expression<Func<Model.BudgetCategory, bool>> predicate)
        {
            throw new NotImplementedException();
        }
        public List<string> GetCategories(string flow)
        {
            var query = from Cat in _dbContext.BudgetCats
                        where Cat.BudgetFlow == flow
                        orderby Cat.BudgetFlow
                        select Cat.CategoryName;
            return query.Distinct().ToList();
        }
    }
}
