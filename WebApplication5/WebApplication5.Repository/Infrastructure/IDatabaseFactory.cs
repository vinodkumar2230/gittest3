using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication5.Repository.Repository;

namespace WebApplication5.Repository.Infrastructure
{
    public interface IDatabaseFactory : IDisposable
    {
        Employeecontext Get();
    }
}
