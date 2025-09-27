using CleanArchMvc.Domain.Entities;
using FluentAssertions;
using System;
using Xunit;

namespace CleanArchMvc.Domain.Tests
{
    public class ProductUnitTest1
    {
        [Fact]
        public void CreateProduct_WhithValidateParameters_ResultObjectValidState()
        {
            Action action = () => new Product(1, "Product Name", "Product Descrition", 9.99m, 99, "Product image");
            action.Should()
                .NotThrow<CleanArchMvc.Domain.Validation.DomainExceptionValidation>();
        }

        [Fact]
        public void CreateProduct_NegativeIdValue_DomainExceptionInvalidId()
        {
            Action action = () => new Product(-1, "Product Name", "Product Descrition", 9.99m, 99, "Product image");
            action.Should()
                .Throw<CleanArchMvc.Domain.Validation.DomainExceptionValidation>()
                .WithMessage("Invalid Id value");
        }

        [Fact]
        public void CreateProduct_EmptyNameValue_DomainExceptionRequiredName()
        {
            Action action = () => new Product(1, "", "Product Description", 9.99m, 10, "image.png");
            action.Should()
                .Throw<CleanArchMvc.Domain.Validation.DomainExceptionValidation>()
                .WithMessage("Invalid name. Name requered");
        }

        [Fact]
        public void CreateProduct_NullNameValue_DomainExceptionRequiredName()
        {
            Action action = () => new Product(1, null, "Product Description", 9.99m, 10, "image.png");
            action.Should()
                .Throw<CleanArchMvc.Domain.Validation.DomainExceptionValidation>()
                .WithMessage("Invalid name. Name requered");
        }

        [Fact]
        public void CreateProduct_EmptyDescriptionValue_DomainExceptionRequiredDescription()
        {
            Action action = () => new Product(1, "Product Name", "", 9.99m, 10, "image.png");
            action.Should()
                .Throw<CleanArchMvc.Domain.Validation.DomainExceptionValidation>()
                .WithMessage("Invalid descrition. Descrition requered");
        }

        [Fact]
        public void CreateProduct_NullDescriptionValue_DomainExceptionRequiredDescription()
        {
            Action action = () => new Product(1, "Product Name", null, 9.99m, 10, "image.png");
            action.Should()
                .Throw<CleanArchMvc.Domain.Validation.DomainExceptionValidation>()
                .WithMessage("Invalid descrition. Descrition requered");
        }


        [Fact]
        public void CreateProduct_ShortNameValue_DomainExceptionShortName()
        {
            Action action = () => new Product(1, "Hd", "Product Descrition", 9.99m, 99, "Product image");
            action.Should()
                .Throw<CleanArchMvc.Domain.Validation.DomainExceptionValidation>()
                .WithMessage("Invalid name, too short, minimum 3 characteres");
        }

        [Fact]
        public void CreateProduct_ShortDescritionValue_DomainExceptionShortDescrition()
        {
            Action action = () => new Product(1, "Product Name", "Pro", 9.99m, 99, "Product image");
            action.Should()
                .Throw<CleanArchMvc.Domain.Validation.DomainExceptionValidation>()
                .WithMessage("Invalid descrition, too short, minimum 5 characteres");
        }

        [Fact]
        public void CreateProduct_LongImageNameValue_DomainExceptionLongImageName()
        {
            Action action = () => new Product(1, "Product Name", "Product Descrition", 9.99m,
                99, "Product image hellllllllllllllllllllllllllllllllllllllllllllllllllllllllllllllllllllllllllllllllllllllllllllllllllllllllllllllllllllllllllllllllllllllllllllllllllllllllllllllllllllllllllllllllllllllllllllllllllllllllllllllllllllllllllldllllllllllllllllllllllllllllllllllllllllllllllll");
            action.Should()
                .Throw<CleanArchMvc.Domain.Validation.DomainExceptionValidation>()
                .WithMessage("Invalid image name, too long, maximum 250 characteres.");
        }

        [Fact]
        public void CreateProduct_WhithNullImageName_NoDomainException()
        {
            Action action = () => new Product(1, "Product Name", "Product Descrition", 9.99m, 99, null);
            action.Should()
                .NotThrow<CleanArchMvc.Domain.Validation.DomainExceptionValidation>();
        }

        [Fact]
        public void CreateProduct_WhithNullImageName_NoNullReferenceException()
        {
            Action action = () => new Product(1, "Product Name", "Product Descrition", 9.99m, 99, null);
            action.Should()
                .NotThrow<NullReferenceException>();
        }

        [Fact]
        public void CreateProduct_WhithEmptyImageName_NoDomainException()
        {
            Action action = () => new Product(1, "Product Name", "Product Descrition", 9.99m, 99, "");
            action.Should()
                .NotThrow<CleanArchMvc.Domain.Validation.DomainExceptionValidation>();
        }

        [Fact]
        public void CreateProduct_InvalidPriceValue_DomainException()
        {
            Action action = () => new Product(1, "Product Name", "Product Descrition", -9.99m, 99, "Product image");
            action.Should()
                .Throw<CleanArchMvc.Domain.Validation.DomainExceptionValidation>()
                .WithMessage("Invalid price value.");
        }

        [Theory]
        [InlineData(-5)]
        public void CreateProduct_InvalidStockValue_ExceptionDomainNegativeValue(int value)
        {
            Action action = () => new Product(1, "Product Name", "Product Descrition", 9.99m, value, "Product image");
            action.Should()
                .Throw<CleanArchMvc.Domain.Validation.DomainExceptionValidation>()
                .WithMessage("Invalid stock value.");
        }
    }
}
