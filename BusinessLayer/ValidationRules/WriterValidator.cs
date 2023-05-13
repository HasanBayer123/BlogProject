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
            RuleFor(x => x.WriterName).NotEmpty().WithMessage("Ad Soyad bos gecilemez");
            RuleFor(x => x.WriterMail).NotEmpty().WithMessage("Mail bos gecilemez");
            RuleFor(x => x.WriterImage).NotEmpty().WithMessage("Fotoğraf bos gecilemez");
            RuleFor(x => x.WriterPassword).NotEmpty().WithMessage("Sifre bos gecilemez");
            RuleFor(x => x.WriterMail).Matches(@"[@,.]+").WithMessage("Mail adresi @ ve . icermelidir");			
			RuleFor(x => x.WriterPassword).Matches(@"[A-Z]+").WithMessage("Sifre en azı bir büyük harfden ibaret olmalıdır.");
			RuleFor(x => x.WriterPassword).Matches(@"[a-z]+").WithMessage("Sifre en azı bir kicik harfden ibaret olmalıdır.");
			RuleFor(x => x.WriterPassword).Matches(@"[0-9]+").WithMessage("Sifre en azı bir rakamdan ibaret olmalıdır.");
		}
	}
}
