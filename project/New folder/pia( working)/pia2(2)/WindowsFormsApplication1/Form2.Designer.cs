namespace WindowsFormsApplication1
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.label1 = new System.Windows.Forms.Label();
            this.txt_fit = new System.Windows.Forms.TextBox();
            this.txt_height = new System.Windows.Forms.TextBox();
            this.txt_weight = new System.Windows.Forms.TextBox();
            this.txt_vaccination = new System.Windows.Forms.TextBox();
            this.txt_blood = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btnProceed = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SEARCH = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_pn = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_cert = new System.Windows.Forms.TextBox();
            this.dtpExaminationDate = new System.Windows.Forms.DateTimePicker();
            this.rdbtnYes = new System.Windows.Forms.RadioButton();
            this.rdbtnNo = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "EXAMINATON DATE";
            // 
            // txt_fit
            // 
            this.txt_fit.Location = new System.Drawing.Point(313, 286);
            this.txt_fit.Name = "txt_fit";
            this.txt_fit.Size = new System.Drawing.Size(193, 20);
            this.txt_fit.TabIndex = 8;
            // 
            // txt_height
            // 
            this.txt_height.Location = new System.Drawing.Point(313, 81);
            this.txt_height.Name = "txt_height";
            this.txt_height.Size = new System.Drawing.Size(193, 20);
            this.txt_height.TabIndex = 9;
            // 
            // txt_weight
            // 
            this.txt_weight.Location = new System.Drawing.Point(313, 117);
            this.txt_weight.Name = "txt_weight";
            this.txt_weight.Size = new System.Drawing.Size(193, 20);
            this.txt_weight.TabIndex = 11;
            // 
            // txt_vaccination
            // 
            this.txt_vaccination.Location = new System.Drawing.Point(313, 200);
            this.txt_vaccination.Name = "txt_vaccination";
            this.txt_vaccination.Size = new System.Drawing.Size(193, 20);
            this.txt_vaccination.TabIndex = 12;
            // 
            // txt_blood
            // 
            this.txt_blood.Location = new System.Drawing.Point(313, 155);
            this.txt_blood.Name = "txt_blood";
            this.txt_blood.Size = new System.Drawing.Size(193, 20);
            this.txt_blood.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(110, 81);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 24);
            this.label8.TabIndex = 14;
            this.label8.Text = "HEIGHT";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(110, 117);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 24);
            this.label9.TabIndex = 15;
            this.label9.Text = "WEIGHT";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(83, 155);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(158, 24);
            this.label10.TabIndex = 16;
            this.label10.Text = "BLOOD GROUP";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(101, 200);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(149, 24);
            this.label11.TabIndex = 17;
            this.label11.Text = "VACCINATION";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(91, 242);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(159, 24);
            this.label12.TabIndex = 18;
            this.label12.Text = "COLOUR BLIND";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(72, 286);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(178, 24);
            this.label13.TabIndex = 19;
            this.label13.Text = "FIT FOR DRIVING";
            // 
            // btnProceed
            // 
            this.btnProceed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProceed.Location = new System.Drawing.Point(350, 366);
            this.btnProceed.Name = "btnProceed";
            this.btnProceed.Size = new System.Drawing.Size(104, 32);
            this.btnProceed.TabIndex = 20;
            this.btnProceed.Text = "PROCEED";
            this.btnProceed.UseVisualStyleBackColor = true;
            this.btnProceed.Click += new System.EventHandler(this.btnProceed_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(1, 377);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 32);
            this.button2.TabIndex = 21;
            this.button2.Text = "BACK";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // SEARCH
            // 
            this.SEARCH.AutoSize = true;
            this.SEARCH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SEARCH.LinkColor = System.Drawing.Color.Black;
            this.SEARCH.Location = new System.Drawing.Point(636, 16);
            this.SEARCH.Name = "SEARCH";
            this.SEARCH.Size = new System.Drawing.Size(83, 20);
            this.SEARCH.TabIndex = 22;
            this.SEARCH.TabStop = true;
            this.SEARCH.Text = "SEARCH";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(109, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 25);
            this.label2.TabIndex = 23;
            this.label2.Text = "P_NUM";
            // 
            // txt_pn
            // 
            this.txt_pn.Location = new System.Drawing.Point(313, 13);
            this.txt_pn.Name = "txt_pn";
            this.txt_pn.Size = new System.Drawing.Size(193, 20);
            this.txt_pn.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(48, 325);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(223, 25);
            this.label3.TabIndex = 25;
            this.label3.Text = "CERTIFICATE_NUM";
            // 
            // txt_cert
            // 
            this.txt_cert.Location = new System.Drawing.Point(313, 330);
            this.txt_cert.Name = "txt_cert";
            this.txt_cert.Size = new System.Drawing.Size(193, 20);
            this.txt_cert.TabIndex = 26;
            // 
            // dtpExaminationDate
            // 
            this.dtpExaminationDate.Location = new System.Drawing.Point(313, 48);
            this.dtpExaminationDate.Name = "dtpExaminationDate";
            this.dtpExaminationDate.Size = new System.Drawing.Size(193, 20);
            this.dtpExaminationDate.TabIndex = 27;
            // 
            // rdbtnYes
            // 
            this.rdbtnYes.AutoSize = true;
            this.rdbtnYes.Location = new System.Drawing.Point(313, 248);
            this.rdbtnYes.Name = "rdbtnYes";
            this.rdbtnYes.Size = new System.Drawing.Size(43, 17);
            this.rdbtnYes.TabIndex = 28;
            this.rdbtnYes.TabStop = true;
            this.rdbtnYes.Text = "Yes";
            this.rdbtnYes.UseVisualStyleBackColor = true;
            // 
            // rdbtnNo
            // 
            this.rdbtnNo.AutoSize = true;
            this.rdbtnNo.Location = new System.Drawing.Point(383, 249);
            this.rdbtnNo.Name = "rdbtnNo";
            this.rdbtnNo.Size = new System.Drawing.Size(39, 17);
            this.rdbtnNo.TabIndex = 29;
            this.rdbtnNo.TabStop = true;
            this.rdbtnNo.Text = "No";
            this.rdbtnNo.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(758, 410);
            this.Controls.Add(this.rdbtnNo);
            this.Controls.Add(this.rdbtnYes);
            this.Controls.Add(this.dtpExaminationDate);
            this.Controls.Add(this.txt_cert);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_pn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SEARCH);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnProceed);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_blood);
            this.Controls.Add(this.txt_vaccination);
            this.Controls.Add(this.txt_weight);
            this.Controls.Add(this.txt_height);
            this.Controls.Add(this.txt_fit);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MEDICAL CERTIFICATE";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_fit;
        private System.Windows.Forms.TextBox txt_height;
        private System.Windows.Forms.TextBox txt_weight;
        private System.Windows.Forms.TextBox txt_vaccination;
        private System.Windows.Forms.TextBox txt_blood;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnProceed;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.LinkLabel SEARCH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_pn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_cert;
        private System.Windows.Forms.DateTimePicker dtpExaminationDate;
        private System.Windows.Forms.RadioButton rdbtnYes;
        private System.Windows.Forms.RadioButton rdbtnNo;
    }
}