using Microsoft.Extensions.DependencyInjection;
using SqlAdapter;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Domain.Adapters;
using System.Data.SqlClient;

namespace SqlAdapter1.Microsoft.Extensions.DependencyInjection
{
    public static class SqlAdapterServiceCollectionExtensions
    {
        [ExcludeFromCodeCoverage]
        public static IServiceCollection AddSqlAdapter(this IServiceCollection services,
    SqlAdapterConfiguration sqlAdapterConfiguration)
        {
            if (sqlAdapterConfiguration == null)
            {
                throw new ArgumentNullException(nameof(sqlAdapterConfiguration));
            }

            services.AddScoped<IOSSqlAdapter, OsSqlAdapter>();

            services.AddScoped<IDbConnection>(d =>
            {
                return new SqlConnection(sqlAdapterConfiguration.ConnectionString);
            });

            return services;
        }
    }
}
