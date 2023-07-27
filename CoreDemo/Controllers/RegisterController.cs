using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using CoreDemo.Models;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CoreDemo.Controllers
{

	[AllowAnonymous]
	public class RegisterController : Controller
	{
		WriterManager wm = new WriterManager(new EfWriterRepository());		

		[HttpGet]
		public IActionResult Index()
		{
		
			var sehirler = new CityViewModel();
			sehirler.Cities = new List<SelectListItem>();
			sehirler.Cities.Add(new SelectListItem() { Text = "Ankara", Value = "1", Selected = false });
			sehirler.Cities.Add(new SelectListItem() { Text="Sakarya",Value="2", Selected = false });
			sehirler.Cities.Add(new SelectListItem() { Text="İstanbul",Value="3", Selected = false });
			sehirler.Cities.Add(new SelectListItem() { Text="İzmit",Value="4", Selected = false });
			sehirler.Cities.Add(new SelectListItem() { Text="İzmir",Value="5", Selected = false });

			
            return View();
		}
		[HttpPost]
		public IActionResult Index(Writer p)
		{
			WriterValidator vw = new WriterValidator();
			ValidationResult results = vw.Validate(p);
			if (results.IsValid)
			{
				p.WriterStatus = true;
				p.WriterAbout = "Deneme";
				wm.TAdd(p);
				return RedirectToAction("Index", "Blog");
			}
			else
			{
				foreach (var item in results.Errors)
				{
					ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
				}
			}
			return View();

		}
	}
}
