using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.FluentValidation
{
    public class ProductValidator : AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("name is not null");
            RuleFor(x => x.Name).MinimumLength(3).WithMessage("name is min 3 character");
            RuleFor(x => x.Stock).NotEmpty().WithMessage("stock is not null");
            RuleFor(x => x.Price).NotEmpty().WithMessage("price is not null");

        }
    }
}
