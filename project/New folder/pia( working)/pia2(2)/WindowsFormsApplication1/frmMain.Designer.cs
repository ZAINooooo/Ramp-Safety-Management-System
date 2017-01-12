namespace piac_project
{
    partial class frmMain
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pbxSafetyVio = new System.Windows.Forms.PictureBox();
            this.pbxRampSafety = new System.Windows.Forms.PictureBox();
            this.pbxMedical = new System.Windows.Forms.PictureBox();
            this.pbxPersonInfo = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSafetyVio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxRampSafety)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMedical)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPersonInfo)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(-5, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1131, 152);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.DimGray;
            this.tabPage1.Controls.Add(this.pbxSafetyVio);
            this.tabPage1.Controls.Add(this.pbxRampSafety);
            this.tabPage1.Controls.Add(this.pbxMedical);
            this.tabPage1.Controls.Add(this.pbxPersonInfo);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1123, 126);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Home";
            // 
            // pbxSafetyVio
            // 
            this.pbxSafetyVio.Image = global::piac_project.Properties.Resources.images1;
            this.pbxSafetyVio.Location = new System.Drawing.Point(472, 13);
            this.pbxSafetyVio.Name = "pbxSafetyVio";
            this.pbxSafetyVio.Size = new System.Drawing.Size(104, 101);
            this.pbxSafetyVio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxSafetyVio.TabIndex = 3;
            this.pbxSafetyVio.TabStop = false;
            this.pbxSafetyVio.Click += new System.EventHandler(this.pbxSafetyVio_Click);
            // 
            // pbxRampSafety
            // 
            this.pbxRampSafety.Image = global::piac_project.Properties.Resources._101_2723;
            this.pbxRampSafety.Location = new System.Drawing.Point(300, 13);
            this.pbxRampSafety.Name = "pbxRampSafety";
            this.pbxRampSafety.Size = new System.Drawing.Size(106, 101);
            this.pbxRampSafety.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxRampSafety.TabIndex = 2;
            this.pbxRampSafety.TabStop = false;
            this.pbxRampSafety.Click += new System.EventHandler(this.pbxRampSafety_Click);
            // 
            // pbxMedical
            // 
            this.pbxMedical.Image = global::piac_project.Properties.Resources._06_AJ_medical_BMI_ARA;
            this.pbxMedical.Location = new System.Drawing.Point(146, 13);
            this.pbxMedical.Name = "pbxMedical";
            this.pbxMedical.Size = new System.Drawing.Size(102, 101);
            this.pbxMedical.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxMedical.TabIndex = 1;
            this.pbxMedical.TabStop = false;
            this.pbxMedical.Click += new System.EventHandler(this.pbxMedical_Click);
            // 
            // pbxPersonInfo
            // 
            this.pbxPersonInfo.Image = global::piac_project.Properties.Resources.personal_information;
            this.pbxPersonInfo.Location = new System.Drawing.Point(15, 13);
            this.pbxPersonInfo.Name = "pbxPersonInfo";
            this.pbxPersonInfo.Size = new System.Drawing.Size(101, 101);
            this.pbxPersonInfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxPersonInfo.TabIndex = 0;
            this.pbxPersonInfo.TabStop = false;
            this.pbxPersonInfo.Click += new System.EventHandler(this.pbxPersonInfo_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Bisque;
            this.tabPage2.Controls.Add(this.pictureBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1006, 126);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "User Account";
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::piac_project.Properties.Resources.personal_information;
            this.pictureBox1.Location = new System.Drawing.Point(73, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(129, 101);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Pink;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.textBox1.Location = new System.Drawing.Point(280, 360);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(779, 117);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = " WELCOME TO RAMP SAFETY                      SYSTEM                           ";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.WordWrap = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(1125, 697);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "                                                                               ST" +
    "ART PAGE";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxSafetyVio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxRampSafety)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMedical)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPersonInfo)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.PictureBox pbxMedical;
        private System.Windows.Forms.PictureBox pbxPersonInfo;
        private System.Windows.Forms.PictureBox pbxSafetyVio;
        private System.Windows.Forms.PictureBox pbxRampSafety;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}