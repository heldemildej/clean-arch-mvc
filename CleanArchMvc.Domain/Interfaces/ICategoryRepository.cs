using CleanArchMvc.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchMvc.Domain.Interfaces
{
    // Contrato para manipulação de categorias no domínio.
    public interface ICategoryRepository
    {
        // Retorna todas as categorias.
        Task<IEnumerable<Category>> GetCategories();

        // Retorna uma categoria pelo Id.
        Task<Category> GetByIdAsync(int? id);

        // Retorna uma categoria incluindo seus produtos.
        Task<Category> GetProductCategoryAsync(int? id);


        // Cria|Atualiza|Remove --> categoria.
        Task<Category> CreateAsync(Category category);
        Task<Category> UpdateAsync(Category category);
        Task<Category> RemoveAsync(Category category);
    }
}
