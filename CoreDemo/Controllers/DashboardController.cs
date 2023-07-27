using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.Controllers
{
    public class DashboardController : Controller
    {
        BlogManager bm = new BlogManager(new EfBlogRepository());
      
        public IActionResult Index()
        {
            Context c = new Context();
            var username = User.Identity.Name; //giriş yaptığı değerle adını alık
            var usermail = c.Users.Where(x => x.UserName == username).Select(y => y.Email).FirstOrDefault(); //kullanıcı adıyla mailini aldık
            var writerId = c.Writers.Where(x => x.WriterMail == usermail).Select(y => y.WriterID).FirstOrDefault(); //maile göre writerıd sini aldık

            ViewBag.v1 = c.Blogs.Count().ToString(); //toplam blog sayısı
            ViewBag.v2=c.Blogs.Where(x=>x.WriterID==writerId).Count();
            ViewBag.v3=c.Categories.Count().ToString();
            return View();
        }
    }
}
