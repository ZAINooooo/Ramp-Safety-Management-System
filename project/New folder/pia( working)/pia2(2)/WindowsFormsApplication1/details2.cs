using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WindowsFormsApplication1;

namespace piac_project
{
    public partial class details2 : Form
    {
        int ID;
        SqlConnection con = new SqlConnection(DAL.DAL.SQLConnection());

        public details2()
        {
            InitializeComponent();
           
        }

        private void button_addi_Click(object sender, EventArgs e)
        {
            details pp = new details(0);
            pp.ShowDialog();
            FillGrid();
        }

        private void details2_Load(object sender, EventArgs e)
        {
            FillGrid();
        }

       

        private void button_dlt_Click(object sender, EventArgs e)
        {
            DeleteInfo();
            MessageBox.Show("Information has Deleted");
            FillGrid();
        }
        public void DeleteInfo()
        {
            con.Open();
            SqlCommand cm = new SqlCommand("DELETE FROM [DATABASE1].[dbo].[Login] where ID = @ID", con);
            cm.Parameters.AddWithValue("@ID", ID);
            cm.ExecuteNonQuery();
            con.Close();
        }
        public void FillGrid()
        {
            con.Open();
            SqlCommand cm = new SqlCommand("Select ID,USERNAME,PASSWORD from Login", con);
            SqlDataAdapter da = new SqlDataAdapter(cm);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView_det2.DataSource = dt;
            con.Close();
        }

        private void button_bck_Click(object sender, EventArgs e)
        {
            frmMain zl = new frmMain();
            zl.ShowDialog();
            this.Hide();
        }

        private void dataGridView_det2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ID = Convert.ToInt32(dataGridView_det2.SelectedCells[0].Value);
        }

        private void dataGridView_det2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

      
    }
}
