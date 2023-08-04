using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;

namespace ChatRoom.Application.DTOs.PersonDto.Validators
{
    public class DeletePersonDtoValidator : AbstractValidator<PersonDto>
    {
        public DeletePersonDtoValidator()
        {
            RuleFor(p => p.Guid).NotNull().WithMessage("شناسه فرد برای حذف نمی تواند نال باشد")
                .NotEmpty().WithMessage("شناسه فرد برای حذف نمیتواند خالی باشد");
        }
    }
}
