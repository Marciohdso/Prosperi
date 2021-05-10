using Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SqlAdapter1
{
    public interface IOsSqlAdapter
    {
        bool Equals(object obj);
        int GetHashCode();
        Task InsereOSAsync(IEnumerable<Os> ordemServico);
        string ToString();
    }
}