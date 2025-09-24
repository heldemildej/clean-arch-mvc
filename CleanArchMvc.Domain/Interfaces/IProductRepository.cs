using CleanArchMvc.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchMvc.Domain.Interfaces
{
    // Contrato para manipulação de produtos no domínio.
    public interface IProductRepository
    {
        // Retorna todos os produtos.
        Task<IEnumerable<Product>> GetProducts();

        // Retorna um produto pelo Id.
        Task<Product> GetByIdAsync(int? id);

        // Cria|Atualiza|Remove --> produto.
        Task<Product> CreateAsync(Product product);
        Task<Product> UpdateAsync(Product product);
        Task<Product> RemoveAsync(Product product);
    }
}
