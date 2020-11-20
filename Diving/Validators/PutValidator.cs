using DivingLogs.Dtos;
using FluentValidation;

namespace Validators{
    public class DivingPutValidator : AbstractValidator <DivingLogUpdateDto>{
        
        public DivingPutValidator()
        {
            RuleFor(post  => post.DateLog)
               .Length(10)
               .NotEmpty().WithMessage("No puede estar vacio")
               .NotNull();

            RuleFor(post  => post.WindDirection)
               .Length(1,15)
               .NotEmpty().WithMessage("No puede estar vacio")
               .NotNull();
            
            RuleFor(post  => post.SurfaceCurrent)
               .Length(1,5)
               .NotEmpty().WithMessage("No puede estar vacio")
               .NotNull();
            
            RuleFor(post  => post.DivingPermit)
               .NotEmpty().WithMessage("No puede estar vacio")
               .NotNull();

            RuleFor(post  => post.DiversNumber)
               .Length(1,2)
               .NotEmpty().WithMessage("No puede estar vacio")
               .NotNull();

            RuleFor(post  => post.WaveHeight)
               .Length(1,2)
               .NotEmpty().WithMessage("No puede estar vacio")
               .NotNull();

            RuleFor(post  => post.Observations)
               .Length(1,20)
               .NotEmpty().WithMessage("No puede estar vacio")
               .NotNull();
        }
    }
}