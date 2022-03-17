namespace SysAnd___Fix_Mobile_v1._2
{
    partial class frmLogsDeslog
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
            this.lblClose2 = new System.Windows.Forms.Label();
            this.dgvLogs = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLogs)).BeginInit();
            this.SuspendLayout();
            // 
            // lblClose2
            // 
            this.lblClose2.AutoSize = true;
            this.lblClose2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.lblClose2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblClose2.Location = new System.Drawing.Point(895, 7);
            this.lblClose2.Name = "lblClose2";
            this.lblClose2.Size = new System.Drawing.Size(27, 25);
            this.lblClose2.TabIndex = 72;
            this.lblClose2.Text = "X";
            this.lblClose2.Click += new System.EventHandler(this.lblClose2_Click);
            // 
            // dgvLogs
            // 
            this.dgvLogs.AllowUserToAddRows = false;
            this.dgvLogs.AllowUserToDeleteRows = false;
            this.dgvLogs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLogs.Location = new System.Drawing.Point(12, 170);
            this.dgvLogs.Name = "dgvLogs";
            this.dgvLogs.ReadOnly = true;
            this.dgvLogs.Size = new System.Drawing.Size(906, 506);
            this.dgvLogs.TabIndex = 73;
            // 
            // frmLogsDeslog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 688);
            this.Controls.Add(this.dgvLogs);
            this.Controls.Add(this.lblClose2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLogsDeslog";
            this.Text = "frmLogsDeslog";
            this.Load += new System.EventHandler(this.frmLogsDeslog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLogs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblClose2;
        private System.Windows.Forms.DataGridView dgvLogs;
    }
}