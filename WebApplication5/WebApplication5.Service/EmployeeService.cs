using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication5.Repository.Entity;
using WebApplication5.Repository.Infrastructure;
using WebApplication5.Repository.Repository;
using WebApplication5.Service;

namespace WebApplication5.Service
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository employeeRepository;
        private readonly IUnitOfWork unitOfWork;

        public EmployeeService(IEmployeeRepository employeeRepository, IUnitOfWork unitOfWork)
        {
            this.employeeRepository = employeeRepository;
            this.unitOfWork = unitOfWork;
        }

        public IEnumerable<Empl1> GetAllCustomers()
        {
            return employeeRepository.GetAll();
        }
    }

    public interface IEmployeeService
    {
        IEnumerable<Empl1> GetAllCustomers();
    }
}