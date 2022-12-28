using ECommerceAPI.Application.ViewModels.Products;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceAPI.Application.Validators.Products
{
    public class CreateProductValidator : AbstractValidator<VM_Create_Product>
    {
        public CreateProductValidator()
        {
            RuleFor(c => c.Name)
                .NotEmpty()
                .NotNull()
                    .WithMessage("Lütfen ürün adını boş geçmeyiniz")
                .MinimumLength(5)
                .MaximumLength(150)
                    .WithMessage("Lütfen ürün adını 5-150 karakter arasında giriniz");

            RuleFor(p => p.Stock)
                .NotNull()
                .NotEmpty()
                .WithMessage("Lütfen stok bilgisini boş geçmeyiniz")
                .Must(s => s >= 0)
                .WithMessage("Stok bilgisi negatif olamaz!");

            RuleFor(p => p.Price)
                .NotNull()
                .NotEmpty()
                    .WithMessage("Lütfen fiyat bilgisini boş geçmeyiniz")
                .Must(s => s >= 0)
                    .WithMessage("Fiyat bilgisi negatif olamaz!");

        }
    }
}
