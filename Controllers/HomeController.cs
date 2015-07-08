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
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public JsonResult GetCollection(GlobalSearchText GlobalSearchText, int RecordsToTake, int RecordsToSkip, List<DataTableConfig> Columns)
        {
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
