using System.Web.Mvc;
using Umbraco.Web.Mvc;
using DevTrends.MvcDonutCaching;
using System;


namespace Website.logic.Controllers.Partial_Controllers
{
    class MenuController : SurfaceController
    {

        private string GetPartialViewPath(string name)
        {
            return $"~/Views/Partials/PageSnippets/{name}.cshtml";
        }

        [ChildActionOnly]
        [DonutOutputCache(CacheProfile = "OneMonth")]
        public ActionResult NavFooterUpper(int startNodeId)
        {
            NavFooterModel model = new NavFooterModel(CurrentPage);
            model.StartNodeId = startNodeId;
            return PartialView(GetPartialViewPath("NavFooterUpper"), model);
        }
    }
}
