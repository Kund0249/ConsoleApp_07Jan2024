using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_07Jan2024.OOPS.Abstraction
{
    public class DepartmentRepository : IDepartmentRepository
    {
        public void Add(Department department)
        {
            //Code
        }

        public List<Department> GetDepartments()
        {
            throw new NotImplementedException();
        }

        public bool Remove(int DepartmentId)
        {
            throw new NotImplementedException();
        }

        public void Update(Department department)
        {
            throw new NotImplementedException();
        }
    }
}
