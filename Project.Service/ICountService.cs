using Project.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Service
{
    public interface ICountService
    {
        IQueryable<CountTBL> GetCounters();
        CountTBL GetCounter(int id);
        void InsertCounter(CountTBL count);
        void UpdateCounter(CountTBL count);
    }
}
