namespace piac_project
{
    partial class frmAddPersonalInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddPersonalInfo));
            this.cmbxdesg = new System.Windows.Forms.ComboBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBxcnic = new System.Windows.Forms.TextBox();
            this.txtBxpnr = new System.Windows.Forms.TextBox();
            this.txtBxdeppt = new System.Windows.Forms.TextBox();
            this.txtBxsec = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btnClr = new System.Windows.Forms.Button();
            this.pbxinsrt = new System.Windows.Forms.PictureBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxinsrt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbxdesg
            // 
            this.cmbxdesg.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cmbxdesg.FormattingEnabled = true;
            this.cmbxdesg.Items.AddRange(new object[] {
            "ENGINEER",
            "PILOT",
            "MANGER",
            "ACCOUNTANT",
            "SURGEON"});
            this.cmbxdesg.Location = new System.Drawing.Point(178, 170);
            this.cmbxdesg.Name = "cmbxdesg";
            this.cmbxdesg.Size = new System.Drawing.Size(134, 21);
            this.cmbxdesg.TabIndex = 6;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowse.Location = new System.Drawing.Point(526, 311);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(100, 30);
            this.btnBrowse.TabIndex = 41;
            this.btnBrowse.Text = "BROWSE";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(178, 396);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(105, 30);
            this.btnSave.TabIndex = 38;
            this.btnSave.Text = "-";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(72, 336);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 37;
            this.label2.Text = "SECTION";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(72, 254);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 16);
            this.label10.TabIndex = 36;
            this.label10.Text = "PNR-NUMBER";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(72, 295);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 16);
            this.label9.TabIndex = 35;
            this.label9.Text = "CNIC-NUMBER";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(72, 213);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 16);
            this.label8.TabIndex = 34;
            this.label8.Text = "DEPARTMENT";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(72, 171);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 16);
            this.label7.TabIndex = 33;
            this.label7.Text = "DESIGNATION";
            // 
            // txtBxcnic
            // 
            this.txtBxcnic.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtBxcnic.Location = new System.Drawing.Point(178, 294);
            this.txtBxcnic.Name = "txtBxcnic";
            this.txtBxcnic.Size = new System.Drawing.Size(234, 20);
            this.txtBxcnic.TabIndex = 4;
            // 
            // txtBxpnr
            // 
            this.txtBxpnr.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtBxpnr.Location = new System.Drawing.Point(178, 253);
            this.txtBxpnr.Name = "txtBxpnr";
            this.txtBxpnr.Size = new System.Drawing.Size(234, 20);
            this.txtBxpnr.TabIndex = 3;
            // 
            // txtBxdeppt
            // 
            this.txtBxdeppt.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtBxdeppt.Location = new System.Drawing.Point(178, 212);
            this.txtBxdeppt.Name = "txtBxdeppt";
            this.txtBxdeppt.Size = new System.Drawing.Size(234, 20);
            this.txtBxdeppt.TabIndex = 2;
            // 
            // txtBxsec
            // 
            this.txtBxsec.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtBxsec.Location = new System.Drawing.Point(178, 335);
            this.txtBxsec.Name = "txtBxsec";
            this.txtBxsec.Size = new System.Drawing.Size(234, 20);
            this.txtBxsec.TabIndex = 5;
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtName.Location = new System.Drawing.Point(178, 129);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(234, 20);
            this.txtName.TabIndex = 0;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(72, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 16);
            this.label1.TabIndex = 27;
            this.label1.Text = "NAME ";
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel.Controls.Add(this.label3);
            this.panel.ImeMode = System.Windows.Forms.ImeMode.Alpha;
            this.panel.Location = new System.Drawing.Point(49, 28);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(605, 69);
            this.panel.TabIndex = 43;
            this.panel.Tag = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(87, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(431, 39);
            this.label3.TabIndex = 0;
            this.label3.Text = "Add Personal Information";
            // 
            // btnClr
            // 
            this.btnClr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClr.Location = new System.Drawing.Point(289, 398);
            this.btnClr.Name = "btnClr";
            this.btnClr.Size = new System.Drawing.Size(105, 30);
            this.btnClr.TabIndex = 44;
            this.btnClr.Text = "Clear";
            this.btnClr.UseVisualStyleBackColor = true;
            this.btnClr.Click += new System.EventHandler(this.btnClr_Click);
            // 
            // pbxinsrt
            // 
            this.pbxinsrt.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pbxinsrt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbxinsrt.Location = new System.Drawing.Point(498, 156);
            this.pbxinsrt.Name = "pbxinsrt";
            this.pbxinsrt.Size = new System.Drawing.Size(157, 149);
            this.pbxinsrt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxinsrt.TabIndex = 40;
            this.pbxinsrt.TabStop = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(13, 436);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 45;
            this.button1.Text = "BACK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmAddPersonalInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(725, 476);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnClr);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.cmbxdesg);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.pbxinsrt);
            this.Controls.Add(this.btnSave);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "frmAddPersonalInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPersonalInfo";
            this.Load += new System.EventHandler(this.frmPersonalInfo_Load);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxinsrt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbxdesg;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.PictureBox pbxinsrt;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBxcnic;
        private System.Windows.Forms.TextBox txtBxpnr;
        private System.Windows.Forms.TextBox txtBxdeppt;
        private System.Windows.Forms.TextBox txtBxsec;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnClr;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button button1;

    }
}