using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class SkillValidator:AbstractValidator<Skill>
    {
        public SkillValidator()
        {
            RuleFor(x => x.Title).MaximumLength(25).WithMessage("25 karakterden fazla giremezsin");
            RuleFor(x => x.Value).NotEmpty().WithMessage("Değerini boş geçemezsin");
            RuleFor(x => x.Title).NotEmpty().WithMessage("Başlığını Boş Geçemezsin");
        }
    }
}
