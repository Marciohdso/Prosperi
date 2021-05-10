using Domain.Adapters;
using Domain.Models;
using Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Application
{
    public class OSService : IOSService
    {
        private readonly IOSSqlAdapter _osSqlAdapter;

        public OSService(IOSSqlAdapter osSqlAdapter)
        {
            _osSqlAdapter = osSqlAdapter
                ?? throw new ArgumentNullException(nameof(osSqlAdapter));
        }

        public async Task<Os> InsereDadosOSAsync(Os ordemServico)
        {
            if (ordemServico == null)
            {
                throw new ArgumentNullException(nameof(ordemServico));
            }

            //foreach (var documento in documentosProspect)
            //{
            //    ValidationHelper.ThrowValidationExceptionIfNotValid(documento);
            //    documento.IdDocumento = Guid.NewGuid();
            //}

            await _osSqlAdapter.InsereOSAsync(ordemServico);

            return ordemServico;
        }

        public async Task<IEnumerable<Os>> ObterOSAsync()
        {
            //if (ordemServico == null)
            //{
            //    throw new ArgumentNullException(nameof(ordemServico));
            //}

            //foreach (var documento in documentosProspect)
            //{
            //    ValidationHelper.ThrowValidationExceptionIfNotValid(documento);
            //    documento.IdDocumento = Guid.NewGuid();
            //}

            //var teste = new Os
            //{


            //    Numero_OS = 1,

            //    TituloServico = "teste",

            //    CNPJCliente = "123456789",

            //    NomeCliente = "TESTE",

            //    CPFPrestador = "123456789",

            //    NomePrestador = "TESTE",

            //    DataExecução = DateTime.Now.ToString(),

            //    ValorServico = 10

            //};

            //return teste;

            return await _osSqlAdapter.ObterOSAsync();
        }
    }
}
