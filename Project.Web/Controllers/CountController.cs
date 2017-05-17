using Project.Core;
using Project.Service;
using Project.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project.Web.Controllers
{
    public class CountController : Controller
    {
        #region Constructor
        private ICountService countService;

        //constructor injection
        public CountController(ICountService countService)
        {
            this.countService = countService;
        }

        #endregion

        #region Methods

        // GET: Count
        public ActionResult Index()
        {
            CountModel countVal = countService.GetCounters().Select(u => new CountModel
            {
                Id = u.Id,
                CountNumber =  u.CountNumber
            }).FirstOrDefault();
            
          
            return View(countVal);
        }

        //When user clicked the Save button, it will either perform the INSERT (if count table is null or has no records yet) or 
        //UPDATE if there is an existing record in the table, it will update the count number.
        [HttpPost]
        public ActionResult Index(int? id, FormCollection collection)
        {
            CountTBL countTable;
            //Insert new record upon application first load, the table has no records at all.
            if (id == null)
            {
                countTable = new CountTBL();
                countTable.CountNumber += 1;
                countService.InsertCounter(countTable);
            }
            else
            {
                //this will perform update on the counter row, if the counter reached 10 then it will no longer update the record.
                countTable = countService.GetCounter((int)id);
                if (countTable.CountNumber < 10)
                {
                    countTable.CountNumber += 1;
                    countService.UpdateCounter(countTable);
                }
                else
                {
                    //this will show error if the counter reached the max number
                    ModelState.AddModelError("CountNumber", " Counter already reached the maximum number 10.");
                }
            }

            
            return View(ConvertToModel(countTable));
        }

        
        //this method will convert the CountTBL entities to CountModel model.
        private CountModel ConvertToModel(CountTBL countTable)
        {
            CountModel countModel = new CountModel();
            countModel.Id = countTable.Id;
            countModel.CountNumber = countTable.CountNumber;

            return countModel;
        }

        #endregion
    }
}