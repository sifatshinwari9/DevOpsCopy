using DataAccess.Entities;
using DataAccess.IRepository;
using DataAccess.Utilitiy;
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

        public List<CovidData> GetAll()
        {
            return DataReaderUtil.ReadDummyCovidDataset();            
        }

        public List<CovidData> GetByQuery(Delegate @delegate)
        {
            throw new NotImplementedException();
        }
    }
}
