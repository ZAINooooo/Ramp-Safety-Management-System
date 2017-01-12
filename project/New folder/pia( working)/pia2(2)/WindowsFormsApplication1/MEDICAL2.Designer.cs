namespace piac_project
{
    partial class MEDICAL2
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.grdmedical = new System.Windows.Forms.DataGridView();
            this.btn_med_delete = new System.Windows.Forms.Button();
            this.btn_med_update = new System.Windows.Forms.Button();
            this.btn_med_add = new System.Windows.Forms.Button();
            this.btn_Back3 = new System.Windows.Forms.Button();
            this.panel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdmedical)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel.Controls.Add(this.panel1);
            this.panel.Controls.Add(this.label3);
            this.panel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.panel.ImeMode = System.Windows.Forms.ImeMode.Alpha;
            this.panel.Location = new System.Drawing.Point(-154, 12);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(1364, 115);
            this.panel.TabIndex = 46;
            this.panel.Tag = "";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.label1);
            this.panel1.ImeMode = System.Windows.Forms.ImeMode.Alpha;
            this.panel1.Location = new System.Drawing.Point(8, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1356, 69);
            this.panel1.TabIndex = 46;
            this.panel1.Tag = "";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(470, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(483, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "  MEDICAL CERTIFICATION";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(504, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(357, 39);
            this.label3.TabIndex = 0;
            this.label3.Text = "Personal Information";
            // 
            // grdmedical
            // 
            this.grdmedical.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdmedical.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdmedical.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.grdmedical.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdmedical.Location = new System.Drawing.Point(0, 124);
            this.grdmedical.Name = "grdmedical";
            this.grdmedical.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdmedical.Size = new System.Drawing.Size(1053, 269);
            this.grdmedical.TabIndex = 47;
            this.grdmedical.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdmedical_CellClick);
            // 
            // btn_med_delete
            // 
            this.btn_med_delete.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_med_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_med_delete.Location = new System.Drawing.Point(567, 419);
            this.btn_med_delete.Name = "btn_med_delete";
            this.btn_med_delete.Size = new System.Drawing.Size(85, 23);
            this.btn_med_delete.TabIndex = 52;
            this.btn_med_delete.Text = " DELETE";
            this.btn_med_delete.UseVisualStyleBackColor = true;
            this.btn_med_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_med_update
            // 
            this.btn_med_update.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_med_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_med_update.Location = new System.Drawing.Point(452, 419);
            this.btn_med_update.Name = "btn_med_update";
            this.btn_med_update.Size = new System.Drawing.Size(95, 23);
            this.btn_med_update.TabIndex = 51;
            this.btn_med_update.Text = "  UPDATE";
            this.btn_med_update.UseVisualStyleBackColor = true;
            this.btn_med_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_med_add
            // 
            this.btn_med_add.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_med_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_med_add.Location = new System.Drawing.Point(373, 419);
            this.btn_med_add.Name = "btn_med_add";
            this.btn_med_add.Size = new System.Drawing.Size(59, 23);
            this.btn_med_add.TabIndex = 50;
            this.btn_med_add.Text = "  ADD";
            this.btn_med_add.UseVisualStyleBackColor = true;
            this.btn_med_add.Click += new System.EventHandler(this.btn_addition_Click);
            // 
            // btn_Back3
            // 
            this.btn_Back3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Back3.Location = new System.Drawing.Point(12, 444);
            this.btn_Back3.Name = "btn_Back3";
            this.btn_Back3.Size = new System.Drawing.Size(75, 23);
            this.btn_Back3.TabIndex = 53;
            this.btn_Back3.Text = " BACK";
            this.btn_Back3.UseVisualStyleBackColor = true;
            this.btn_Back3.Click += new System.EventHandler(this.btn_Back3_Click);
            // 
            // MEDICAL2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 489);
            this.Controls.Add(this.btn_Back3);
            this.Controls.Add(this.btn_med_delete);
            this.Controls.Add(this.btn_med_update);
            this.Controls.Add(this.btn_med_add);
            this.Controls.Add(this.grdmedical);
            this.Controls.Add(this.panel);
            this.Name = "MEDICAL2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "      MEDICAL_2 PAGE";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MEDICAL2_Load);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdmedical)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView grdmedical;
        private System.Windows.Forms.Button btn_med_delete;
        private System.Windows.Forms.Button btn_med_update;
        private System.Windows.Forms.Button btn_med_add;
        private System.Windows.Forms.Button btn_Back3;


    }
}