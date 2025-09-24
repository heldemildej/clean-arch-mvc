using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchMvc.Domain.Validation
{
    // Exceção de domínio para centralizar validações de regras de negócio.
    public class DomainExceptionValidation : Exception
    {
        // Construtor que recebe a mensagem de erro e envia para a Exception base.
        public DomainExceptionValidation(string error) : base(error)
        {}

        // Lança a exceção quando a condição de erro for verdadeira.
        public static void When(bool hasError, string error)
        {
            if (hasError)
            {
                throw new DomainExceptionValidation(error);
            }
        }
    }
}
