using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace piac_project
{
    public partial class details : Form
    {
        int ID;
        SqlConnection conn = new SqlConnection(DAL.DAL.SQLConnection());


        public details(int id)
        {

            InitializeComponent();
            ID = id;
            textBox2_pass.PasswordChar = '*';
            textBox2_pass.MaxLength = 7;
        }

        private void details_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'piaDBDataSet.LOGIN' table. You can move, or remove it, as needed.
            FillGrid();

        }
        public void InsertInfo()
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO [DATABASE1].[dbo]. [Login] (USERNAME,PASSWORD)  VALUES(@USERNAME,@PASSWORD)", conn);
                cmd.Parameters.Add("@USERNAME",textBox1_user.Text );
                cmd.Parameters.Add("@PASSWORD", textBox2_pass.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("INSERTED!");
                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Err" + ex.Message);
            }

        }
        public void FillGrid()
        {
            conn.Open();
            SqlCommand cm = new SqlCommand("Select ID,USERNAME from LOGIN", conn);
            SqlDataAdapter da = new SqlDataAdapter(cm);
            DataTable dt = new DataTable();
            da.Fill(dt);
            //Grid_details.DataSource = dt;
            conn.Close();
        }

        private void button_proceed_Click(object sender, EventArgs e)
        {

            InsertInfo();
            MessageBox.Show("DETAILS Added!");
      
        }
             public void Update()
        {
            conn.Open();
            SqlCommand cm = new SqlCommand("UPDATE [DATABASE1].[dbo].[Login] SET [USERNAME] = @USERNAME, [PASSWORD] = @PASSWORD WHERE ID = @ID", conn);
            cm.Parameters.AddWithValue("ID", ID);
            cm.ExecuteNonQuery();
            MessageBox.Show("Updated!");
            conn.Close();


        }
    }
}