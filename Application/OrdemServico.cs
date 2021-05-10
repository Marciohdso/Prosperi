using Domain.Models;
using Domain.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    public class OrdemServico 
    {
        public Task<Os> InsereDadosOSAsync(Os ordemServicos)
        {
            throw new NotImplementedException();
        }

        public Os ObterOSAsync()
        {
            var teste = new Os
            {


                Numero_OS = "1",

                TituloServico = "teste",

                CNPJCliente = "123456789",

                NomeCliente = "TESTE",

                CPFPrestador = "123456789",

                NomePrestador = "TESTE",

                DataExecução = DateTime.Now.ToString(),

                ValorServico = 10

    };

            return teste;

        }
    }
}
