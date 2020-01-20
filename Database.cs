using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeForm
{
    class Database:data
    {
        private static readonly List<string> _employee;
        private static readonly List<string> _logOfEmployee;
        static Database()
        {
            _employee = new List<string>();
            _logOfEmployee = new List<string>();
        }

        public override void addEmployee(Emplo user)
        {
            string userData = $"{user.Name} {user.SurName} {user.BirthDate} {user.BirthDate} {user.ID} {user.Company}";
            _employee.Add(userData);
            
            DateTime now = DateTime.Now;
            string userDataLog = $"{now} {user.Name} {user.SurName} {user.BirthDate} {user.BirthDate} {user.ID} {user.Company}";
            _logOfEmployee.Add(userDataLog);
        }

        public override List<string> Read()
        {
            return _employee;
        }

        public override List<string> ReadLog()
        {
            return _logOfEmployee;
        }
    }
}
