namespace SysAnd___Fix_Mobile_v1._2
{
    partial class frmBusca
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
            this.dgvBusca = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtBusca = new System.Windows.Forms.TextBox();
            this.lblData = new System.Windows.Forms.Label();
            this.lblModelo = new System.Windows.Forms.Label();
            this.lblCor = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.txtDefeito = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblDefeito = new System.Windows.Forms.Label();
            this.btnDown = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBusca)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvBusca
            // 
            this.dgvBusca.AllowUserToAddRows = false;
            this.dgvBusca.AllowUserToDeleteRows = false;
            this.dgvBusca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBusca.Location = new System.Drawing.Point(12, 180);
            this.dgvBusca.Name = "dgvBusca";
            this.dgvBusca.ReadOnly = true;
            this.dgvBusca.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBusca.Size = new System.Drawing.Size(906, 496);
            this.dgvBusca.TabIndex = 72;
            this.dgvBusca.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvBusca_MouseDoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtBusca);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBox1.Location = new System.Drawing.Point(16, 112);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(389, 62);
            this.groupBox1.TabIndex = 73;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar aparelho";
            // 
            // txtBusca
            // 
            this.txtBusca.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBusca.Location = new System.Drawing.Point(15, 25);
            this.txtBusca.Name = "txtBusca";
            this.txtBusca.Size = new System.Drawing.Size(354, 26);
            this.txtBusca.TabIndex = 74;
            this.txtBusca.TextChanged += new System.EventHandler(this.txtBusca_TextChanged);
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lblData.Location = new System.Drawing.Point(27, 51);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(94, 22);
            this.lblData.TabIndex = 74;
            this.lblData.Text = "Data Atual";
            this.lblData.Click += new System.EventHandler(this.lblData_Click);
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblModelo.Location = new System.Drawing.Point(18, 48);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(54, 17);
            this.lblModelo.TabIndex = 75;
            this.lblModelo.Text = "Modelo";
            // 
            // lblCor
            // 
            this.lblCor.AutoSize = true;
            this.lblCor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblCor.Location = new System.Drawing.Point(18, 87);
            this.lblCor.Name = "lblCor";
            this.lblCor.Size = new System.Drawing.Size(30, 17);
            this.lblCor.TabIndex = 76;
            this.lblCor.Text = "Cor";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblStatus.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblStatus.Location = new System.Drawing.Point(18, 110);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(48, 17);
            this.lblStatus.TabIndex = 77;
            this.lblStatus.Text = "Status";
            // 
            // txtDefeito
            // 
            this.txtDefeito.Enabled = false;
            this.txtDefeito.Location = new System.Drawing.Point(199, 40);
            this.txtDefeito.Multiline = true;
            this.txtDefeito.Name = "txtDefeito";
            this.txtDefeito.Size = new System.Drawing.Size(247, 125);
            this.txtDefeito.TabIndex = 78;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblDefeito);
            this.groupBox2.Controls.Add(this.lblModelo);
            this.groupBox2.Controls.Add(this.txtDefeito);
            this.groupBox2.Controls.Add(this.lblCor);
            this.groupBox2.Controls.Add(this.lblStatus);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBox2.Location = new System.Drawing.Point(411, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(463, 171);
            this.groupBox2.TabIndex = 75;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Resumo";
            // 
            // lblDefeito
            // 
            this.lblDefeito.AutoSize = true;
            this.lblDefeito.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblDefeito.Location = new System.Drawing.Point(196, 20);
            this.lblDefeito.Name = "lblDefeito";
            this.lblDefeito.Size = new System.Drawing.Size(57, 17);
            this.lblDefeito.TabIndex = 79;
            this.lblDefeito.Text = "Defeito:";
            // 
            // btnDown
            // 
            this.btnDown.Location = new System.Drawing.Point(330, 90);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(75, 23);
            this.btnDown.TabIndex = 77;
            this.btnDown.Text = "Baixar";
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmBusca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 688);
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvBusca);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmBusca";
            this.Text = "frmBusca";
            this.Load += new System.EventHandler(this.frmBusca_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBusca)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvBusca;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtBusca;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.Label lblCor;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox txtDefeito;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblDefeito;
        private System.Windows.Forms.Button btnDown;
    }
}