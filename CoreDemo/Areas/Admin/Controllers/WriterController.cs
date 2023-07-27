﻿using CoreDemo.Areas.Admin.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CoreDemo.Areas.Admin.Controllers
{
    [Area("Admin")]
	[Authorize(Roles = "Admin")]
	public class WriterController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult WriterList()
        {
            var jsonWriters = JsonConvert.SerializeObject(writers);
            //writers dan gelen nesneti dönüştürüyoruz.
            return Json(jsonWriters); 
        }
        //yazar listesi için aşağdaki liste bir değişkene atlıp convert edilmeli.

        public IActionResult GetWriterByID(int writerid)
        {
            var findWriter=writers.FirstOrDefault(x => x.Id == writerid);
            var jsonWriters = JsonConvert.SerializeObject(findWriter);
            return Json(jsonWriters);
        }

        [HttpPost]
        public IActionResult AddWriter(WriterClass w)
        {
            writers.Add(w);
            var jsonWriters = JsonConvert.SerializeObject(w);
            return Json(jsonWriters);

        }

        public IActionResult DeleteWriter(int id)
        {
            var writer= writers.FirstOrDefault(x => x.Id == id);
            writers.Remove(writer);
            return Json(writer);

        }
        public IActionResult UpdateWriter(WriterClass p)
        {
            var writer= writers.FirstOrDefault(x => x.Id == p.Id);
            writer.Name = p.Name;
            var jsonWriter= JsonConvert.SerializeObject(p);
            return Json(writer);
        }



        public static List<WriterClass> writers = new List<WriterClass>
        {
            new WriterClass()
            {
                Id = 1,
                Name="Ayşe"
            },
            new WriterClass()
            {
                Id = 2,
                Name="Ahmet"
            },
            new WriterClass()
            {
                Id = 3,
                Name="Buse"
            }
        };
    }
}
