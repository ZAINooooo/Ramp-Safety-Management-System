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
    public partial class MEDICAL2 : Form
    {

        int ID;
        SqlConnection con = new SqlConnection(DAL.DAL.SQLConnection());

        public MEDICAL2()
        {
            InitializeComponent();
           // txt_pn.PasswordChar = '*';
            //txt_pn.MaxLength = 13;
           
            

        }

        private void btn_addition_Click(object sender, EventArgs e)
        {
            Form2 polo = new Form2(0);
            polo.ShowDialog();
            FillGrid();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            DeleteInfo();
            MessageBox.Show("Information has Deleted");
            FillGrid();
        }

        public void DeleteInfo()
        {
            con.Open();
            SqlCommand cm = new SqlCommand("Delete from MEDICAL_CERTIFICATION where id =@ID", con);
            cm.Parameters.AddWithValue("@ID", ID);
            cm.ExecuteNonQuery();
            con.Close();
        }

        public void FillGrid()
        {
            con.Open();
            SqlCommand cm = new SqlCommand("Select * from MEDICAL_CERTIFICATION", con);
            SqlDataAdapter da = new SqlDataAdapter(cm);
            DataTable dt = new DataTable();
            da.Fill(dt);
            grdmedical.DataSource = dt;
            con.Close();
        }
        private void btn_update_Click(object sender, EventArgs e)
        {
            Form2 pi = new Form2(ID);
            pi.ShowDialog();
            FillGrid();
        }

        private void MEDICAL2_Load(object sender, EventArgs e)
        {
            FillGrid();
        }

        private void grdmedical_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ID = Convert.ToInt32(grdmedical.SelectedCells[0].Value);
        }

        private void btn_Back3_Click(object sender, EventArgs e)
        {
            frmMain zl = new frmMain();
            zl.ShowDialog();
            //this.Hide();
        }

    }
}
