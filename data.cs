using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeForm
{
    abstract class data
    {
        abstract public void addEmployee(Emplo user);
        abstract public List<string> Read();
        abstract public List<string> ReadLog();
    }
}
