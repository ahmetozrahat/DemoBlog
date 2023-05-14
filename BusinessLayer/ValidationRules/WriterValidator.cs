using EntityLayer.Concrete;
using FluentValidation;

namespace BusinessLayer.ValidationRules
{
    public class WriterValidator: AbstractValidator<Writer>
    {
        public WriterValidator()
        {
            RuleFor(x => x.WriterName)
                .NotEmpty().WithMessage("Yazar adı soyadı kısmı boş geçilemez.")
                .MinimumLength(2).WithMessage("Yazar adı en az 2 karakterden oluşmalıdır.")
                .MaximumLength(50).WithMessage("Yazar adı en fazla 50 karakterden oluşmalıdır.");
            RuleFor(x => x.WriterMail)
                .NotEmpty().WithMessage("Mail adresi boş geçilemez.");
            RuleFor(x => x.WriterPassword)
                .NotEmpty().WithMessage("Parola boş geçilemez.")
                .Matches(@"[A-Z]+").WithMessage("Parola en az bir büyük harf içermelidir.")
                .Matches(@"[a-z]+").WithMessage("Parola en az bir küçük harf içermelidir.")
                .Matches(@"[0-9]+").WithMessage("Parola en az bir sayı içermelidir.");
        }
    }
}
