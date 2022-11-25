using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class WriterValidator2 : AbstractValidator<Writer>
    {
        public WriterValidator2()
        {
            RuleFor(x => x.WriterName).NotEmpty().WithMessage("Yazar adını boş geçemezsiniz.");
            RuleFor(x => x.WriterSurName).NotEmpty().WithMessage("Yazar soyadını boş geçemezsiniz.");
            RuleFor(x => x.WriterMail).NotEmpty().WithMessage("Yazar mailini boş geçemezsiniz.");
            RuleFor(x => x.WriterPassword).NotEmpty().WithMessage("Yazar şifresini boş geçemezsiniz.");
        }
    }
}
