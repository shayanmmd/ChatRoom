using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatRoom.Application.DTOs.GroupNameDto.Validators
{
    public class AddGroupNameValidator : AbstractValidator<GroupNameDto>
    {
        public AddGroupNameValidator()
        {
            RuleFor(p => p.Guid).NotNull().WithMessage("برای افزودن گروهی جدید باید شناسه پر شود");
            RuleFor(p => p.Modified).NotNull().WithMessage("برای افزودن گروهی جدید باید تاریخ بروزرسانی پر شود");
            RuleFor(p => p.Name).NotNull().WithMessage("برای افزودن گروهی جدید باید نام گروه پر شود").NotEmpty().WithMessage("نام گروه نباید خالی باشد");
            RuleFor(p => p.Status).NotNull().WithMessage("برای افزودن گروهی جدید باید وضعیت گروه پر شود").NotEmpty(); ;

        }
    }
}
