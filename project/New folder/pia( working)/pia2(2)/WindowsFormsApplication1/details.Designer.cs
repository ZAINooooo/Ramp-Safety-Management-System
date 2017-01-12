namespace piac_project
{
    partial class details
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
            this.button_save = new System.Windows.Forms.Button();
            this.button_back = new System.Windows.Forms.Button();
            this.lbl_user = new System.Windows.Forms.Label();
            this.textBox1_user = new System.Windows.Forms.TextBox();
            this.textBox2_pass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_save
            // 
            this.button_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_save.Location = new System.Drawing.Point(298, 159);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(76, 23);
            this.button_save.TabIndex = 1;
            this.button_save.Text = "SAVE";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_proceed_Click);
            // 
            // button_back
            // 
            this.button_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_back.Location = new System.Drawing.Point(217, 159);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(75, 23);
            this.button_back.TabIndex = 2;
            this.button_back.Text = "BACK";
            this.button_back.UseVisualStyleBackColor = true;
            // 
            // lbl_user
            // 
            this.lbl_user.AutoSize = true;
            this.lbl_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_user.Location = new System.Drawing.Point(108, 50);
            this.lbl_user.Name = "lbl_user";
            this.lbl_user.Size = new System.Drawing.Size(101, 18);
            this.lbl_user.TabIndex = 3;
            this.lbl_user.Text = "USERNAME";
            // 
            // textBox1_user
            // 
            this.textBox1_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1_user.Location = new System.Drawing.Point(237, 48);
            this.textBox1_user.Name = "textBox1_user";
            this.textBox1_user.Size = new System.Drawing.Size(137, 22);
            this.textBox1_user.TabIndex = 4;
            // 
            // textBox2_pass
            // 
            this.textBox2_pass.Location = new System.Drawing.Point(237, 108);
            this.textBox2_pass.Name = "textBox2_pass";
            this.textBox2_pass.Size = new System.Drawing.Size(137, 20);
            this.textBox2_pass.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(117, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Password";
            // 
            // details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(627, 297);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2_pass);
            this.Controls.Add(this.textBox1_user);
            this.Controls.Add(this.lbl_user);
            this.Controls.Add(this.button_back);
            this.Controls.Add(this.button_save);
            this.Name = "details";
            this.Text = "                     Details";
            this.Load += new System.EventHandler(this.details_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Button button_back;
        private System.Windows.Forms.Label lbl_user;
        private System.Windows.Forms.TextBox textBox1_user;
        private System.Windows.Forms.TextBox textBox2_pass;
        private System.Windows.Forms.Label label1;
    }
}