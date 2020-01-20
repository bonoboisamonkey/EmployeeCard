using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace EmployeeForm
{
    class FileDatabase:data
    {
        public override void addEmployee(Emplo user)
        {
            DateTime now = DateTime.Now;
            string dataF = $"{now} {user.Name} {user.Company}";
            string data = $"{user.Name } {user.Company }";
            File.AppendAllLines("simple.txt",new List<string> { data } );
            File.AppendAllLines("log.txt", new List<string> { dataF });
        }

        public override List<string> Read()
        {
            return File.ReadAllLines("simple.txt").ToList();
        }
        public override List<string> ReadLog()
        {
            return File.ReadAllLines("log.txt").ToList();
        }
    }
}
