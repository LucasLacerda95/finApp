using System.Data;
using FluentValidation;

namespace finapp.Business.Models.Validations
{

    public class AccountValidation : AbstractValidator<Account>
    {
        public AccountValidation()
        {
             RuleFor(a => a.AccountType).IsInEnum().WithMessage("O valor definido no campo {PropertyName} é inválido");

            RuleFor(a => a.AccountName)
                .NotEmpty().WithMessage("O campo {PropertyName} precisa ser fornecido")
                .Length(4,200).WithMessage("O campo {PropertyName} precisa ter entre {MinLength} e {MaxLength} caracteres");

        }
    }
}