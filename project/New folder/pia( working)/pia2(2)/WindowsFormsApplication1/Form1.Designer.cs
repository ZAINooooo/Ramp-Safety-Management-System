namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtBxdeppt = new System.Windows.Forms.TextBox();
            this.txtBxpnr = new System.Windows.Forms.TextBox();
            this.txtBxcnic = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtBxsec = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.pbxinsrt = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.SEARCH = new System.Windows.Forms.LinkLabel();
            this.BtnPreview = new System.Windows.Forms.Button();
            this.cmbxdesg = new System.Windows.Forms.ComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtBoxdesg = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxinsrt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(115, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "NAME ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(273, 41);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(201, 20);
            this.txtName.TabIndex = 6;
            this.txtName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtBxdeppt
            // 
            this.txtBxdeppt.Location = new System.Drawing.Point(273, 127);
            this.txtBxdeppt.Name = "txtBxdeppt";
            this.txtBxdeppt.Size = new System.Drawing.Size(201, 20);
            this.txtBxdeppt.TabIndex = 9;
            this.txtBxdeppt.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // txtBxpnr
            // 
            this.txtBxpnr.Location = new System.Drawing.Point(273, 169);
            this.txtBxpnr.Name = "txtBxpnr";
            this.txtBxpnr.Size = new System.Drawing.Size(201, 20);
            this.txtBxpnr.TabIndex = 10;
            this.txtBxpnr.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // txtBxcnic
            // 
            this.txtBxcnic.Location = new System.Drawing.Point(273, 213);
            this.txtBxcnic.Name = "txtBxcnic";
            this.txtBxcnic.Size = new System.Drawing.Size(201, 20);
            this.txtBxcnic.TabIndex = 11;
            this.txtBxcnic.TextChanged += new System.EventHandler(this.txtBxcnic_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(102, 83);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(149, 24);
            this.label7.TabIndex = 12;
            this.label7.Text = "DESIGNATION";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(100, 127);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(151, 24);
            this.label8.TabIndex = 13;
            this.label8.Text = "DEPARTMENT";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(102, 208);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(152, 24);
            this.label9.TabIndex = 14;
            this.label9.Text = "CNIC-NUMBER";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(102, 165);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(146, 24);
            this.label10.TabIndex = 15;
            this.label10.Text = "PNR-NUMBER";
            // 
            // txtBxsec
            // 
            this.txtBxsec.Location = new System.Drawing.Point(273, 248);
            this.txtBxsec.Name = "txtBxsec";
            this.txtBxsec.Size = new System.Drawing.Size(201, 20);
            this.txtBxsec.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(116, 248);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 24);
            this.label2.TabIndex = 16;
            this.label2.Text = "SECTION";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(533, 427);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 30);
            this.button1.TabIndex = 17;
            this.button1.Text = "PROCEED";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(3, 486);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 30);
            this.button2.TabIndex = 18;
            this.button2.Text = "EXIT";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(115, 329);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 25);
            this.label3.TabIndex = 20;
            this.label3.Text = "PICTURE";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.HelpRequest += new System.EventHandler(this.folderBrowserDialog1_HelpRequest);
            // 
            // pbxinsrt
            // 
            this.pbxinsrt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbxinsrt.Location = new System.Drawing.Point(263, 276);
            this.pbxinsrt.Name = "pbxinsrt";
            this.pbxinsrt.Size = new System.Drawing.Size(221, 181);
            this.pbxinsrt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxinsrt.TabIndex = 21;
            this.pbxinsrt.TabStop = false;
            this.pbxinsrt.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(332, 463);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 30);
            this.button3.TabIndex = 22;
            this.button3.Text = "BROWSE";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // SEARCH
            // 
            this.SEARCH.AutoSize = true;
            this.SEARCH.BackColor = System.Drawing.SystemColors.Menu;
            this.SEARCH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SEARCH.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.SEARCH.LinkColor = System.Drawing.Color.Black;
            this.SEARCH.Location = new System.Drawing.Point(546, 9);
            this.SEARCH.Name = "SEARCH";
            this.SEARCH.Size = new System.Drawing.Size(83, 20);
            this.SEARCH.TabIndex = 23;
            this.SEARCH.TabStop = true;
            this.SEARCH.Text = "SEARCH";
            this.SEARCH.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.libLink_LinkClicked);
            // 
            // BtnPreview
            // 
            this.BtnPreview.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPreview.Location = new System.Drawing.Point(523, 358);
            this.BtnPreview.Name = "BtnPreview";
            this.BtnPreview.Size = new System.Drawing.Size(115, 30);
            this.BtnPreview.TabIndex = 24;
            this.BtnPreview.Text = "PREVIEW";
            this.BtnPreview.UseVisualStyleBackColor = true;
            this.BtnPreview.Click += new System.EventHandler(this.BtnPreview_Click);
            // 
            // cmbxdesg
            // 
            this.cmbxdesg.FormattingEnabled = true;
            this.cmbxdesg.Items.AddRange(new object[] {
            "ENGINEER",
            "PILOT",
            "MANGER",
            "ACCOUNTANT",
            "SURGEON"});
            this.cmbxdesg.Location = new System.Drawing.Point(523, 83);
            this.cmbxdesg.Name = "cmbxdesg";
            this.cmbxdesg.Size = new System.Drawing.Size(147, 21);
            this.cmbxdesg.TabIndex = 25;
            this.cmbxdesg.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // txtBoxdesg
            // 
            this.txtBoxdesg.Location = new System.Drawing.Point(273, 87);
            this.txtBoxdesg.Name = "txtBoxdesg";
            this.txtBoxdesg.Size = new System.Drawing.Size(201, 20);
            this.txtBoxdesg.TabIndex = 26;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(695, 519);
            this.Controls.Add(this.txtBoxdesg);
            this.Controls.Add(this.cmbxdesg);
            this.Controls.Add(this.BtnPreview);
            this.Controls.Add(this.SEARCH);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.pbxinsrt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtBxcnic);
            this.Controls.Add(this.txtBxpnr);
            this.Controls.Add(this.txtBxdeppt);
            this.Controls.Add(this.txtBxsec);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PERSONAL INFO";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.Gray;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxinsrt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtBxdeppt;
        private System.Windows.Forms.TextBox txtBxpnr;
        private System.Windows.Forms.TextBox txtBxcnic;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtBxsec;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.PictureBox pbxinsrt;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.LinkLabel SEARCH;
        private System.Windows.Forms.Button BtnPreview;
        private System.Windows.Forms.ComboBox cmbxdesg;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox txtBoxdesg;
    }
}

