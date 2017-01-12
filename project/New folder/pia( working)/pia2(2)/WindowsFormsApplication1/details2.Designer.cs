namespace piac_project
{
    partial class details2
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
            this.panel = new System.Windows.Forms.Panel();
            this.label_detail = new System.Windows.Forms.Label();
            this.dataGridView_det2 = new System.Windows.Forms.DataGridView();
            this.button_addi = new System.Windows.Forms.Button();
            this.button_dlt = new System.Windows.Forms.Button();
            this.button_bck = new System.Windows.Forms.Button();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_det2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel.Controls.Add(this.label_detail);
            this.panel.ImeMode = System.Windows.Forms.ImeMode.Alpha;
            this.panel.Location = new System.Drawing.Point(-225, 2);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(1203, 90);
            this.panel.TabIndex = 46;
            this.panel.Tag = "";
            // 
            // label_detail
            // 
            this.label_detail.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_detail.AutoSize = true;
            this.label_detail.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_detail.Location = new System.Drawing.Point(472, 18);
            this.label_detail.Name = "label_detail";
            this.label_detail.Size = new System.Drawing.Size(202, 42);
            this.label_detail.TabIndex = 0;
            this.label_detail.Text = "  DETAILS";
            // 
            // dataGridView_det2
            // 
            this.dataGridView_det2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_det2.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dataGridView_det2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_det2.Location = new System.Drawing.Point(-2, 88);
            this.dataGridView_det2.Name = "dataGridView_det2";
            this.dataGridView_det2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_det2.Size = new System.Drawing.Size(799, 217);
            this.dataGridView_det2.TabIndex = 47;
            this.dataGridView_det2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_det2_CellClick);
            this.dataGridView_det2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_det2_CellContentClick);
            // 
            // button_addi
            // 
            this.button_addi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_addi.Location = new System.Drawing.Point(326, 325);
            this.button_addi.Name = "button_addi";
            this.button_addi.Size = new System.Drawing.Size(75, 23);
            this.button_addi.TabIndex = 48;
            this.button_addi.Text = "ADD";
            this.button_addi.UseVisualStyleBackColor = true;
            this.button_addi.Click += new System.EventHandler(this.button_addi_Click);
            // 
            // button_dlt
            // 
            this.button_dlt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_dlt.Location = new System.Drawing.Point(420, 325);
            this.button_dlt.Name = "button_dlt";
            this.button_dlt.Size = new System.Drawing.Size(75, 23);
            this.button_dlt.TabIndex = 50;
            this.button_dlt.Text = "DELETE";
            this.button_dlt.UseVisualStyleBackColor = true;
            this.button_dlt.Click += new System.EventHandler(this.button_dlt_Click);
            // 
            // button_bck
            // 
            this.button_bck.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_bck.Location = new System.Drawing.Point(-2, 330);
            this.button_bck.Name = "button_bck";
            this.button_bck.Size = new System.Drawing.Size(75, 23);
            this.button_bck.TabIndex = 51;
            this.button_bck.Text = "BACK";
            this.button_bck.UseVisualStyleBackColor = true;
            this.button_bck.Click += new System.EventHandler(this.button_bck_Click);
            // 
            // details2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 365);
            this.Controls.Add(this.button_bck);
            this.Controls.Add(this.button_dlt);
            this.Controls.Add(this.button_addi);
            this.Controls.Add(this.dataGridView_det2);
            this.Controls.Add(this.panel);
            this.Name = "details2";
            this.Text = "                                                        details";
            this.Load += new System.EventHandler(this.details2_Load);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_det2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Label label_detail;
        private System.Windows.Forms.DataGridView dataGridView_det2;
        private System.Windows.Forms.Button button_addi;
        private System.Windows.Forms.Button button_dlt;
        private System.Windows.Forms.Button button_bck;
    }
}