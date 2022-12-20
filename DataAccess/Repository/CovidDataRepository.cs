using DataAccess.Entities;
using DataAccess.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class CovidDataRepository : IBaseRepository<CovidData>
    {
        public void Add(CovidData entity)
        {
            throw new NotImplementedException();
        }

        public IQueryable<CovidData> GetAll()
        {
            throw new NotImplementedException();
        }

        public IQueryable<CovidData> GetByQuery(Delegate @delegate)
        {
            throw new NotImplementedException();
        }
    }
}
