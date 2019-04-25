using System.Web.Mvc;
using Umbraco.Web.Mvc;
using Umbraco.Web;
using DevTrends.MvcDonutCaching;
using Website.Logic.Models.Partial_Models;
using System.Linq;
using System;


namespace Website.Logic.Controllers.Partial_Controllers
{
    class MenuController : SurfaceController
    {

        private string GetPartialViewPath(string name)
        {
            return $"~/Views/Partials/PageSnippets/{name}.cshtml";
        }

        [ChildActionOnly]
        [DonutOutputCache(CacheProfile = "OneHour")]
        public ActionResult NavFooterUpper(int startNodeId)
        {
            MenuModel model = new MenuModel(CurrentPage);
            model.Root = Umbraco.ContentAtRoot().First();
            model.Days = model.Root.ChildrenOfType("day");
            return PartialView(GetPartialViewPath("Menu"), model);
        }
    }
}
