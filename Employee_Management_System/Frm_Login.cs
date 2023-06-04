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
    public partial class Frm_Login : Form
    {
        public Frm_Login()
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
            if (Con.State != ConnectionState.Open)
            {
                Con.Close();
            }
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            Con_Open();
            
            int Cnt = 0;

            SqlCommand Cmd = new SqlCommand();

            Cmd.Connection = Con;
            Cmd.CommandText = "Select Count (*) from Login_Details Where UserName = @UNm And Password =@Pwd ";

            Cmd.Parameters.Add("UNm", SqlDbType.NVarChar).Value = tb_UserName.Text;
            Cmd.Parameters.Add("Pwd", SqlDbType.NVarChar).Value = tb_Password.Text;

            Cnt = Convert.ToInt32(Cmd.ExecuteScalar());

            if (Cnt > 0)
            {
                MessageBox.Show("Login Successful");

                Common_Content.Log_UName = tb_UserName.Text;

                Frm_Add_Employee_Details obj = new Frm_Add_Employee_Details();
                obj.Show();
                this.Hide();

            }
            else
            {
                lbl_Note.Text = "Incorect UserName  && Password";
                lbl_Note.ForeColor = Color.Red;
            }

            tb_UserName.Clear();
            tb_Password.Clear();

            Con_Close();
        }
    }
}
