using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OS.Dtos
{
    public class Os
    {
        public int Numero_OS { get; set; }

        [Required(ErrorMessage = "Título do serviço é obrigatório.")]
        public string TituloServico { get; set; }

        [Required(ErrorMessage = "CNPJ é obrigatório.")]
        public string CNPJCliente { get; set; }

        [Required(ErrorMessage = "Nome do cliente é obrigatório.")]
        public string NomeCliente { get; set; }

        [Required(ErrorMessage = "CPF do prestador de serviço é obrigatório.")]
        public string CPFPrestador { get; set; }

        [Required(ErrorMessage = "Nome do prestador é obrigatório.")]
        public string NomePrestador { get; set; }

        [Required(ErrorMessage = "Data da execução é obrigatória.")]
        public string DataExecução { get; set; }

        [Required(ErrorMessage = "Valor do serviço é obrigatório.")]
        public decimal ValorServico { get; set; }
    }
}
