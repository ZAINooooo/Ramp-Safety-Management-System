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
    public partial class frmPersonalInfo : Form
    {
        int ID;
        SqlConnection con = new SqlConnection(DAL.DAL.SQLConnection());

        public frmPersonalInfo()
        {
            InitializeComponent();
        }

        private void frmPersonalInfo_Load(object sender, EventArgs e)
        {
            FillGrid();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddPersonalInfo pi = new frmAddPersonalInfo(0);
            pi.ShowDialog();
            FillGrid();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            frmAddPersonalInfo pi = new frmAddPersonalInfo(ID);
            pi.ShowDialog();
            FillGrid();
          
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteInfo();
            MessageBox.Show("Information has Deleted");
            FillGrid();
        }

        private void grdPersonalInfo_Click(object sender, EventArgs e)
        {
            ID = Convert.ToInt32(grdPersonalInfo.SelectedCells[0].Value);
        }

        public void DeleteInfo()
        {
            con.Open();
            SqlCommand cm = new SqlCommand("Delete from PERSONAL_INFO where ID = @ID", con);
            cm.Parameters.AddWithValue("@ID",ID);
            cm.ExecuteNonQuery();
            con.Close();
        }

        public void FillGrid()
        {
            con.Open();
            SqlCommand cm = new SqlCommand("Select * from PERSONAL_INFO", con);
            SqlDataAdapter da = new SqlDataAdapter(cm);
            DataTable dt = new DataTable();
            da.Fill(dt);
            grdPersonalInfo.DataSource = dt;
            con.Close();
        }

        private void grdPersonalInfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_start1_Click(object sender, EventArgs e)
        {
            frmMain zl = new frmMain();
            zl.ShowDialog();
           // this.Close();
        }

      
    }
}
