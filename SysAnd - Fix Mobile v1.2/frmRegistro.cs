using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SysAnd___Fix_Mobile_v1._2
{
    public partial class frmRegistro : UserControl
    {
        public frmRegistro()
        {
            InitializeComponent();
        }
        SqlConnection cn = new SqlConnection(@"Data Source=brm3907\SQLEXPRESS;integrated security=SSPI;initial Catalog=FixMobileDataBase;"); // Conecta ao DB
        SqlCommand cmd = new SqlCommand(); // Aceita comandos em SQL
        SqlDataReader dt; // Faz a leitura da DB
        private void desabilitaCampos()
        {
            lblID.Text = "00";
            txtPatrimonio.Enabled = false;
            txtReparo.Enabled = false;
            txtDefeito.Enabled = false;
            txtObs.Enabled = false;
            cbCor.Enabled = false;
            cbModelo.Enabled = false;
            cbStatus.Enabled = false;
            cbSaida.Enabled = false;
            txtSaida.Enabled = false;

            btnAlterar.Enabled = false;
            btnCancelar.Enabled = false;
            btnExcluir.Enabled = false;
            btnSalvar.Enabled = false;



            lblData.Text = DateTime.Now.ToString();

        }

        private void habilitaCampos()
        {
            /*lblID.Text = "00";*/
            txtPatrimonio.Enabled = true;
            txtPatrimonio.Focus();
            txtReparo.Enabled = true;
            txtDefeito.Enabled = true;
            txtObs.Enabled = true;
            cbCor.Enabled = true;
            cbModelo.Enabled = true;
            cbStatus.Enabled = true;
            txtSaida.Enabled = false;
            lblData.Text = DateTime.Now.ToString();
            cbSaida.Enabled = true;
            txtSaida.Text = "01011990";

            btnNovo.Enabled = false;
            btnSalvar.Enabled = true;
            btnCancelar.Enabled = true;

        }
        private void habilitaCampos2()
        {
            /*lblID.Text = "00";*/
            txtPatrimonio.Enabled = true;
            txtPatrimonio.Focus();
            txtReparo.Enabled = true;
            txtDefeito.Enabled = true;
            txtObs.Enabled = true;
            cbCor.Enabled = true;
            cbModelo.Enabled = true;
            cbStatus.Enabled = true;
            txtSaida.Enabled = false;
            lblData.Text = DateTime.Now.ToString();
            cbSaida.Enabled = true;
            /*txtSaida.Text = "01011990";*/

            btnNovo.Enabled = false;
            btnSalvar.Enabled = true;
            btnCancelar.Enabled = true;

        }


        private void limpar()
        {
            /*lblID.Text = "00";*/
            txtPatrimonio.Text = "";
            txtReparo.Text = "";
            txtDefeito.Text = "";
            txtObs.Text = "";
            cbCor.Text = "";
            cbModelo.Text = "";
            cbStatus.Text = "";
            txtSaida.Text = "01011990";
        }

        private void carregaPainel()
        {

            cmd.CommandText = "select * from FixManutencao";
            cmd.Connection = cn;

            SqlDataAdapter adp = new SqlDataAdapter(cmd); // recebe os dados de uma tabela depois da execução de um Select
            DataTable dt = new DataTable(); // representa uma ou mais tabelas que permanecem alocadas em memória

            adp.SelectCommand = cmd; // recebendo os dados da instrução Select
            adp.Fill(dt); //preenchendo o DataTable

            dgvTabela.DataSource = dt; //Tabela que será preenchida
            dgvTabela.Columns[0].HeaderText = "Id";
            dgvTabela.Columns[1].HeaderText = "Entrada";
            dgvTabela.Columns[2].HeaderText = "Patrimônio";
            dgvTabela.Columns[3].HeaderText = "Modelo";
            dgvTabela.Columns[4].HeaderText = "Cor";
            dgvTabela.Columns[5].HeaderText = "Defeito";
            dgvTabela.Columns[6].HeaderText = "Reparo";
            dgvTabela.Columns[7].HeaderText = "Status";
            dgvTabela.Columns[8].HeaderText = "Observações";
            dgvTabela.Columns[9].HeaderText = "Saida";
        }
        private void frmRegistro_Load(object sender, EventArgs e)
        {
            desabilitaCampos();
            cn.Open();
            carregaPainel();
            cn.Close();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            habilitaCampos();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            desabilitaCampos();
            limpar();
            cn.Open();
            carregaPainel();
            cn.Close();
            btnNovo.Enabled = true;
        }

        private void dgvTabela_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }




        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtPatrimonio.Text == "")
            {
                MessageBox.Show("Digite um patrimônio!", "Atenção !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPatrimonio.Focus();
            }
            /*else if (cbModelo.SelectedValue == "")
            {
                MessageBox.Show("Digite um modelo!", "Atenção !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbModelo.Focus();
            }
            else if (cbCor.Text == "")
            {
                MessageBox.Show("Digite um modelo!", "Atenção !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbCor.Focus();
            }
            else if (cbStatus.Text == "")
            {
                MessageBox.Show("Digite um modelo!", "Atenção !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbStatus.Focus();
            }*/
            else if (txtDefeito.Text == "")
            {
                MessageBox.Show("Digite um defeito!", "Atenção !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDefeito.Focus();
            }

            else
            {
                try
                {

                    SqlCommand cm = new SqlCommand();
                    cn.Open();
                    cm.CommandText = "select * from FixManutencao";
                    cm.Connection = cn;

                    SqlDataAdapter adp = new SqlDataAdapter(cm); // recebe os dados de uma tabela depois da execução de um Select
                    DataTable dt = new DataTable(); // representa uma ou mais tabelas que permanecem alocadas em memória

                    adp.SelectCommand = cm; // recebendo os dados da instrução Select
                    adp.Fill(dt); //preenchendo o DataTable

                    dgvTabela.DataSource = dt; //Tabela que será preenchida
                                               // cn.Close();

                    int ids = dt.Rows.Count;
                    ids += 1;

                    /*cn.Close();*/

                    int id = ids;

                    DateTime entrada = Convert.ToDateTime(lblData.Text);
                    string patrimonio = txtPatrimonio.Text;
                    string modelo = cbModelo.Text;
                    string cor = cbCor.Text;
                    string defeito = txtDefeito.Text;
                    string reparo = txtReparo.Text;
                    string status = cbStatus.Text;
                    string obs = txtObs.Text;
                    DateTime saida = Convert.ToDateTime(txtSaida.Text.ToString());




                    string sql = "insert into FixManutencao(id,entrada,patrimonio,modelo,cor,defeito,reparo,status_tb,obs,saida) values(@id,@entrada,@patrimonio,@modelo,@cor,@defeito,@reparo,@status,@obs,@saida)";


                    SqlCommand cmd = new SqlCommand(sql, cn);

                    cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                    cmd.Parameters.Add("@entrada", SqlDbType.DateTime).Value = entrada;
                    cmd.Parameters.Add("@patrimonio", SqlDbType.NVarChar).Value = patrimonio;
                    cmd.Parameters.Add("@modelo", SqlDbType.NVarChar).Value = modelo;
                    cmd.Parameters.Add("@cor", SqlDbType.NVarChar).Value = cor;
                    cmd.Parameters.Add("@defeito", SqlDbType.NVarChar).Value = defeito;
                    cmd.Parameters.Add("@reparo", SqlDbType.NVarChar).Value = reparo;
                    cmd.Parameters.Add("@status", SqlDbType.NVarChar).Value = status;
                    cmd.Parameters.Add("@obs", SqlDbType.NVarChar).Value = obs;
                    cmd.Parameters.Add("@saida", SqlDbType.DateTime).Value = saida;



                    /*cn.Open();*/
                    cmd.ExecuteNonQuery(); //Executar sem consulta
                    limpar();
                    MessageBox.Show("Aparelho cadastrado com sucesso !", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    carregaPainel();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    cn.Close();
                }





            }
        }

        private void lblData_Click(object sender, EventArgs e)
        {

        }
        /* private void manipularDados()
         {
             lblID.Visible = true;
             lblIdName.Visible = true;
             btnAlterar.Enabled = true;
             btnExcluir.Enabled = true;
             btnCancelar.Enabled = true;
             btnNovo.Enabled = false;
             btnSalvar.Enabled = false;
             txtNome.Enabled = true;
             txtLogin.Enabled = true;
             txtSenha.Enabled = true;
         }*/
        private void carregaLogin()
        {
            /*dgvTabela.SelectedRows[0].Cells[0].Value.ToString();*/

            lblID.Text = dgvTabela.SelectedRows[0].Cells[0].Value.ToString();
            lblData.Text = dgvTabela.SelectedRows[0].Cells[1].Value.ToString();
            txtPatrimonio.Text = dgvTabela.SelectedRows[0].Cells[2].Value.ToString();
            cbModelo.Text = dgvTabela.SelectedRows[0].Cells[3].Value.ToString();
            cbCor.Text = dgvTabela.SelectedRows[0].Cells[4].Value.ToString();
            txtDefeito.Text = dgvTabela.SelectedRows[0].Cells[5].Value.ToString();
            txtReparo.Text = dgvTabela.SelectedRows[0].Cells[6].Value.ToString();
            cbStatus.Text = dgvTabela.SelectedRows[0].Cells[7].Value.ToString();
            txtObs.Text = dgvTabela.SelectedRows[0].Cells[8].Value.ToString();
            txtSaida.Enabled = true;
            txtSaida.Text = dgvTabela.SelectedRows[0].Cells[9].Value.ToString();
        }
        private void dgvTabela_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            carregaLogin();
            habilitaCampos2();


            btnNovo.Enabled = false;
            btnSalvar.Enabled = false;
            btnAlterar.Enabled = true;
            btnExcluir.Enabled = true;
            btnCancelar.Enabled = true;

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (txtPatrimonio.Text == "")
            {
                MessageBox.Show("Digite um patrimônio!", "Atenção !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPatrimonio.Focus();
            }
            /*else if (cbModelo.SelectedValue == "")
            {
                MessageBox.Show("Digite um modelo!", "Atenção !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbModelo.Focus();
            }
            else if (cbCor.Text == "")
            {
                MessageBox.Show("Digite um modelo!", "Atenção !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbCor.Focus();
            }
            else if (cbStatus.Text == "")
            {
                MessageBox.Show("Digite um modelo!", "Atenção !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbStatus.Focus();
            }*/
            else if (txtDefeito.Text == "")
            {
                MessageBox.Show("Digite um defeito!", "Atenção !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDefeito.Focus();
            }
            else
            {
                try
                {
                    /*string nome = txtNome.Text;
                    string login = txtLogin.Text;
                    string senha = txtSenha.Text;*/
                    int id = Convert.ToInt32(lblID.Text);

                    /*DateTime entrada = Convert.ToDateTime(lblData.Text);*/
                    string patrimonio = txtPatrimonio.Text;
                    string modelo = cbModelo.Text;
                    string cor = cbCor.Text;
                    string defeito = txtDefeito.Text;
                    string reparo = txtReparo.Text;
                    string status = cbStatus.Text;
                    string obs = txtObs.Text;
                    DateTime saida = Convert.ToDateTime(txtSaida.Text.ToString());


                    string sql = "UPDATE FixManutencao set patrimonio=@patrimonio, modelo=@modelo, cor=@cor, defeito=@defeito, reparo=@reparo, status_tb=@status, obs=@obs, saida=@saida WHERE id=@id";


                    SqlCommand cmd = new SqlCommand(sql, cn);

                    cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;

                    /*cmd.Parameters.Add("@entrada", SqlDbType.DateTime).Value = entrada;*/
                    cmd.Parameters.Add("@patrimonio", SqlDbType.VarChar).Value = patrimonio;
                    cmd.Parameters.Add("@modelo", SqlDbType.VarChar).Value = modelo;
                    cmd.Parameters.Add("@cor", SqlDbType.VarChar).Value = cor;
                    cmd.Parameters.Add("@defeito", SqlDbType.Text).Value = defeito;
                    cmd.Parameters.Add("@reparo", SqlDbType.Text).Value = reparo;
                    cmd.Parameters.Add("@status", SqlDbType.VarChar).Value = status;
                    cmd.Parameters.Add("@obs", SqlDbType.Text).Value = obs;
                    cmd.Parameters.Add("@saida", SqlDbType.DateTime).Value = saida;





                    cn.Open();
                    cmd.ExecuteNonQuery(); //Executar sem consulta
                    cmd.Parameters.Clear(); //Limpa os parâmetros após usado
                    limpar();
                    desabilitaCampos();
                    btnNovo.Enabled = true;
                    MessageBox.Show("Aparelho alterado com sucesso !", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    carregaPainel();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    cn.Close();
                }
                finally
                {
                    cn.Close();
                }
            }
        }

        private void lblID_Click(object sender, EventArgs e)
        {

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (txtPatrimonio.Text == "")
            {
                MessageBox.Show("Digite um patrimônio!", "Atenção !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPatrimonio.Focus();
            }
            /*else if (cbModelo.SelectedValue == "")
            {
                MessageBox.Show("Digite um modelo!", "Atenção !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbModelo.Focus();
            }
            else if (cbCor.Text == "")
            {
                MessageBox.Show("Digite um modelo!", "Atenção !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbCor.Focus();
            }
            else if (cbStatus.Text == "")
            {
                MessageBox.Show("Digite um modelo!", "Atenção !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbStatus.Focus();
            }*/
            else if (txtDefeito.Text == "")
            {
                MessageBox.Show("Digite um defeito!", "Atenção !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDefeito.Focus();
            }
            else
            {
                try
                {

                    int id = Convert.ToInt32(lblID.Text);




                    string sql = "DELETE FROM FixManutencao WHERE id=@id";


                    SqlCommand cmd = new SqlCommand(sql, cn);

                    cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;


                    cn.Open();
                    cmd.ExecuteNonQuery(); //Executar sem consulta
                    cmd.Parameters.Clear(); //Limpa os parâmetros após usado
                    limpar();
                    desabilitaCampos();
                    btnNovo.Enabled = true;
                    MessageBox.Show("Aparelho excluido com sucesso !", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    carregaPainel();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    cn.Close();
                }
                finally
                {
                    cn.Close();
                }
            }
        }

        private void lblClose2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cbSaida_CheckedChanged(object sender, EventArgs e)
        {
            if (cbSaida.Checked)
            {
                txtSaida.Enabled = true;

            }
            else
            {
                txtSaida.Enabled = false;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscar.Text != "")
            {
                try
                {
                    cn.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "select * from FixManutencao where patrimonio like ('" + txtBuscar.Text + "%') or modelo like ('%" + txtBuscar.Text + "%') or status_tb like ('" + txtBuscar.Text + "%') or defeito like ('" + txtBuscar.Text + "%')or reparo like ('" + txtBuscar.Text + "%') or cor like ('" + txtBuscar.Text + "%')";
                    cmd.Connection = cn;

                    SqlDataAdapter adp = new SqlDataAdapter(cmd); // recebe os dados de uma tabela depois da execução de um Select
                    DataTable dt = new DataTable(); // representa uma ou mais tabelas que permanecem alocadas em memória

                    adp.SelectCommand = cmd; // recebendo os dados da instrução Select
                    adp.Fill(dt); //preenchendo o DataTable

                    dgvTabela.DataSource = dt; //Tabela que será preenchida
                    cn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                //dgvPesq.DataSource = null;
                cn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "select * from FixManutencao";
                cmd.Connection = cn;

                SqlDataAdapter adp = new SqlDataAdapter(cmd); // recebe os dados de uma tabela depois da execução de um Select
                DataTable dt = new DataTable(); // representa uma ou mais tabelas que permanecem alocadas em memória

                adp.SelectCommand = cmd; // recebendo os dados da instrução Select
                adp.Fill(dt); //preenchendo o DataTable

                dgvTabela.DataSource = dt; //Tabela que será preenchida
                cn.Close();
            }
        }

        private void txtBuscar_MouseClick(object sender, MouseEventArgs e)
        {

            txtBuscar.Text = "";
        }
    }
}
