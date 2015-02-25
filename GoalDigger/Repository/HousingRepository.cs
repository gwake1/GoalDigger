using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoalDigger.Repository
{
    class HousingRepository: IWishRepository
    {
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
            throw new NotImplementedException();
        }

        public Model.Wish GetByDate(string date)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Model.Wish> SearchFor(System.Linq.Expressions.Expression<Func<Model.Wish, bool>> predicate)
        {
            throw new NotImplementedException();
        }
    }
}
