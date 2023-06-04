using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee_Management_System
{
    public partial class Frm_Add_Employee_Details : Form
    {
        public Frm_Add_Employee_Details()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=LAPTOP-S39PV0K7\MSSQLSERVER03;Initial Catalog=Employee_Management_System_DB;Integrated Security=True");

        void Con_Open()
        {
            if (Con.State != ConnectionState.Open)
            {
                Con.Open();
            }
        }

        void Con_Close()
        {
            if(Con.State != ConnectionState.Open)
            {
                Con.Close();
            }
        }

        private void Only_Numeric(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsControl(e.KeyChar) && (!Char.IsDigit(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void Only_Text(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsControl(e.KeyChar) && (!Char.IsLetter(e.KeyChar) && e.KeyChar != ' '))
            {
                e.Handled = true;
            }
        }
        void Clear_Controls()
        {
            tb_Employee_Name.Clear();
            tb_Mobile_No.Clear();
            dtp_DOB.Text = "31-12-2009";
            cmb_Disgination.SelectedIndex = -1;

            Auto_Incr();
            tb_Employee_ID.Focus();
        }

        void Auto_Incr()
        {
            Con_Open();

            int Cnt = 0;

            SqlCommand Cmd = new SqlCommand();

            Cmd.Connection = Con;
            Cmd.CommandText = "Select Count(*) from Employee_Details";

            Cnt = Convert.ToInt32(Cmd.ExecuteScalar());

            Cmd.Dispose();

            if (Cnt > 0)
            {
                ///Max EmpID
                Cmd.Connection = Con;
                Cmd.CommandText = "Select Max(Employee_ID) from Employee_Details";

                Cnt = Convert.ToInt32(Cmd.ExecuteScalar());

                Cnt = Cnt + 1;

            }
            else
            {
                Cnt = 101;
            }

            tb_Employee_ID.Text = Convert.ToString( Cnt );

            Con_Close();

        }

        private void Frm_Add_Employee_Details_Load(object sender, EventArgs e)
        {
            lbl_UName.Text = Common_Content.Log_UName;
            Auto_Incr();
            tb_Employee_ID.Focus();
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            Clear_Controls();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            Con_Open();

            if (tb_Employee_ID.Text != "" && tb_Employee_Name.Text != "" && tb_Mobile_No.Text != "" && cmb_Disgination.Text != "")
            {
                SqlCommand Cmd = new SqlCommand();

                Cmd.Connection = Con;
                Cmd.CommandText = "Insert Into Employee_Details Values(@EID, @ENm, @MobNo, @DOB, @Des)";

                Cmd.Parameters.Add("EID", SqlDbType.Int).Value = tb_Employee_ID.Text;
                Cmd.Parameters.Add("ENm", SqlDbType.VarChar).Value = tb_Employee_Name.Text;
                Cmd.Parameters.Add("MobNo", SqlDbType.Decimal).Value = tb_Mobile_No.Text;
                Cmd.Parameters.Add("DOB", SqlDbType.Date).Value = dtp_DOB.Value.Date;
                Cmd.Parameters.Add("Des", SqlDbType.NVarChar).Value = cmb_Disgination.Text;

                Cmd.ExecuteNonQuery();

                MessageBox.Show("Record Insert Successfully!!!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                Clear_Controls();
              
            }
            else
            {
                MessageBox.Show("1st Fill All Fields", "Incomplete Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Con_Close();
        }

        private void btn_Employee_List_Click(object sender, EventArgs e)
        {
            frm_Employee_Details_List Obj = new frm_Employee_Details_List();
            Obj.Show();
            this.Hide();

        }
       
        private void btn_Logout_Click(object sender, EventArgs e)
        {
            Frm_Login obj = new Frm_Login();
            obj.Show();
            this.Hide();
        }
    }
}
