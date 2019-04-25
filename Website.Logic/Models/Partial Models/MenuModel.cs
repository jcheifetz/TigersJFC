using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web.Models;
using System.Collections.Generic;

namespace Website.Logic.Models.Partial_Models
{


    public class MenuModel : ContentModel
    {
        public MenuModel(IPublishedContent content) : base(content)
        {
            
        }
        public IPublishedContent Root;
        public IEnumerable<IPublishedContent> Days;
    }
}
