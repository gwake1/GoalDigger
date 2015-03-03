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
            return _dbContext.Wishes.Count<Model.Wish>();
        }

        public void Add(Model.Wish W)
        {
            _dbContext.Wishes.Add(W);
            _dbContext.SaveChanges();
        }

        public void Delete(int WishId)
        {
            var wish = _dbContext.Wishes.Where(x => x.WishId == WishId);
            _dbContext.Wishes.RemoveRange(wish);
            _dbContext.SaveChanges();
        }

        public void Clear()
        {
            var a = this.All();
            _dbContext.Wishes.RemoveRange(a);
            _dbContext.SaveChanges();
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
            var query = from Wish in _dbContext.Wishes
                        select Wish;
            return query.ToList<Model.Wish>();
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
            var query = from Wish in _dbContext.Wishes
                        where Wish.Date == date
                        select Wish;
            return query.First<Model.Wish>();
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
