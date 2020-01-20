using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeForm
{
    public partial class Employee : Form
    {
        private data _db;
        public Employee()
        {
            InitializeComponent();
            _db = new Database();
        }

        private void btn_log_Click(object sender, EventArgs e)
        {
            Emplo employee = new Emplo
            {
                Name = txbx_name.Text,
                SurName = txbx_surname.Text,
                ID = txbx_id.Text,
                BirthDate = txbx_date.Text,
                workID = txbx_work_id.Text,
                Company = cb_company.Text
            };

            _db.addEmployee(employee);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            rb_data.Clear();
            List<string> users = _db.Read();
            foreach (var item in users)
            {
                rb_data.Text += $"{item} \n";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            rb_log.Clear();
            List<string> users = _db.ReadLog();
            foreach (var item in users)
            {
                rb_log.Text += $"{item} \n";
            }
        }
    }
}
