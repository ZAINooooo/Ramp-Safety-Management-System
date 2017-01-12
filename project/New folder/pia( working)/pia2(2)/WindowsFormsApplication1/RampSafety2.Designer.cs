namespace piac_project
{
    partial class RampSafety2
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
            this.grdRampSafety = new System.Windows.Forms.DataGridView();
            this.btn_delete_safety = new System.Windows.Forms.Button();
            this.btn_update_safety = new System.Windows.Forms.Button();
            this.btn_addition_safety = new System.Windows.Forms.Button();
            this.btn_BACK4 = new System.Windows.Forms.Button();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdRampSafety)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel.Controls.Add(this.label3);
            this.panel.ImeMode = System.Windows.Forms.ImeMode.Alpha;
            this.panel.Location = new System.Drawing.Point(-6, 3);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(1079, 97);
            this.panel.TabIndex = 45;
            this.panel.Tag = "";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(371, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(311, 39);
            this.label3.TabIndex = 1;
            this.label3.Text = "   RAMP SAFETY ";
            // 
            // grdRampSafety
            // 
            this.grdRampSafety.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdRampSafety.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdRampSafety.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdRampSafety.Location = new System.Drawing.Point(-3, 106);
            this.grdRampSafety.Name = "grdRampSafety";
            this.grdRampSafety.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdRampSafety.Size = new System.Drawing.Size(1076, 221);
            this.grdRampSafety.TabIndex = 46;
            this.grdRampSafety.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdRampSafety_CellClick);
            // 
            // btn_delete_safety
            // 
            this.btn_delete_safety.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_delete_safety.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete_safety.Location = new System.Drawing.Point(591, 347);
            this.btn_delete_safety.Name = "btn_delete_safety";
            this.btn_delete_safety.Size = new System.Drawing.Size(85, 23);
            this.btn_delete_safety.TabIndex = 52;
            this.btn_delete_safety.Text = " DELETE";
            this.btn_delete_safety.UseVisualStyleBackColor = true;
            this.btn_delete_safety.Click += new System.EventHandler(this.btn_delete_safety_Click);
            // 
            // btn_update_safety
            // 
            this.btn_update_safety.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_update_safety.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update_safety.Location = new System.Drawing.Point(476, 347);
            this.btn_update_safety.Name = "btn_update_safety";
            this.btn_update_safety.Size = new System.Drawing.Size(95, 23);
            this.btn_update_safety.TabIndex = 51;
            this.btn_update_safety.Text = "  UPDATE";
            this.btn_update_safety.UseVisualStyleBackColor = true;
            this.btn_update_safety.Click += new System.EventHandler(this.btn_update_safety_Click);
            // 
            // btn_addition_safety
            // 
            this.btn_addition_safety.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_addition_safety.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addition_safety.Location = new System.Drawing.Point(397, 347);
            this.btn_addition_safety.Name = "btn_addition_safety";
            this.btn_addition_safety.Size = new System.Drawing.Size(59, 23);
            this.btn_addition_safety.TabIndex = 50;
            this.btn_addition_safety.Text = "  ADD";
            this.btn_addition_safety.UseVisualStyleBackColor = true;
            this.btn_addition_safety.Click += new System.EventHandler(this.btn_addition_safety_Click);
            // 
            // btn_BACK4
            // 
            this.btn_BACK4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_BACK4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_BACK4.Location = new System.Drawing.Point(12, 396);
            this.btn_BACK4.Name = "btn_BACK4";
            this.btn_BACK4.Size = new System.Drawing.Size(81, 27);
            this.btn_BACK4.TabIndex = 53;
            this.btn_BACK4.Text = " BACK";
            this.btn_BACK4.UseVisualStyleBackColor = true;
            this.btn_BACK4.Click += new System.EventHandler(this.btn_BACK4_Click);
            // 
            // RampSafety2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1074, 435);
            this.Controls.Add(this.btn_BACK4);
            this.Controls.Add(this.btn_delete_safety);
            this.Controls.Add(this.btn_update_safety);
            this.Controls.Add(this.btn_addition_safety);
            this.Controls.Add(this.grdRampSafety);
            this.Controls.Add(this.panel);
            this.Name = "RampSafety2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RampSafety2";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.RampSafety2_Load);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdRampSafety)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView grdRampSafety;
        private System.Windows.Forms.Button btn_delete_safety;
        private System.Windows.Forms.Button btn_update_safety;
        private System.Windows.Forms.Button btn_addition_safety;
        private System.Windows.Forms.Button btn_BACK4;
    }
}