using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoWpf.Repository.Infrastructure
{
    public interface IDatabaseFactory : IDisposable
    {
        IDbConnection Get();
    }
}
