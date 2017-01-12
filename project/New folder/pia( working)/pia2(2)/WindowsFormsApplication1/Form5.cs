using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.IO;
using System.Data.SqlClient;
using System.Configuration;


namespace piac_project
{
    public partial class viewform5 : Form
    {
        string _name, _designation, _department, _pnrnumber, _nic, _section, _picturebox1;

        private String connectionString = null;
        private SqlConnection sqlConnection = null;
        private SqlDataAdapter sqlDataAdapter = null;
        private SqlCommandBuilder sqlCommandBuilder = null;
        private DataTable dataTable = null;
        private BindingSource bindingSource = null;
        private String selectQueryString = null;
        private string p1;
        private string p2;
        private string p3;
        private string p4;
        private string p5;
        private string p6;
        private string p7;

        //public viewform5(string name, string designation, string department, string pnrnumber, string nic, string section, string picturebox1)
        //{
        //    InitializeComponent();

        //    _name = name;
        //    _designation = designation;
        //    _department = department;
        //    _pnrnumber = pnrnumber;
        //    _nic = nic;
        //    _section = section;
        //    _picturebox1 = picturebox1;

        //}

        public viewform5()
        {
            // TODO: Complete member initialization
        }

        public viewform5(string p1, string p2, string p3, string p4, string p5, string p6, string p7)
        {
            // TODO: Complete member initialization
            this.p1 = p1;
            this.p2 = p2;
            this.p3 = p3;
            this.p4 = p4;
            this.p5 = p5;
            this.p6 = p6;
            this.p7 = p7;
        }



        public void SetValues(string name, string designation, string department, string pnrnumber, string nic, string section, string picturebox1)
        {
            label3.Text = name;
            label4.Text = designation;
            label5.Text = department;
            label6.Text = pnrnumber;
            label7.Text = nic;
            label8.Text = section;
            pbxVew.Image = new Bitmap(picturebox1);
            //label13.Text=Convert.ToString(pic);
        }


        private void view_Load(object sender, EventArgs e)
        {

            SetValues(_name, _designation, _department, _pnrnumber, _nic, _section, _picturebox1);
            // connectionString = ConfigurationManager.AppSettings["connectionString"];
            //  connectionString="Data Source=.\\SQLEXPRESS; initial Catalog=Database1; integrated security=true"; pehle S coment thi
           
            
//            connectionString = @"Data Source=.\SQLEXPRESS;
//                          AttachDbFilename=C:\Users\student\Desktop\pia2(2)\WindowsFormsApplication1\Database1.mdf;
//                          Integrated Security=True;
//                          Connect Timeout=30;
//                          User Instance=True";


//            sqlConnection = new SqlConnection(connectionString);
//            selectQueryString = "SELECT * FROM PERSONAL_INFO";

//            sqlConnection.Open();

//            sqlDataAdapter = new SqlDataAdapter(selectQueryString, sqlConnection);
//            sqlCommandBuilder = new SqlCommandBuilder(sqlDataAdapter);

//            dataTable = new DataTable();
//            sqlDataAdapter.Fill(dataTable);
//            bindingSource = new BindingSource();
//            bindingSource.DataSource = dataTable;

//            dataGridView1.DataSource = bindingSource;

//            // to hide Identity column pehle S coment thi
        
            
//            dataGridView1.Columns[0].Visible = false;
        }



        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void update_Click(object sender, EventArgs e)
        {
            try
            {
                sqlDataAdapter.Update(dataTable);
            }
            catch (Exception exceptionObj)
            {
                MessageBox.Show(exceptionObj.Message.ToString());
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            DialogResult result3 = MessageBox.Show("DO YOU WANT TO EXIT COMPLETELY?",
               "THE MESSAGE",
               MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Question,
               MessageBoxDefaultButton.Button3);

            if (result3 == System.Windows.Forms.DialogResult.Yes)
            {

                // cancel the closure of the form.

                this.Close();
            }


            else if (result3 == System.Windows.Forms.DialogResult.Cancel)
            {


                //var Form5 = new viewform5();
                //Form5.Closed += (s, args) => this.Close();
                //Form5.ShowDialog();
            }
        }


        private void delete_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
                sqlDataAdapter.Update(dataTable);
            }
            catch (Exception exceptionObj)
            {
                MessageBox.Show(exceptionObj.Message.ToString());
            }
        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            WindowsFormsApplication1.Form1 frm = new WindowsFormsApplication1.Form1();
            frm.ShowDialog();

        }
        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {
            
        }

        private void openFileDialog2_FileOk(object sender, CancelEventArgs e)
        {

        }
        }

    }
