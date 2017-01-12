using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Data.SqlClient;
using piac_project.DAL;
using piac_project;


namespace WindowsFormsApplication1
{
    public partial class Form4 : Form
    {
        int ID;
    
        SqlConnection conn = new SqlConnection(DAL.SQLConnection());
        public Form4(int id)
        {
            InitializeComponent();
            ID = id;
            txt_pnrr.PasswordChar = '*';
            txt_pnrr.MaxLength = 5;

        }


        public void InsertInfo()
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO [DATABASE1].[dbo].[SAFETY_VIOLATION] ([P_N] ,[DATE],[VIOLATION],[SAFETY_INSPECTOR]) VALUES (@P_N ,@DATE ,@VIOLATION,@SAFETY_INSPECTOR )", conn);

                cmd.Parameters.Add("@DATE", dtetime3.Value);
                if (rdbtnYes.Checked)
                {
                    cmd.Parameters.Add("@VIOLATION", true);
                }
                else
                {
                    cmd.Parameters.Add("@VIOLATION", false);
                }
                cmd.Parameters.Add("@SAFETY_INSPECTOR", txt_inspector.Text);
                cmd.Parameters.Add("@P_N", Convert.ToInt32 (txt_pnrr.Text));
                

                cmd.ExecuteNonQuery();
                MessageBox.Show("Added");
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Err" + ex.Message);
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            safetyViolation2 frm = new safetyViolation2();
            frm.ShowDialog();
        }

        private void SEARCH_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            FillData(ID);
        }

        private void btnproc_Click(object sender, EventArgs e)
        {
            if (ID == 0)
            {
                InsertInfo();
                
                
                
            }
            else
            {
                Update();
                
            }
            
        }

        public void FillData(int _id)
        {
            conn.Open();
            SqlCommand cm = new SqlCommand("Select * from SAFETY_VIOLATION where id ="+_id+" ", conn);

            SqlDataReader dr = cm.ExecuteReader();
            while (dr.Read())
            {
                dtetime3.Value = Convert.ToDateTime(dr["DATE"]);
                if (Convert.ToBoolean(dr["VIOLATION"]) == true)
                {
                    rdbtnYes.Checked = true;
                }
                else
                {
                    rdbtnNo.Checked = true;
                }

                txt_inspector.Text = dr["SAFETY_INSPECTOR"].ToString();
                txt_pnrr.Text = dr["P_N"].ToString();
                
            }
            conn.Close();
        }

        public void Update()
        {
            conn.Open();
            SqlCommand cm = new SqlCommand("UPDATE [DATABASE1].[dbo].[SAFETY_VIOLATION] SET [P_N] = @P_N,[DATE] = @DATE,[VIOLATION] = @VIOLATION,[SAFETY_INSPECTOR] = @SAFETY_INSPECTOR WHERE id = @S_ID", conn);
            cm.Parameters.AddWithValue("@P_N",Convert.ToInt32(txt_pnrr.Text));
            cm.Parameters.AddWithValue("@DATE",dtetime3.Value);
            if (rdbtnYes.Checked)
            {
                cm.Parameters.AddWithValue("@VIOLATION",true);
            }
            else
            {
                cm.Parameters.AddWithValue("@VIOLATION", false);
            }
            
            cm.Parameters.AddWithValue("@SAFETY_INSPECTOR",txt_inspector.Text);
            cm.Parameters.AddWithValue("S_ID",ID);
            cm.ExecuteNonQuery();
            MessageBox.Show("Updated!");
            conn.Close();
        }

        private void rdbtnYes_CheckedChanged(object sender, EventArgs e)
        {

        }

        
                

    }


}

