using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchMvc.Domain.Entities
{
    // Entidade base para todas as entidades do domínio.
    // Define a propriedade de identidade única (Id).
    public abstract class Entity
    {
        // Identificador único da entidade.
        // Só pode ser alterado pela própria entidade ou classes derivadas.
        public int Id { get; protected set; }
    }
}
