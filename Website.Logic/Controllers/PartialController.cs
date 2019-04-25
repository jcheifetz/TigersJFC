using System.Web.Mvc;
using Umbraco.Web.Mvc;
using Umbraco.Web;
using DevTrends.MvcDonutCaching;
using Website.Logic.Models.Partial_Models;
using System.Linq;
using System;


namespace Website.Logic.Controllers
{
    public class PartialsController : SurfaceController
    {

        private string GetPartialViewPath(string name)
        {
            return $"~/Views/Partials/{name}.cshtml";
        }

        [ChildActionOnly]
        //[DonutOutputCache(CacheProfile = "OneHour")]
        public ActionResult Menu()
        {
            MenuModel model = new MenuModel(CurrentPage);
            model.Root = Umbraco.ContentAtRoot().First();
            model.Days = model.Root.ChildrenOfType("day");
            return PartialView(GetPartialViewPath("Menu"), model);
        }

        [ChildActionOnly]
        //[DonutOutputCache(CacheProfile = "OneHour")]
        public ActionResult ResultsTable()
        {
            ResultsTableModel model = new ResultsTableModel(CurrentPage);
            return PartialView(GetPartialViewPath("ResultsTable"), model);
        }

    }
}
