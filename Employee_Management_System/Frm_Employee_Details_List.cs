using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee_Management_System
{
    public partial class frm_Employee_Details_List : Form
    {
        public frm_Employee_Details_List()
        {
            InitializeComponent();
        }

        private void frm_Employee_Details_List_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'employee_Management_System_DBDataSet1.Employee_Details' table. You can move, or remove it, as needed.
            this.employee_DetailsTableAdapter.Fill(this.employee_Management_System_DBDataSet1.Employee_Details);

            lbl_UName.Text = Common_Content.Log_UName;
        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            Frm_Login Obj = new Frm_Login();
            Obj.Show();
            this.Hide();
        }

        private void btn_Employee_Details_Click(object sender, EventArgs e)
        {
            Frm_Add_Employee_Details Obj = new Frm_Add_Employee_Details();
            Obj.Show();
            this.Hide();

        }
    }
}
