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
    public partial class safetyViolation2 : Form
    {
        int ID;
        SqlConnection con = new SqlConnection(DAL.DAL.SQLConnection());


        public safetyViolation2()
        {
            InitializeComponent();
        }


        private void safetyViolation2_Load(object sender, EventArgs e)
        {
            FillGrid();
        }

        private void btnAdd_violation_Click(object sender, EventArgs e)
        {
            Form4 pp = new Form4(0);
            pp.ShowDialog();
            FillGrid();
        }

        private void btnEdit_violation_Click(object sender, EventArgs e)
        {
            Form4 pp = new Form4(ID);
            pp.ShowDialog();
            FillGrid();
        }

        private void btnDelete_violation_Click(object sender, EventArgs e)
        {
            DeleteInfo();
            MessageBox.Show("Information has Deleted");
            FillGrid();
        }

        public void DeleteInfo()
        {
            con.Open();
            SqlCommand cm = new SqlCommand("Delete from SAFETY_VIOLATION where id = @ID", con);
            cm.Parameters.AddWithValue("@ID", ID);
            cm.ExecuteNonQuery();
            con.Close();
        }

        public void FillGrid()
        {
            con.Open();
            SqlCommand cm = new SqlCommand("Select * from SAFETY_VIOLATION", con);
            SqlDataAdapter da = new SqlDataAdapter(cm);
            DataTable dt = new DataTable();
            da.Fill(dt);
            grdViolation.DataSource = dt;
            con.Close();
        }

        private void grdViolation_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ID = Convert.ToInt32(grdViolation.SelectedCells[0].Value);
        }

        private void btn_START2_Click(object sender, EventArgs e)
        {
            frmMain zl = new frmMain();
            zl.ShowDialog();
            this.Hide();
        }
   }
}
