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
    public partial class RampSafety2 : Form
    {

        int ID;
        SqlConnection con = new SqlConnection(DAL.DAL.SQLConnection());


        public RampSafety2()
        {
            InitializeComponent();
        }

        private void btn_update_safety_Click(object sender, EventArgs e)
        {
            Form3 pi = new Form3(ID);
            pi.ShowDialog();
            FillGrid();
        }

        private void btn_delete_safety_Click(object sender, EventArgs e)
        {
            DeleteInfo();
            MessageBox.Show("Information has Deleted");
            FillGrid();
        }

        private void btn_addition_safety_Click(object sender, EventArgs e)
        {

            Form3 pi = new Form3(0);
            pi.ShowDialog();
            FillGrid();
        }

        private void RampSafety2_Load(object sender, EventArgs e)
        {
            FillGrid();
        }

        public void DeleteInfo()
        {
            con.Open();
            SqlCommand cm = new SqlCommand("Delete from RAMP_SAFETY_TRAINING where id = @ID", con);
            cm.Parameters.AddWithValue("@ID", ID);
            cm.ExecuteNonQuery();
            con.Close();
        }
        public void FillGrid()
        {
            con.Open();
            SqlCommand cm = new SqlCommand("Select * from RAMP_SAFETY_TRAINING", con);
            SqlDataAdapter da = new SqlDataAdapter(cm);
            DataTable dp = new DataTable();
            da.Fill(dp);
            grdRampSafety.DataSource = dp;
            con.Close();
        }

        private void btn_BACK4_Click(object sender, EventArgs e)
        {
            frmMain zl = new frmMain();
            zl.ShowDialog();
            
        }

        private void grdRampSafety_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ID = Convert.ToInt32(grdRampSafety.SelectedCells[0].Value);
        }
    }
}
