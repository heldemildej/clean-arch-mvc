using CleanArchMvc.Domain.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchMvc.Domain.Entities 
{
    // Produto de uma categoria
    public sealed class Product : Entity
    {
        // Propriedades do produto.
        public string Name { get; private set; }
        public string Description { get; private set; }
        public decimal Price { get; private set; }
        public int Stock { get; private set; }
        public string Img { get; private set; }

        // Construtor para novo produto.
        public Product(string name, string descrition, decimal price, int stock, string img)
        {
            ValidateDomain(name, descrition, price, stock, img);
        }

        // Construtor para produto existente.
        public Product(int id, string name, string descrition, decimal price, int stock, string img)
        {
            DomainExceptionValidation.When(id < 0, "Invalid Id value");
            Id = id;
            ValidateDomain(name, descrition, price, stock, img);
        }

        // Atualiza os dados do produto.
        public void Update(int id, string name, string descrition, decimal price, int stock, string img, int categoryId)
        {
            ValidateDomain(name, descrition, price, stock, img);
            CategoryId = categoryId;
        }

        // Valida regras de negócio antes de aplicar mudanças.
        private void ValidateDomain(string name, string descrition, decimal price, int stock, string img)
        {
            DomainExceptionValidation.When(string.IsNullOrEmpty(name),
                "Invalid name. Name requered");

            DomainExceptionValidation.When(name.Length < 3,
                "Invalid name, too short, minimum 3 characteres");

            DomainExceptionValidation.When(string.IsNullOrEmpty(descrition),
                "Invalid descrition. Descrition requered");

            DomainExceptionValidation.When(descrition.Length < 5,
                "Invalid desction, too short, minimum 5 characteres");

            DomainExceptionValidation.When(price < 0, "Invallid price value.");

            DomainExceptionValidation.When(stock < 0, "Invallid stock value.");

            DomainExceptionValidation.When(img.Length > 250, 
                "Invallid image name, too long, maximum 250 characteres.");

            Name = name;
            Description = descrition;
            Price = price;
            Stock = stock;
            Img = img;
        }

        // Relação N:1 → cada produto pertence a uma categoria.
        public int CategoryId { get; set; }
        public Category Category { get; set; }

    }
}
