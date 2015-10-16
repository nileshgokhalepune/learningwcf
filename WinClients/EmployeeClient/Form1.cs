using EmployeeClient.EmployeeService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EmployeeClient
{
    public partial class Form1 : Form
    {
        PrivateEmployeeServiceClient client = new PrivateEmployeeServiceClient();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGet_Click(object sender, EventArgs e)

        {
            //PublicEmployeeServiceClient client = new PublicEmployeeServiceClient("BasicHttpBinding_IPublicEmployeeService");
            var emp = client.Get(Convert.ToInt32(txtId.Text));
            txtName.Text = emp.Name;
            cmbGender.SelectedItem = emp.Gender;
            cmbType.SelectedItem = emp.Type.ToString();
            dtDob.Value = emp.DateOfBirth;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //PrivateEmployeeServiceClient client = new PrivateEmployeeServiceClient();

            EmployeeType type = (EmployeeType)Enum.Parse(typeof(EmployeeType), cmbType.Text);
            Employee emp;
            //if (type == EmployeeType.ContractEmployye)
            //{
            //    emp = new ContractEmployee
            //    {
            //        Name = txtName.Text,
            //        Gender = cmbGender.SelectedText,
            //        Type = type,
            //        DateOfBirth = dtDob.Value
            //    };
            //}
            //else
            //{
            //    emp = new PermanantEmployee
            //    {
            //        Name = txtName.Text,
            //        Gender = cmbGender.SelectedText,
            //        Type = type,
            //        DateOfBirth = dtDob.Value

            //    };
            //}
            //client.SaveEmployee(emp);
        }
    }
}
