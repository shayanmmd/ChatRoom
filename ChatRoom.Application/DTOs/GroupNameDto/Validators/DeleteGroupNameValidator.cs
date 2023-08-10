using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatRoom.Application.DTOs.GroupNameDto.Validators
{
    public class DeleteGroupNameValidator : AbstractValidator<GroupNameDto>
    {
        public DeleteGroupNameValidator()
        {
            RuleFor(p => p.Guid).NotNull().WithMessage("شناسه فرد برای حذف نمی تواند نال باشد")
           .NotEmpty().WithMessage("شناسه فرد برای حذف نمیتواند خالی باشد");
        }
    }
}
