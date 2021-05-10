using Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Adapters
{
    public interface IOSSqlAdapter
    {
        /// <summary>
        /// Insere as ordem de serviços.
        /// </summary>
        /// <param name="ordemServico">Dados da OS.</param>
        /// <returns></returns>
        Task InsereOSAsync(Os ordemServico);

        Task<IEnumerable<Os>> ObterOSAsync();
    }
}
