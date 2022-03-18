namespace SysAnd___Fix_Mobile_v1._2
{
    partial class frmPontos
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
            this.dgvPontos = new System.Windows.Forms.DataGridView();
            this.btnRest = new System.Windows.Forms.PictureBox();
            this.btnMax = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPontos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPontos
            // 
            this.dgvPontos.AllowUserToAddRows = false;
            this.dgvPontos.AllowUserToDeleteRows = false;
            this.dgvPontos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPontos.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvPontos.Location = new System.Drawing.Point(0, 175);
            this.dgvPontos.Name = "dgvPontos";
            this.dgvPontos.ReadOnly = true;
            this.dgvPontos.Size = new System.Drawing.Size(930, 513);
            this.dgvPontos.TabIndex = 0;
            // 
            // btnRest
            // 
            this.btnRest.BackColor = System.Drawing.SystemColors.Control;
            this.btnRest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRest.Image = global::SysAnd___Fix_Mobile_v1._2.Properties.Resources.icons8_restaurar_janela_301;
            this.btnRest.Location = new System.Drawing.Point(33, 4);
            this.btnRest.Name = "btnRest";
            this.btnRest.Size = new System.Drawing.Size(30, 30);
            this.btnRest.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnRest.TabIndex = 84;
            this.btnRest.TabStop = false;
            this.btnRest.Click += new System.EventHandler(this.btnRest_Click);
            // 
            // btnMax
            // 
            this.btnMax.BackColor = System.Drawing.SystemColors.Control;
            this.btnMax.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMax.Image = global::SysAnd___Fix_Mobile_v1._2.Properties.Resources.icons8_maximizar_janela_301;
            this.btnMax.Location = new System.Drawing.Point(33, 4);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(30, 30);
            this.btnMax.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnMax.TabIndex = 87;
            this.btnMax.TabStop = false;
            this.btnMax.Click += new System.EventHandler(this.btnMax_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.SystemColors.Control;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Image = global::SysAnd___Fix_Mobile_v1._2.Properties.Resources.icons8_fechar_janela_30;
            this.btnClose.Location = new System.Drawing.Point(4, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(30, 30);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnClose.TabIndex = 85;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmPontos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 688);
            this.Controls.Add(this.btnRest);
            this.Controls.Add(this.btnMax);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dgvPontos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPontos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAssistencia";
            this.Load += new System.EventHandler(this.frmPontos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPontos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPontos;
        private System.Windows.Forms.PictureBox btnRest;
        private System.Windows.Forms.PictureBox btnMax;
        private System.Windows.Forms.PictureBox btnClose;
    }
}