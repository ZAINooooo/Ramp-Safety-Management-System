using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using WindowsFormsApplication1;
using System.Configuration;


namespace piac_project
{
    public partial class login : Form
    {
        SqlConnection conn = new SqlConnection(DAL.DAL.SQLConnection());

        public login()
        {
            InitializeComponent();
            txt_password.PasswordChar='*';
            txt_password.MaxLength = 8;
            
        }

        public static string SQLConnection()
        {
            return ConfigurationManager.ConnectionStrings["piadb"].ConnectionString;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(SQLConnection());
            SqlCommand cm = new SqlCommand("Select * From Login where Username='"+ txt_userlogin.Text +"' AND Password = '"+txt_password.Text+"'", conn);
            SqlDataAdapter sda = new SqlDataAdapter(cm);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count> 0)
            {
                this.Hide();
                frmMain ss = new frmMain();
                ss.ShowDialog();
            }
            else
            {
                MessageBox.Show("Correct  your USERNAME and PASSWORD");
            }
        }
        private void login_Load(object sender, EventArgs e)
        {


             
        }

        private void txt_password_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(sender, e);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txt_password_TextChanged(object sender, EventArgs e)
        {

        }

    }
}