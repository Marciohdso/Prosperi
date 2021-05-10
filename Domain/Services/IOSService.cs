using Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services
{
    public interface IOSService
    {
        /// <summary>
        /// Insere OS.
        /// </summary>
        /// <param name="documentos">Dados da OS.</param>
        /// <returns>OS cadastrada.</returns>
        Task<Os> InsereDadosOSAsync
            (Os ordemServicos);

        Task<IEnumerable<Os>> ObterOSAsync();
    }

}
