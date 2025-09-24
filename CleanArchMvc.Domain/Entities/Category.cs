using CleanArchMvc.Domain.Validation;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchMvc.Domain.Entities
{
    // Categoria de produtos
    public sealed class Category : Entity
    {
        public string Name { get; set; }

        // Construtor para nova categoria.
        public Category(string name)
        {
            ValidateDomain(name);
        }

        // Construtor para categoria existente.
        public Category(int id, string name)
        {
            DomainExceptionValidation.When(id < 0, "Invalid Id value");
            Id = id;
            ValidateDomain(name);
        }

        // Atualiza o nome da categoria.
        public void Update(string name)
        {
            ValidateDomain(name);
        }

        // Aplica regras de negócio (invariantes).
        private void ValidateDomain(string name)
        {
            DomainExceptionValidation.When(string.IsNullOrEmpty(name),
                "Invalid name. Name is requerid");

            DomainExceptionValidation.When(name.Length < 3,
                "Invalid name too short, minimum 3 characteres");

            Name = name;

        }

        // Relação 1:N → uma categoria pode ter vários produtos.
        public ICollection<Product> Products { get; set; }
    }
}
