using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web.Models;

namespace Website.Logic.Models.Partial_Models
{


    public class Menu : ContentModel
    {
        public Menu(IPublishedContent content) : base(content)
        {
            
        }
        public IPublishedContent Root;  
    }
}
