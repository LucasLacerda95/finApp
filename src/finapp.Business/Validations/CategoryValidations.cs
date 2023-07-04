using FluentValidation;

namespace finnapp.Business.Models.Validations{


    public class CategoryValidation : AbstractValidator<Categories>
    {

        public  CategoryValidation()
        {

            RuleFor(c => c.CategoryName)
                .NotEmpty().WithMessage("O campo {PropertyName} precisa ser fornecido")
                .Length(2,200).WithMessage("O campo {PropertyName} precisa ter entre {MinLength} e {MaxLength} caracteres");

            RuleFor(c => c.CategoryType)
                .NotEmpty().WithMessage("O campo {PropertyName} precisa ser fornecido");

            RuleFor(c => c.CategoryRegisterDate)
                .NotEmpty().WithMessage("O campo {PropertyName} precisa ser fornecido");
                
        }

    }
}