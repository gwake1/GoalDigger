using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GoalDigger;
using System.Data.Entity;

namespace GoalDigger.Repository
{
    public class WishRepository: IWishRepository
    {
        private WishContext _dbContext;

        public WishRepository()
        {
            _dbContext = new WishContext();
            _dbContext.Wishes.Load();
        }

        public WishContext Context()
        {
            return _dbContext;
        }

        public DbSet<Model.Wish> GetDbSet()
        {
            return _dbContext.Wishes;
        }

        public int GetCount()
        {
            throw new NotImplementedException();
        }

        public void Add(Model.Wish W)
        {
            throw new NotImplementedException();
        }

        public void Delete(Model.Wish W)
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Model.Wish> PastWishes()
        {
            throw new NotImplementedException();
        }

        public int CalculateMonth(Model.Wish W)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Model.Wish> All()
        {
            throw new NotImplementedException();
        }

        public Model.Wish GetById(int id)
        {
            var query = from Wish in _dbContext.Wishes
                        where Wish.WishId == id
                        select Wish;
            return query.First<Model.Wish>();
        }

        public Model.Wish GetByDate(string date)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Model.Wish> SearchFor(System.Linq.Expressions.Expression<Func<Model.Wish, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            _dbContext.Dispose();
        }
    }
}
