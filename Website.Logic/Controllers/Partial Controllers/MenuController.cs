using System.Web.Mvc;
using Umbraco.Web.Mvc;
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
            Menu model = new Menu(CurrentPage);
            model.Root = Umbraco.ContentAtRoot().First();
            return PartialView(GetPartialViewPath("Menu"), model);
        }
    }
}
