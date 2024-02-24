using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_07Jan2024.OOPS.Abstraction
{
   public interface IDepartmentRepository
    {
        void Add(Department department);
        void Update(Department department);
        bool Remove(int DepartmentId);

        List<Department> GetDepartments();
    }
}
