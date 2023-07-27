using EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.Build.Evaluation;
using System.ComponentModel.DataAnnotations;

namespace CoreDemo.Models
{
    public class AddProfileImage
    {
        [Key]
        public int WriterID { get; set; }
        public string WriterName { get; set; }
        public string WriterAbout { get; set; }
        public IFormFile WriterImage { get; set; }
        public string WriterMail { get; set; }
        public string WriterSifre { get; set; }
        public bool WriterStatus { get; set; }
    }
}
