using Assignment.Data.Contexts;
using Assignment.Data.Entities;
using Assignment.Repository.Interfaces;

namespace Assignment.Repository.Repositories
{
    public class EmployeeRepository :GenericRepository<Employee>, IEmployeeRepository
    {
        private readonly AssignmentDBContext _context;

        public EmployeeRepository(AssignmentDBContext context):base(context) 
        {
            _context = context;
        }

       

   
    }
}
