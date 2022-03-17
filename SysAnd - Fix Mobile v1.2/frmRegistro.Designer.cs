namespace SysAnd___Fix_Mobile_v1._2
{
    partial class frmRegistro
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtSaida = new System.Windows.Forms.MaskedTextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.dgvTabela = new System.Windows.Forms.DataGridView();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.cbCor = new System.Windows.Forms.ComboBox();
            this.cbModelo = new System.Windows.Forms.ComboBox();
            this.txtObs = new System.Windows.Forms.TextBox();
            this.txtReparo = new System.Windows.Forms.TextBox();
            this.txtDefeito = new System.Windows.Forms.TextBox();
            this.txtPatrimonio = new System.Windows.Forms.TextBox();
            this.lblData = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbSaida = new System.Windows.Forms.CheckBox();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.lblClose2 = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabela)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSaida
            // 
            this.txtSaida.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.txtSaida.Location = new System.Drawing.Point(812, 53);
            this.txtSaida.Mask = "00/00/0000";
            this.txtSaida.Name = "txtSaida";
            this.txtSaida.Size = new System.Drawing.Size(93, 23);
            this.txtSaida.TabIndex = 68;
            this.txtSaida.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSaida.ValidatingType = typeof(System.DateTime);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnCancelar.Location = new System.Drawing.Point(673, 618);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(132, 36);
            this.btnCancelar.TabIndex = 67;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnAlterar.Location = new System.Drawing.Point(397, 618);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(132, 36);
            this.btnAlterar.TabIndex = 65;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnSalvar.Location = new System.Drawing.Point(256, 618);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(132, 36);
            this.btnSalvar.TabIndex = 64;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnNovo.Location = new System.Drawing.Point(118, 618);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(132, 36);
            this.btnNovo.TabIndex = 63;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // dgvTabela
            // 
            this.dgvTabela.AllowUserToAddRows = false;
            this.dgvTabela.AllowUserToDeleteRows = false;
            this.dgvTabela.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTabela.Location = new System.Drawing.Point(439, 184);
            this.dgvTabela.Name = "dgvTabela";
            this.dgvTabela.ReadOnly = true;
            this.dgvTabela.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTabela.Size = new System.Drawing.Size(465, 398);
            this.dgvTabela.TabIndex = 62;
            this.dgvTabela.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTabela_CellContentClick);
            this.dgvTabela.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvTabela_MouseDoubleClick);
            // 
            // cbStatus
            // 
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Items.AddRange(new object[] {
            "Aguardando Análise",
            "Aguardando Chegada de Peças",
            "Aguardando Compra",
            "Aguardando Garantia",
            "Aguardando Reparo",
            "Consertado",
            "Garantia",
            "Sucata"});
            this.cbStatus.Location = new System.Drawing.Point(722, 112);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(182, 21);
            this.cbStatus.TabIndex = 61;
            // 
            // cbCor
            // 
            this.cbCor.FormattingEnabled = true;
            this.cbCor.Items.AddRange(new object[] {
            "Ametista",
            "Azul",
            "Branco",
            "Cinza",
            "Cinza Metálico",
            "Dourado",
            "Indigo",
            "Marrom",
            "Prata",
            "Preto"});
            this.cbCor.Location = new System.Drawing.Point(540, 112);
            this.cbCor.Name = "cbCor";
            this.cbCor.Size = new System.Drawing.Size(109, 21);
            this.cbCor.TabIndex = 60;
            // 
            // cbModelo
            // 
            this.cbModelo.FormattingEnabled = true;
            this.cbModelo.Items.AddRange(new object[] {
            "Galaxy A01 Core (A013)",
            "Galaxy A03s (A037)",
            "Galaxy A10s (A107)",
            "Galaxy A11 (A115)",
            "Galaxy J5 Prime (G570)",
            "Galaxy J5 Pro (J530)",
            "Galaxy J7 Metal (J710)",
            "Galaxy J7 Prime (G610)",
            "Galaxy J7 Prime 2 (G611)",
            "Galaxy S10e (G970)",
            "Galaxy S20 (G980)",
            "Galaxy S6 (G920)",
            "Galaxy S7 (G930)",
            "Galaxy S7 Edge (G935)",
            "Galaxy S8 (G950)",
            "Galaxy TAB A - 10.5\" (T590)",
            "Galaxy Tab A 10.1\" (T510)",
            "Galaxy TAB A 8\" (T290)",
            "Galaxy Tab A 9.7\" (P555)",
            "Galaxy Tab A6 7\" (T280)",
            "Galaxy Tab Active 2 (T395)",
            "Galaxy TAB E - 9.6\" (T561M)",
            "iPad Air - 9.7\" Wi-fi (A1475)",
            "iPad Air (A1475)",
            "iPad Air 2 - 9.7\" 4G (A1396)",
            "iPhone 11 Pro Max (A2218)",
            "iPhone 6 (A1549)",
            "iPhone 7 (A1660)",
            "iPhone 8 (A1864)",
            "iPhone X (A1865)",
            "iPhone XS Max (A1921)",
            "Moto E6 Plus (XT2025)",
            "Moto E7 Plus (XT2081)",
            "Moto G5S Plus (XT1802)",
            "Moto G6 Play (XT1922)",
            "Moto G8 Play (XT2015)"});
            this.cbModelo.Location = new System.Drawing.Point(306, 112);
            this.cbModelo.Name = "cbModelo";
            this.cbModelo.Size = new System.Drawing.Size(182, 21);
            this.cbModelo.TabIndex = 59;
            // 
            // txtObs
            // 
            this.txtObs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtObs.Location = new System.Drawing.Point(33, 403);
            this.txtObs.Multiline = true;
            this.txtObs.Name = "txtObs";
            this.txtObs.Size = new System.Drawing.Size(400, 179);
            this.txtObs.TabIndex = 58;
            // 
            // txtReparo
            // 
            this.txtReparo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtReparo.Location = new System.Drawing.Point(236, 182);
            this.txtReparo.Multiline = true;
            this.txtReparo.Name = "txtReparo";
            this.txtReparo.Size = new System.Drawing.Size(197, 179);
            this.txtReparo.TabIndex = 57;
            // 
            // txtDefeito
            // 
            this.txtDefeito.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtDefeito.Location = new System.Drawing.Point(33, 182);
            this.txtDefeito.Multiline = true;
            this.txtDefeito.Name = "txtDefeito";
            this.txtDefeito.Size = new System.Drawing.Size(197, 179);
            this.txtDefeito.TabIndex = 56;
            // 
            // txtPatrimonio
            // 
            this.txtPatrimonio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPatrimonio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtPatrimonio.Location = new System.Drawing.Point(130, 109);
            this.txtPatrimonio.Name = "txtPatrimonio";
            this.txtPatrimonio.Size = new System.Drawing.Size(100, 26);
            this.txtPatrimonio.TabIndex = 55;
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lblData.Location = new System.Drawing.Point(256, 52);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(94, 22);
            this.lblData.TabIndex = 54;
            this.lblData.Text = "Data Atual";
            this.lblData.Click += new System.EventHandler(this.lblData_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label11.Location = new System.Drawing.Point(25, 112);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(95, 22);
            this.label11.TabIndex = 53;
            this.label11.Text = "Patrimônio";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label10.Location = new System.Drawing.Point(236, 111);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 22);
            this.label10.TabIndex = 52;
            this.label10.Text = "Modelo";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label9.Location = new System.Drawing.Point(495, 112);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 22);
            this.label9.TabIndex = 51;
            this.label9.Text = "Cor";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label8.Location = new System.Drawing.Point(29, 157);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 22);
            this.label8.TabIndex = 50;
            this.label8.Text = "Defeito";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label7.Location = new System.Drawing.Point(232, 157);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 22);
            this.label7.TabIndex = 49;
            this.label7.Text = "Reparo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label6.Location = new System.Drawing.Point(655, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 22);
            this.label6.TabIndex = 48;
            this.label6.Text = "Status";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label5.Location = new System.Drawing.Point(29, 378);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 22);
            this.label5.TabIndex = 47;
            this.label5.Text = "Observações";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label2.Location = new System.Drawing.Point(177, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 22);
            this.label2.TabIndex = 45;
            this.label2.Text = "Entrada";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lblID.Location = new System.Drawing.Point(58, 52);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(99, 22);
            this.lblID.TabIndex = 44;
            this.lblID.Text = "ID Registro";
            this.lblID.Click += new System.EventHandler(this.lblID_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label1.Location = new System.Drawing.Point(25, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 22);
            this.label1.TabIndex = 43;
            this.label1.Text = "ID";
            // 
            // cbSaida
            // 
            this.cbSaida.AutoSize = true;
            this.cbSaida.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.cbSaida.Location = new System.Drawing.Point(731, 52);
            this.cbSaida.Name = "cbSaida";
            this.cbSaida.Size = new System.Drawing.Size(75, 26);
            this.cbSaida.TabIndex = 69;
            this.cbSaida.Text = "Saida";
            this.cbSaida.UseVisualStyleBackColor = true;
            this.cbSaida.CheckedChanged += new System.EventHandler(this.cbSaida_CheckedChanged);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnExcluir.Location = new System.Drawing.Point(535, 618);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(132, 36);
            this.btnExcluir.TabIndex = 66;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // lblClose2
            // 
            this.lblClose2.AutoSize = true;
            this.lblClose2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.lblClose2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblClose2.Location = new System.Drawing.Point(895, 7);
            this.lblClose2.Name = "lblClose2";
            this.lblClose2.Size = new System.Drawing.Size(27, 25);
            this.lblClose2.TabIndex = 70;
            this.lblClose2.Text = "X";
            this.lblClose2.Click += new System.EventHandler(this.lblClose2_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(440, 158);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(464, 20);
            this.txtBuscar.TabIndex = 71;
            this.txtBuscar.Text = "Buscar";
            this.txtBuscar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtBuscar_MouseClick);
            this.txtBuscar.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // frmRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.lblClose2);
            this.Controls.Add(this.cbSaida);
            this.Controls.Add(this.txtSaida);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.dgvTabela);
            this.Controls.Add(this.cbStatus);
            this.Controls.Add(this.cbCor);
            this.Controls.Add(this.cbModelo);
            this.Controls.Add(this.txtObs);
            this.Controls.Add(this.txtReparo);
            this.Controls.Add(this.txtDefeito);
            this.Controls.Add(this.txtPatrimonio);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.label1);
            this.Name = "frmRegistro";
            this.Size = new System.Drawing.Size(930, 688);
            this.Load += new System.EventHandler(this.frmRegistro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabela)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox txtSaida;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.DataGridView dgvTabela;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.ComboBox cbCor;
        private System.Windows.Forms.ComboBox cbModelo;
        private System.Windows.Forms.TextBox txtObs;
        private System.Windows.Forms.TextBox txtReparo;
        private System.Windows.Forms.TextBox txtDefeito;
        private System.Windows.Forms.TextBox txtPatrimonio;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbSaida;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Label lblClose2;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}
