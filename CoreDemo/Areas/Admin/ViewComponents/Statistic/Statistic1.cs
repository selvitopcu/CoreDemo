using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;
using static System.Net.WebRequestMethods;

namespace CoreDemo.Areas.Admin.ViewComponents.Statistic
{
    public class Statistic1 : ViewComponent
    {
        BlogManager bm = new BlogManager(new EfBlogRepository());
        Context c = new Context();
        public IViewComponentResult Invoke()
        {
            //ViewBag.v1 = bm.GetList().Count();
            //ViewBag.v2 = c.Contacts.Count();
            //ViewBag.v3 = c.Comments.Count();

            //string api = "3bb26dd05306f3f255ca5336847820df";
            //string connection = "https://api.openweathermap.org/data/2.5/weather?q=istanbul&mode=xml&lang=tr&units=metric&appid="+api;
            //XDocument document=XDocument.Load(connection);
            //ViewBag.v4= document.Descendants("temperature").ElementAt(0).Attribute("value").Value;
            //elementat index belirtir. value hangi değerin alınacağı
            return View();
        }
    }
}
