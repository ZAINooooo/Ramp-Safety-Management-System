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
using System.Configuration;
using System.Threading.Tasks;
using System.IO;
using WindowsFormsApplication1;
using piac_project;
using System.Text.RegularExpressions;



 

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                this.label1.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Form2 frm = new Form2();
            //frm.ShowDialog();


            string connString = ConfigurationManager.ConnectionStrings["Database"].ConnectionString;
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();


        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                //string str = "server=.\\SQLEXPRESS; database=Database1; UID=sa;password=anumta00";

                // //String query = "select * from PERSONAL_INFO";

                // SqlConnection con = new SqlConnection(str);
                // con.Open();

                //SqlCommand cmd = new SqlCommand(query, con);



                string connString = ConfigurationManager.ConnectionStrings["piadb"].ConnectionString;
                SqlConnection conn = new SqlConnection(connString);
                conn.Open();


                // DataSet ds = new DataSet();
                //MessageBox.Show("connect with sql server");
                //con.Close();


                // SQL COMMAND
                SqlCommand cmd = new SqlCommand("INSERT INTO [PiaDB].[dbo].[PERSONAL_INFO]([NAME],[DESG],[DPT],[SEC],[P_N],[CNIC],[IMAGES]) VALUES (@NAME,@DESG,@DPT,@SEC,@P_N,@CNIC,@IMAGES)", conn);
                
                //PARAMETERS 
                cmd.Parameters.Add("@NAME", SqlDbType.VarChar, 50).Value = txtName.Text;
                cmd.Parameters.Add("@DESG", SqlDbType.VarChar, 0).Value = cmbxdesg.Text;
                cmd.Parameters.Add("@DPT", SqlDbType.VarChar, 50).Value = txtBxdeppt.Text;

                cmd.Parameters.Add("@P_N", SqlDbType.NChar, 3).Value = txtBxpnr.Text;

                cmd.Parameters.Add("@CNIC", SqlDbType.Int, 20).Value = txtBxcnic.Text;

                cmd.Parameters.Add("@SEC", SqlDbType.VarChar, 50).Value = txtBxsec.Text;

                cmd.Parameters.Add("@IMAGE1", SqlDbType.Image, 50).Value = pbxinsrt.Image;

                cmd.ExecuteNonQuery();

                conn.Close();

                clearForm();


            }
            catch (Exception ex)
            {

                MessageBox.Show("Err" + ex.Message);
            }
        }

        private void clearForm()
        {
            throw new NotImplementedException();
        }





        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            // image filters
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                // display image in picture box
                pbxinsrt.Image = new Bitmap(open.FileName);
                // image file path

            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Bitmaps|*.bmp|jpeps|*.jpg";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pbxinsrt.ImageLocation = openFileDialog.FileName;

            }

        }

        private void button4_Click_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            SEARCH.Links.Remove(SEARCH.Links[0]);
            SEARCH.Links.Add(0, SEARCH.Text.Length, "https://www.google.com.pk/?gws_rd=ssl#q=PERSONAL+INFO");
        }

        private void libLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProcessStartInfo sInfo = new ProcessStartInfo(e.Link.LinkData.ToString());
            Process.Start(sInfo);

        }

        private void BtnPreview_Click(object sender, EventArgs e)
        {


            //viewform5 a = new viewform5();

            //a.ShowDialog();
            //this.Dispose();

            viewform5 vf = new viewform5();
                vf.SetValues(txtName.Text, txtBoxdesg.Text, txtBxdeppt.Text, txtBxpnr.Text, txtBxcnic.Text, txtBxsec.Text, pbxinsrt.ImageLocation.ToString());
            vf.ShowDialog();
            try
            {


                //validation va = new validation();
                //va.chekName(txtName.Text);

                //validation vc = new validation();
                //vc.chekpnr(txtBxpnr.Text,txtBxsec.Text,txtBxdeppt.Text);

                //validation vb = new validation();
                //vb.cheknic(txtBxcnic.Text);

                viewform5 objView = new viewform5();
                this.Hide();
                objView.SetValues(txtName.Text, cmbxdesg.SelectedValue.ToString(), txtBxdeppt.Text, txtBxpnr.Text, txtBxcnic.Text, txtBxsec.Text, pbxinsrt.Image.ToString());
                objView.ShowDialog();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }


                            //CNIC VALDATION 
            try
            {

                //Regex re = new Regex(@"^\(\d{2}\) \d{4} \d{4}$");

                //if (!re.IsMatch(txtBxcnic.Text))
                
                //    errorProvider1.SetError(txtBxcnic, "Must be (xx) xxxx xxxx");

                //    e.cancel = true;
                //    return;

                

                
                // CNIC Number is valid
                errorProvider1.SetError(txtBxcnic, "");
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }


                        //PNR validation
            //try
            //{
            //    int numberEntered;
            //    if (int.TryParse(txtBxpnr.Text, out numberEntered))
            //    {
            //        //if  (numberEntered < 1 || numberEntered > 10) 
            //        {
            //            MessageBox.Show("You have to enter a number between 1 and 10");
            //           // txtBxpnr.Text = 5.ToString();
            //        }
            //    }
            //    //else
            //    {
            //        MessageBox.Show("You need to enter an integer");
            //     //   txtBxpnr.Text = 5.ToString();//
            //    }
            //}

            //catch (Exception ex)
            //{

            //    MessageBox.Show(ex.Message.ToString());


            //}


        }

        

            //try
            //{


            //var Form1 = new Form1();
            //Form1.Closed += (s, args) => this.Close();
            //Form1.ShowDialog();

            //}
            //catch (Exception ex)
            //{

            //    MessageBox.Show(ex.Message.ToString());
            //}//



        
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        // textBox5.Validating += new CancelEventHandler(textBox5_Validating);

        private void textBox5_TextChanged(object sender, EventArgs e)
        {


        }
        
        
        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBxcnic_TextChanged(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}



    

    
