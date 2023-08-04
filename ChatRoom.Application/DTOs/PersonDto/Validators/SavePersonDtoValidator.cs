using FluentValidation;

namespace ChatRoom.Application.DTOs.PersonDto.Validators
{
    public class SavePersonDtoValidator : AbstractValidator<PersonDto>
    {
        public SavePersonDtoValidator()
        {
            RuleFor(p => p.Modified)
                .NotNull().WithMessage("تاریخ اخرین بروزرسانی نمیتواند خالی باشد")
                .Empty().WithMessage("تاریخ اخرین بروزرسانی نمی تواند خالی باشد");
            RuleFor(p => p.Name)
                .NotNull().WithMessage("")
                .NotEmpty().WithMessage("")
                .Length(3, 20).WithMessage("");
            RuleFor(p => p.PhoneNumber)
                .Length(11).WithMessage("شماره تلفن همره باید 11 رقم باشد");
            RuleFor(p => p.Status)
                .NotNull().WithMessage("وضعیت نباید نال باشد")
                .NotEmpty().WithMessage("وضعیت نمیتواند خالی باشد");
        }
    }
}
