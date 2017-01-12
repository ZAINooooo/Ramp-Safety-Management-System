namespace piac_project
{
    partial class safetyViolation2
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
            this.label3 = new System.Windows.Forms.Label();
            this.grdViolation = new System.Windows.Forms.DataGridView();
            this.btnDelete_violation = new System.Windows.Forms.Button();
            this.btnEdit_violation = new System.Windows.Forms.Button();
            this.btnAdd_violation = new System.Windows.Forms.Button();
            this.btn_START2 = new System.Windows.Forms.Button();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdViolation)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel.Controls.Add(this.label3);
            this.panel.ImeMode = System.Windows.Forms.ImeMode.Alpha;
            this.panel.Location = new System.Drawing.Point(-1, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(1155, 109);
            this.panel.TabIndex = 45;
            this.panel.Tag = "";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(309, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(420, 42);
            this.label3.TabIndex = 0;
            this.label3.Text = "   SAFETY VIOLATION";
            // 
            // grdViolation
            // 
            this.grdViolation.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdViolation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdViolation.Location = new System.Drawing.Point(-1, 106);
            this.grdViolation.Name = "grdViolation";
            this.grdViolation.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdViolation.Size = new System.Drawing.Size(1155, 336);
            this.grdViolation.TabIndex = 46;
            this.grdViolation.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdViolation_CellClick);
            // 
            // btnDelete_violation
            // 
            this.btnDelete_violation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDelete_violation.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete_violation.Location = new System.Drawing.Point(581, 461);
            this.btnDelete_violation.Name = "btnDelete_violation";
            this.btnDelete_violation.Size = new System.Drawing.Size(83, 23);
            this.btnDelete_violation.TabIndex = 51;
            this.btnDelete_violation.Text = "Delete";
            this.btnDelete_violation.UseVisualStyleBackColor = true;
            this.btnDelete_violation.Click += new System.EventHandler(this.btnDelete_violation_Click);
            // 
            // btnEdit_violation
            // 
            this.btnEdit_violation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEdit_violation.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit_violation.Location = new System.Drawing.Point(500, 461);
            this.btnEdit_violation.Name = "btnEdit_violation";
            this.btnEdit_violation.Size = new System.Drawing.Size(75, 23);
            this.btnEdit_violation.TabIndex = 50;
            this.btnEdit_violation.Text = "   EDIT";
            this.btnEdit_violation.UseVisualStyleBackColor = true;
            this.btnEdit_violation.Click += new System.EventHandler(this.btnEdit_violation_Click);
            // 
            // btnAdd_violation
            // 
            this.btnAdd_violation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAdd_violation.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd_violation.Location = new System.Drawing.Point(419, 461);
            this.btnAdd_violation.Name = "btnAdd_violation";
            this.btnAdd_violation.Size = new System.Drawing.Size(75, 23);
            this.btnAdd_violation.TabIndex = 49;
            this.btnAdd_violation.Text = "  ADD";
            this.btnAdd_violation.UseVisualStyleBackColor = true;
            this.btnAdd_violation.Click += new System.EventHandler(this.btnAdd_violation_Click);
            // 
            // btn_START2
            // 
            this.btn_START2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_START2.Location = new System.Drawing.Point(12, 476);
            this.btn_START2.Name = "btn_START2";
            this.btn_START2.Size = new System.Drawing.Size(75, 23);
            this.btn_START2.TabIndex = 52;
            this.btn_START2.Text = " BACK";
            this.btn_START2.UseVisualStyleBackColor = true;
            this.btn_START2.Click += new System.EventHandler(this.btn_START2_Click);
            // 
            // safetyViolation2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1153, 511);
            this.Controls.Add(this.btn_START2);
            this.Controls.Add(this.btnDelete_violation);
            this.Controls.Add(this.btnEdit_violation);
            this.Controls.Add(this.btnAdd_violation);
            this.Controls.Add(this.grdViolation);
            this.Controls.Add(this.panel);
            this.Name = "safetyViolation2";
            this.Load += new System.EventHandler(this.safetyViolation2_Load);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdViolation)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView grdViolation;
        private System.Windows.Forms.Button btnDelete_violation;
        private System.Windows.Forms.Button btnEdit_violation;
        private System.Windows.Forms.Button btnAdd_violation;
        private System.Windows.Forms.Button btn_START2;
    }
}