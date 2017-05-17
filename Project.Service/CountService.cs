using Project.Core;
using Project.Data;
using System.Linq;
using System;

namespace Project.Service
{
    public class CountService : ICountService
    {
        private IRepository<CountTBL> countRepository;

        public IQueryable<CountTBL> GetCounters()
        {
            return countRepository.Table;
        }

        public CountService(IRepository<CountTBL> CountRepository)
        {
            this.countRepository = CountRepository;
        }

        public CountTBL GetCounter(int id)
        {
            return countRepository.GetById(id);
        }

        public void InsertCounter(CountTBL count)
        {
            countRepository.Insert(count);
        }

        public void UpdateCounter(CountTBL count)
        {
            countRepository.Update(count);
        }


    }
}
