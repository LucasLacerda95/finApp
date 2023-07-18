using finapp.Business.Models;
using FluentValidation;

namespace finnapp.Business.Models.Validations{


    public class AccountsValidation : AbstractValidator<Account>
    {

        public  AccountsValidation()
        {

            RuleFor(c => c.AccountName)
                .NotEmpty().WithMessage("O campo {PropertyName} precisa ser fornecido")
                .Length(2,200).WithMessage("O campo {PropertyName} precisa ter entre {MinLength} e {MaxLength} caracteres");

            RuleFor(c => c.AccountType)
                .NotEmpty().WithMessage("O campo {PropertyName} precisa ser fornecido");

            RuleFor(c => c.AccountDateRegister)
                .NotEmpty().WithMessage("O campo {PropertyName} precisa ser fornecido");

        }

    }
}