using Entity.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Business.ValidationRules
{
    public class WriterValidator : AbstractValidator<Writer>
    {
        public WriterValidator()
        {
            RuleFor(x => x.WriterName).NotEmpty().WithMessage("Lütfen Yazar Adını Boş Bırakmayınız!");

            RuleFor(x => x.WriterAbout).NotEmpty().WithMessage("Lütfen Hakkımda kısmını Boş Bırakmayınız!");
            RuleFor(x => x.WriterName).MinimumLength(2).WithMessage("Lütfen en az 2 karakterlik bir Ad yazınız!");
            RuleFor(x => x.WriterPassword).NotEmpty().WithMessage("Şifre Boş Geçilemez.");
            RuleFor(x => x.WriterMail).NotEmpty().WithMessage("Mail Alanı Boş Geçilemez.");
            RuleFor(x => x.WriterMail).EmailAddress().WithMessage("Mail Adresiniz example@example.com Şeklinde Olmalıdır.");
            RuleFor(w => w.WriterPassword).Must(IsPasswordValid).WithMessage("Parolanızda en az bir küçük harf bir büyük harf ve rakam olmalıdır!");
            RuleFor(x => x.WriterImage).NotEmpty().WithMessage("Resim Yolu Boş Geçilemez.");

        }
        private bool IsPasswordValid(string arg)
        {
            try
            {
                Regex regex = new Regex(@"^(?=.*[A-Z])(?=.*[a-z])(?=.*\d)(?=.*[0-9])[A-Za-z\d]");
                return regex.IsMatch(arg);
            }
            catch
            {
                return false;
            }
        }
    }
}
