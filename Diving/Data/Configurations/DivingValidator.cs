using DivingLogs.Dtos;
using DivingLogs.Models;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Diving_Log.Data.Configurations
{
    public class DivingValidator : AbstractValidator <DivingLogCreateDto>
    {
        public DivingValidator(){            
            RuleFor(x => x.DateLog).NotEmpty().NotNull();
            RuleFor(x => x.WindDirection).NotEmpty().NotNull();
            RuleFor(x => x.SurfaceCurrent).NotEmpty().NotNull();
            RuleFor(x => x.DiversNumber).NotEmpty().NotNull();
            RuleFor(x => x.DivingPermit).NotEmpty().NotNull();
            RuleFor(x => x.Observations).NotEmpty().NotNull();
            RuleFor(x => x.WaveHeight).NotEmpty().NotNull();
        }
    }
}
