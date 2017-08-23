using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication5.Repository.Entity;
using WebApplication5.Repository.Infrastructure;

namespace WebApplication5.Repository.Repository
{
    public class EmployeeRepository : RepositoryBase<Empl1>, IEmployeeRepository
    {
        public EmployeeRepository(IDatabaseFactory databaseFactory) : base(databaseFactory)
        {
        }
    }
    public interface IEmployeeRepository : IRepository<Empl1>
    {

    }
}
