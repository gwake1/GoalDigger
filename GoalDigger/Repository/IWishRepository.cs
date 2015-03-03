using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using GoalDigger.Model;

namespace GoalDigger.Repository
{
    public interface IWishRepository
    {
        int GetCount(); //
        void Add(Wish W); //
        void Delete(int WishId); //
        void Clear(); //
        IEnumerable<Wish> PastWishes(); //
        int CalculateMonth(Wish W); //
        IEnumerable<Wish> All(); //
        Wish GetById(int WishId); //
        Wish GetByDate(DateTime date); //
        IQueryable<Wish> SearchFor(Expression<Func<Wish, bool>> predicate);
    }
}
