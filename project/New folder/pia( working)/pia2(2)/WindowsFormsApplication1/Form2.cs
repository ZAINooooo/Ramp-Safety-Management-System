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
using System.Diagnostics;
using System.Windows.Forms.ComponentModel;
using piac_project.DAL;
using piac_project;

namespace WindowsFormsApplication1
{

    public partial class Form2 : Form
    {
        int ID;
        SqlConnection conn = new SqlConnection(DAL.SQLConnection());


        public Form2(int id)
        {
            InitializeComponent();
            ID = id;
            txt_pn.PasswordChar = '*';
            txt_pn.MaxLength = 5;
        }

        


        public void InsertInfo()
        {
            try
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("INSERT INTO [DATABASE1].[dbo].[MEDICAL_CERTIFICATION]([EXAMINATION_DATE]  ,[HEIGHT]  ,[WEIGHT] ,[VACCINATION]  ,[COLOUR_BLIND] ,[FIT_FOR_DRIVING] ,[BLOOD_GROUP]   ,[P_N],[CERTIFICATE_NUM])  VALUES ( @EXAMINATION_DATE  ,@HEIGHT  ,@WEIGHT ,@VACCINATION  ,@COLOUR_BLIND ,@FIT_FOR_DRIVING ,@BLOOD_GROUP   ,@P_N,@CERTIFICATE_NUM)", conn);
                cmd.Parameters.Add("@EXAMINATION_DATE", dtpExaminationDate.Value);
                cmd.Parameters.Add("@HEIGHT", txt_height.Text);
                cmd.Parameters.Add("@WEIGHT", txt_weight.Text);
                cmd.Parameters.Add("@VACCINATION", txt_vaccination.Text);

                if (rdbtnYes.Checked)
                {
                    cmd.Parameters.Add("@COLOUR_BLIND", true);
                }
                else
                {
                    cmd.Parameters.Add("@COLOUR_BLIND", false);
                }
                cmd.Parameters.Add("@FIT_FOR_DRIVING", txt_fit.Text);
                cmd.Parameters.Add("@BLOOD_GROUP", txt_blood.Text);
                cmd.Parameters.Add("@P_N", Convert.ToInt32(txt_pn.Text));
                cmd.Parameters.Add("@CERTIFICATE_NUM", Convert.ToInt32(txt_cert.Text));
                cmd.ExecuteNonQuery();
            }


            catch (Exception ex)
            {
                MessageBox.Show("Err" + ex.Message);

            }
        }

        public void Update()
        {
            SqlCommand cmd = new SqlCommand("UPDATE [DATABASE1].[dbo].[MEDICAL_CERTIFICATION]SET [EXAMINATION_DATE] = @EXAMINATION_DATE,[HEIGHT] = @HEIGHT,[WEIGHT] = @WEIGHT,[VACCINATION] = @VACCINATION,[COLOUR_BLIND] = @COLOUR_BLIND,[FIT_FOR_DRIVING] = @FIT_FOR_DRIVING,[BLOOD_GROUP] = @BLOOD_GROUP,[P_N] = @P_N,[CERTIFICATE_NUM] = @CERTIFICATE_NUM WHERE id = @ID", conn);
            cmd.Parameters.AddWithValue("@ID", ID);
            cmd.Parameters.Add("@EXAMINATION_DATE", dtpExaminationDate.Value);
            cmd.Parameters.Add("@HEIGHT", txt_height.Text);
            cmd.Parameters.Add("@WEIGHT", txt_weight.Text);
            cmd.Parameters.Add("@VACCINATION", txt_vaccination.Text);
            if (rdbtnYes.Checked)
            {
                cmd.Parameters.Add("@COLOUR_BLIND", true);
            }
            else
            {
                cmd.Parameters.Add("@COLOUR_BLIND", false);
            }
            
            cmd.Parameters.Add("@FIT_FOR_DRIVING", txt_fit.Text);
            cmd.Parameters.Add("@BLOOD_GROUP", txt_blood.Text);
            cmd.Parameters.Add("@P_N", Convert.ToInt32(txt_pn.Text));
            cmd.Parameters.Add("@CERTIFICATE_NUM", Convert.ToInt32(txt_cert.Text));
            cmd.ExecuteNonQuery();
        }

        public void DataBinding(int _id)
        {
            try
            {
                conn.Open();
                SqlCommand cm = new SqlCommand("select * from MEDICAL_CERTIFICATION where id = @M_ID", conn);
                cm.Parameters.AddWithValue("@M_ID", ID);
                SqlDataReader dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    txt_pn.Text = dr["P_N"].ToString();
                    txt_blood.Text = dr["BLOOD_GROUP"].ToString();
                    txt_cert.Text = dr["CERTIFICATE_NUM"].ToString();
                    txt_fit.Text = dr["FIT_FOR_DRIVING"].ToString();
                    txt_height.Text = dr["HEIGHT"].ToString();
                    txt_vaccination.Text = dr["VACCINATION"].ToString();
                    txt_weight.Text = dr["WEIGHT"].ToString();
                    dtpExaminationDate.Value =  Convert.ToDateTime(dr["EXAMINATION_DATE"]);
                    if (Convert.ToBoolean(dr["COLOUR_BLIND"]) == true)
                    {
                        rdbtnYes.Checked = true;
                    }
                    else
                    {
                        rdbtnNo.Checked = true;
                    }
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Err" + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MEDICAL2 zl = new MEDICAL2();
            zl.ShowDialog();

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            if (ID > 0)
            {
                DataBinding(ID);
            }
        }

        private void btnProceed_Click(object sender, EventArgs e)
        {
            if (ID == 0)
            {
                InsertInfo();
                MessageBox.Show("Medical Info Added!");
               
                
            }
            else
            {
                Update();
                MessageBox.Show("Update");
               
                
            }
            this.Close();
            
        }


   
    }
}
        

    
       
    

        
    


    

