using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KODatatableServerSidePaging.Models;

namespace KODatatableServerSidePaging.Controllers
{
    public class HomeController : Controller
    {
        
        public ActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// Method to retrieve records from server
        /// </summary>
        /// <param name="GlobalSearchText">Global serach text</param>
        /// <param name="RecordsToTake">No of records to be fetched</param>
        /// <param name="RecordsToSkip">No of records to be skipped</param>
        /// <param name="Columns">Gives you info about each column and if it is sortable or not</param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult GetCollection(GlobalSearchText GlobalSearchText, int RecordsToTake, int RecordsToSkip, List<DataTableConfig> Columns)
        {
            //Implement custom logic to fetch records
            List<TableModel> objLs = new List<TableModel>();
            for (int i = 0; i < 12; i++)
            {
                TableModel obj = new TableModel();
                obj.Id = i;
                obj.Address = "Address" + i;
                obj.Name = "vasu" + i;
                objLs.Add(obj);
            }
            return Json(objLs);
        }

    }

   
}
