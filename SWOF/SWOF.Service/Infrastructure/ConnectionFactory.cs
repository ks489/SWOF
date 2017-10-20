using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Protocols;
using SWOF.Service.Enums;
using SWOF.Service.Infrastructure.Interface;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace SWOF.Service.Infrastructure
{
    public class ConnectionFactory : IConnection
    {
        #region Private Variables
        private bool disposedValue = false;
        private IConfiguration _connection;
        #endregion

        public ConnectionFactory(IConfiguration connection)
        {
            _connection = connection;
        }

        public IDbConnection GetConnection(DatabaseTypes type)
        {
            //If you have a polyglot of database sources then you can return the right connection according to the database you want to use 
            //and what connection is stored in the application configuration
            string stringConnection = _connection.GetSection("Data").GetSection(type.ToString()).Value;
            //Need to provide a factory abstraction here to get the relevent datasource connection
            return new SqlConnection(stringConnection);
        }

        #region IDisposable Support
        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {

                }
                disposedValue = true;
            }
        }
        public void Dispose()
        {
            Dispose(true);
        }
        #endregion
    }
}
