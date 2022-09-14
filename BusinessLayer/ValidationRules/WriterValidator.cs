using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class WriterValidator : AbstractValidator<Writer>
    {
        public WriterValidator()
        {
            RuleFor(x => x.WriterName).NotEmpty().WithMessage("Yazar adını boş geçemezsiniz.");
            RuleFor(x => x.WriterSurName).NotEmpty().WithMessage("Yazar soyadını boş geçemezsiniz.");
            RuleFor(x => x.WriterTitle).NotEmpty().WithMessage("Yazar Unvan kısmını boş geçemezsiniz.");
            RuleFor(x => x.WriterAbout).NotEmpty().WithMessage("Hakkında kısmını boş geçemezsiniz.");
            RuleFor(x => x.WriterSurName).MaximumLength(50).WithMessage("En fazla 50 karakter olmalı.");
            RuleFor(x => x.WriterSurName).MinimumLength(3).WithMessage("En az 3 karakter olmalı");
        }
    }
}
