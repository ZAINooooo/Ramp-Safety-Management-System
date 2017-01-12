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

namespace WindowsFormsApplication1
{
    public partial class Form3 : Form
    {

        int ID;
        SqlConnection conn = new SqlConnection(DAL.SQLConnection());


        public Form3(int id)
        {
            InitializeComponent();
            ID = id;
            txt_pnr.PasswordChar = '*';
            txt_pnr.MaxLength = 5;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            piac_project.RampSafety2 frm = new piac_project.RampSafety2();
            frm.Show();
        }

        public void InsertInfo()
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO [DATABASE1].[dbo].[RAMP_SAFETY_TRAINING]  ([DATE] ,[EXPIRY_DATE] ,[PTC_INSTRUCTION] ,[SAFETY_CHECKED] ,[CERTIFICATE_NUM]  ,[P_N]  ,[RAMP_NUM])  VALUES(@DATE  ,@EXPIRY_DATE ,@PTC_INSTRUCTIONS ,@SAFETY_CHECKED  ,@CERTIFICATE_NUM ,@P_N ,@RAMP_NUM)", conn);
                cmd.Parameters.Add("@DATE", dtpDate.Value);
                cmd.Parameters.Add("@EXPIRY_DATE", dtpExpDate.Value);
                cmd.Parameters.Add("@PTC_INSTRUCTIONS", txt_ptc.Text);
                cmd.Parameters.Add("@SAFETY_CHECKED", txt_safety.Text);
                cmd.Parameters.Add("@CERTIFICATE_NUM", Convert.ToInt32 (txt_certif.Text));
                cmd.Parameters.Add("@P_N", Convert.ToInt32(txt_pnr.Text));
                cmd.Parameters.Add("@RAMP_NUM", Convert.ToInt32 (txt_ramp.Text));
                
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Err" + ex.Message);
            }
        }

        public void DataBinding(int _id)
        {
            try
            {
            conn.Open();
            SqlCommand cm = new SqlCommand("Select * from RAMP_SAFETY_TRAINING where id = @R_ID", conn);
            cm.Parameters.AddWithValue("@R_ID", ID);
            SqlDataReader dr = cm.ExecuteReader();
            while (dr.Read())
            {
                //txt_id.Text = dr["RAMP_ID"].ToString();
                dtpDate.Value = Convert.ToDateTime(dr["DATE"]);
                dtpExpDate.Value = Convert.ToDateTime(dr["EXPIRY_DATE"]);
                txt_ptc.Text = dr["PTC INSTRUCTIONS"].ToString();
                txt_safety.Text = dr["SAFETY CHECKED"].ToString();
                txt_pnr.Text = dr["P_NUM"].ToString();
                txt_ramp.Text = dr["RAMP_NUM"].ToString();
                //txt_vaccination.Text = dr["VACCINATION"].ToString();
                txt_certif.Text = dr["WEIGHT"].ToString();
                

            }
           
            }
               
        
        catch (Exception ex)
            {
                MessageBox.Show("Err" + ex.Message);
            }
            conn.Close();
        }
    
    



        private void Form3_Load(object sender, EventArgs e)
        {
            if (ID > 0)
            {
                DataBinding(ID);
            }
        }
    
        private void SEARCH_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }

        private void btnProceed_Click(object sender, EventArgs e)
        {
            InsertInfo();
            MessageBox.Show("RAMP SAFETY INSTRUCTIONS  Added!");
           
        }
    }
}
