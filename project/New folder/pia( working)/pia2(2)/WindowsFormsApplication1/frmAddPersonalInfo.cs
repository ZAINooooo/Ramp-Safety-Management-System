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

namespace piac_project
{
    public partial class frmAddPersonalInfo : Form
    {
        int ID;
        SqlConnection conn = new SqlConnection(DAL.DAL.SQLConnection());

        public frmAddPersonalInfo(int id)
        {
            InitializeComponent();
            ID = id;
           txtBxcnic.PasswordChar = '*';
            txtBxcnic.MaxLength = 13;
           txtBxpnr.PasswordChar = '*';
            txtBxpnr.MaxLength = 5;
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            pbxinsrt.ImageLocation = ofd.FileName;
        }

        private void btnClr_Click(object sender, EventArgs e)
        {
            ClearScreen();
        }

        private void frmPersonalInfo_Load(object sender, EventArgs e)
        {
            if (ID == 0)
            {
                btnSave.Text = "Add";
            }
            else
            {
                btnSave.Text = "Save";
                DataBinding();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            //try
            //{
            //    validation va = new validation();
            //    va.chekName(txtName.Text);
            //}
            //catch (Exception Ex)
            //{

            //    MessageBox.Show(Ex.Message.ToString());
            //}
            //NAME VALIDATION
            //if (String.IsNullOrEmpty(txtName.Text) || txtName.Text.Any(c => Char.IsNumber(c)))
            //{
            //    MessageBox.Show(" Name IS REQUIRED");
            //          txtName.Focus();
            //}

            //         //CNIC VALIDATION
            //Regex regex = new Regex("^[0-9]*$");
            //if (regex.IsMatch(txtBxcnic.Text))
            //{
            //    errorProvider1.SetError(txtBxcnic, String.Empty);
            //}
            //else
            //{
            //    errorProvider1.SetError(txtBxcnic,
            //          "Only numbers may be entered here");
            //}

            string Name = string.Empty;
            string NIC = string.Empty;
            string PR = string.Empty;

            if (validation.chekName(txtName.Text) != "")
            {
                Name = validation.chekName(txtName.Text);
            }

            if (validation.cheknic(txtBxcnic.Text) != "")
            {
                NIC = validation.cheknic(txtBxcnic.Text);
            }
            if (validation.chekpnr(txtBxpnr.Text) != "")
            {
                PR = validation.chekpnr(txtBxpnr.Text);
            }

            if (ID == 0)
            {
                //validation va = new validation();
                //    va.chekName(txtName.Text);
                

                if (Name != "" && NIC != "" && PR != "")
                {
                    InsertInfo(Name, NIC, PR);
                    MessageBox.Show("Added!");
                    ClearScreen();
                    
                }
            }
            else
            {
                if (Name != "" && NIC != "" && PR != "")
                {
                    UpdateInfo();
                    MessageBox.Show("Edited!");
                }
            }
            
        }
        public void InsertInfo(string _name,string _NIC,string _PR)
        {
            try
            {

                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO PERSONAL_INFO (NAME,DESG,DPT,SEC,P_N,CNIC,IMAGES) VALUES (@NAME,@DESG,@DPT,@SEC,@P_N,@CNIC,@IMAGES)", conn);
                cmd.Parameters.Add("@NAME", _name);
                cmd.Parameters.Add("@DESG", cmbxdesg.SelectedItem.ToString());
                cmd.Parameters.Add("@DPT", txtBxdeppt.Text);
                cmd.Parameters.Add("@P_N", _PR);
                cmd.Parameters.Add("@CNIC",_NIC);
                cmd.Parameters.Add("@SEC", txtBxsec.Text);
                cmd.Parameters.Add("@IMAGES", pbxinsrt.ImageLocation);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Err" + ex.Message);

            }

        }

    
        public void UpdateInfo()
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("Update PERSONAL_INFO Set NAME=@NAME,DESG=@DESG,DPT=@DPT,SEC=@SEC,P_N=@P_N,CNIC=@CNIC,IMAGES=@IMAGES where id = @ID", conn);
                cmd.Parameters.AddWithValue("@ID", ID);
                cmd.Parameters.Add("@NAME", txtName.Text);
                cmd.Parameters.Add("@DESG", cmbxdesg.SelectedItem.ToString());
                cmd.Parameters.Add("@DPT", txtBxdeppt.Text);
                cmd.Parameters.Add("@P_N", txtBxpnr.Text);
                cmd.Parameters.Add("@CNIC", txtBxcnic.Text);
                cmd.Parameters.Add("@SEC", txtBxsec.Text);
                cmd.Parameters.Add("@IMAGES", pbxinsrt.ImageLocation);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void DataBinding()
        {
            try
            {
                conn.Open();
                SqlCommand cm = new SqlCommand("select * from PERSONAL_INFO where ID = @ID", conn);
                cm.Parameters.AddWithValue("@ID", ID);
                SqlDataReader dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    txtName.Text = dr["NAME"].ToString();
                    txtBxdeppt.Text = dr["DPT"].ToString();
                    txtBxpnr.Text = dr["P_N"].ToString();
                    txtBxsec.Text = dr["SEC"].ToString();
                    txtBxcnic.Text = dr["CNIC"].ToString();
                    cmbxdesg.SelectedText = dr["DESG"].ToString();
                    pbxinsrt.ImageLocation = dr["IMAGES"].ToString();
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Err" + ex.Message);
            }
        }

        public void ClearScreen()
        {
            txtName.Clear();
            txtBxdeppt.Clear();
            txtBxpnr.Clear();
            txtBxsec.Clear();
            txtBxcnic.Clear();
            cmbxdesg.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmPersonalInfo zl = new frmPersonalInfo();
            zl.ShowDialog();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

