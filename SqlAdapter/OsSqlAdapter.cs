using System;
using System.Data;
using System.Threading.Tasks;
using Dapper;
using System.Collections.Generic;
using Domain.Adapters;
using Domain.Models;

namespace SqlAdapter1
{
    public class OsSqlAdapter
    {
        public class OsSqlAdapter : IOSSqlAdapter, IOsSqlAdapter
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

            public async Task InsereOSAsync(IEnumerable<Os> ordemServico)
            {
                string sql = @"INSERT INTO DocumentoProspect
                                       (IdDocumento,
                                        IdDocumentoSantander,
                                        IdDocumentoGed,
                                        DataInclusao,
                                        IdProspect)
                                  VALUES
                                       (@IdDocumento,
                                        @IdDocumentoSantander,
                                        @IdDocumentoGed,
                                        Sysdatetimeoffset(),
                                        @IdProspect)";

                await dbConnection.ExecuteAsync(sql, ordemServico);
            }

            public override string ToString()
            {
                return base.ToString();
            }
        }
    }
}
