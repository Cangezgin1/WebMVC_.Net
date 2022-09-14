﻿using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class MessageValidator : AbstractValidator<Message>
    {
        public MessageValidator()
        {
            RuleFor(x => x.ReceiverMail).NotEmpty().WithMessage("Alıcı adresini boş geçemezsiniz.");
            RuleFor(x => x.Subject).NotEmpty().WithMessage("Konuyu boş geçemezsiniz.");
            RuleFor(x => x.MessageContent).NotEmpty().WithMessage("İçeriği boş geçemezsiniz.");
            RuleFor(x => x.Subject).MinimumLength(3).WithMessage("En az üç karakter olmalı.");
            RuleFor(x => x.Subject).MaximumLength(100).WithMessage("En fazla 100 karakter olmalı.");
        }
    }
}
