using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class AdminValidator : AbstractValidator<Admin>
    {
        public AdminValidator()
        {
            RuleFor(x => x.AdminUserName).NotEmpty().WithMessage("Admin mailini boş geçemezsiniz.");
            RuleFor(x => x.AdminUserPassword).NotEmpty().WithMessage("Admin şifresini boş geçemezsiniz.");
            RuleFor(x => x.AdminRole).NotEmpty().WithMessage("Admin rol kısmını boş geçemezsiniz.");
            RuleFor(x => x.AdminStatü).NotEmpty().WithMessage("Admin Statü kısmını boş geçemezsiniz.");
        }
    }
}
