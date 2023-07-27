using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
	public class WriterValidator:AbstractValidator<Writer>
	{
        public WriterValidator()
        {
            RuleFor(x => x.WriterName).NotEmpty().WithMessage("Yazar adı soyadı kısmı boş geçilemez"); 
            RuleFor(x => x.WriterMail).NotEmpty().WithMessage("Mail adresi boş geçilemez");
            RuleFor(x => x.WriterName).MinimumLength(2).WithMessage("Lütfen en az 2 karakter girişi yapınız");
            RuleFor(x => x.WriterName).MaximumLength(50).WithMessage("Lütfen en fazla 50 karakterlik veri girişi yapınız");

            RuleFor(x => x.WriterSifre).NotNull()
					  .NotEmpty().WithMessage("Boş geçilemez!")
					  .MinimumLength(8).WithMessage("En az 8 karakter olmalıdır")
					  .MaximumLength(20).WithMessage("En fazla 20 karakter")
					  .Matches("[0-9]").WithMessage("0-9 arasında sayı giriniz!")
					  .Matches("[A-Z]").WithMessage("Şifrenizde büyük harf bulunmalıdır!")
					  .Matches("[a-z]").WithMessage("Şifrenizde küçük harf bulunmalıdır!")
					  .Matches("[^a-zA-Z0-9]").WithMessage("Özel bir karakter giriniz!");

		}
    }
}
