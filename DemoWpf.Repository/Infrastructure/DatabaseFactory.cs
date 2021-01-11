using DemoWpf.Common;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoWpf.Repository.Infrastructure
{

    public class DatabaseFactory : IDatabaseFactory, IDisposable
    {
        private IDbConnection _dbContext;

        public IDbConnection Get()
        {
            if (_dbContext == null)
            {
                try
                {
                    _dbContext = new SqlConnection(Configurations.GetConnectionString("WpfDatabase"));
                }
                catch (Exception ex)
                {
                    Logger.Error("Exception in creating SqlConnection", ex);
                }
            }
            return _dbContext;
        }

        public void Dispose()
        {
            if (_dbContext != null)
                _dbContext.Dispose();
        }
    }
}
