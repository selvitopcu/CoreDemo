using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Writer
    {
        [Key]
        public int WriterID { get; set; }
        public string WriterName { get; set; }
        public string WriterAbout { get; set; }
        public string WriterImage { get; set; }
        public string WriterMail { get; set; }
		[DataType(DataType.Password)]
		public string WriterSifre { get; set; }
		[DataType(DataType.Password)]
		[Compare("WriterSifre", ErrorMessage = "Şifreler eşleşmiyor! Lütfen şifreyi tekrar giriniz!")]
        public string ConfirmSifre { get; set; }
        public bool WriterStatus { get; set; }
        public List<Blog> Blogs { get; set; }   
        public virtual ICollection<Message2> WriterSender { get; set; } 
        public virtual ICollection<Message2> WriterReceiver { get; set; }   
    }
}
