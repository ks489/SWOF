using SWOF.Service.Enums;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace SWOF.Service.Infrastructure.Interface
{
    public interface IConnection : IDisposable
    {
        IDbConnection GetConnection(DatabaseTypes type);
    }
}
