using Assignment.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Service.Interfaces
{
    public interface IDepartmentService
    {
        Department GetById(int? id);
        IEnumerable<Department > GetAll();
        void Add(Department  department);
        void Update(Department  department);
        void Delete(Department  department);
    }
}
