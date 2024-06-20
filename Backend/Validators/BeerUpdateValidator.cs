using Backend.DTOs;
using FluentValidation;

namespace Backend.Validators
{
    public class BeerUpdateValidator : AbstractValidator<BeerUpdateDto>
    {
        public BeerUpdateValidator() {
            RuleFor(x => x.Id).NotEmpty().WithMessage("El Id es obligatorio");
            RuleFor(x => x.Name).NotEmpty().WithMessage("El nombre es obligatorio");
            RuleFor(x => x.Name).Length(2, 20).WithMessage("El nombre debe medir entre 2 a 20 caracteres");
            RuleFor(x => x.BrandId).NotEmpty().WithMessage("La marca es obligatorio");
            RuleFor(x => x.BrandId).GreaterThan(0).WithMessage("Error con el valor enviadod e la marca");
            RuleFor(x => x.Alcohol).GreaterThan(0).WithMessage("El {PropertyName} debe ser mayor a 0");
        }
    }
}
