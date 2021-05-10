using System;
using System.Data;
using System.Threading.Tasks;
using Dapper;
using System.Collections.Generic;
using Domain.Adapters;
using Domain.Models;

namespace SqlAdapter
{
    public class OsSqlAdapter : IOSSqlAdapter
    {

        private readonly IDbConnection dbConnection;

        public OsSqlAdapter(IDbConnection dbConnection)
        {
            this.dbConnection = dbConnection
                ?? throw new ArgumentNullException(nameof(dbConnection));
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        //public override bool Equals(object obj)
        //{
        //    return base.Equals(obj);
        //}

        //public override int GetHashCode()
        //{
        //    return base.GetHashCode();
        //}

        public async Task InsereOSAsync(Os ordemServico)


        {
            string sql = @"INSERT INTO os
                           Numero_OS, 
                           TituloServico,
                           CNPJCliente,
                           NomeCliente,
                           CPFPrestador,
                           NomePrestador,
                           DataExecução,
                           ValorServico)
                                  VALUES
                                       ( Numero_OS, 
                                        TituloServico,
                                        CNPJCliente,
                                        NomeCliente,
                                        CPFPrestador,
                                        NomePrestador,
                                        DataExecução,
                                        ValorServico)";

            await dbConnection.ExecuteAsync(sql, ordemServico);
        }


        public async Task<IEnumerable<Os>> ObterOSAsync()
        {

            string sql = @"select 
                           Numero_OS, 
                           TituloServico,
                           CNPJCliente,
                           NomeCliente,
                           CPFPrestador,
                           NomePrestador,
                           DataExecução,
                           ValorServico
                           from os";

            return await dbConnection.QueryAsync<Os>(sql);
        }

        public override string ToString()
        {
            return base.ToString();
        }

        //public override string ToString()
        //{
        //    return base.ToString();
        //}

    }
}
