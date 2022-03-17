using ClosedXML.Excel;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Windows.Forms;

namespace SysAnd___Fix_Mobile_v1._2
{
    public partial class frmBusca : Form
    {
        public frmBusca()
        {
            InitializeComponent();
        }
        SqlConnection cn = new SqlConnection(@"Data Source=brm3907\SQLEXPRESS;integrated security=SSPI;initial Catalog=FixMobileDataBase;"); // Conecta ao DB
        SqlCommand cmd = new SqlCommand(); // Aceita comandos em SQL
        SqlDataReader dt; // Faz a leitura da DB
        private void lblClose2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtBusca_TextChanged(object sender, EventArgs e)
        {

            visaoInativa();
            if (txtBusca.Text != "")
            {
                try
                {
                    cn.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "select * from FixManutencao where patrimonio like ('" + txtBusca.Text + "%') or modelo like ('%" + txtBusca.Text + "%') or status_tb like ('" + txtBusca.Text + "%')";
                    cmd.Connection = cn;

                    SqlDataAdapter adp = new SqlDataAdapter(cmd); // recebe os dados de uma tabela depois da execução de um Select
                    DataTable dt = new DataTable(); // representa uma ou mais tabelas que permanecem alocadas em memória

                    adp.SelectCommand = cmd; // recebendo os dados da instrução Select
                    adp.Fill(dt); //preenchendo o DataTable

                    dgvBusca.DataSource = dt; //Tabela que será preenchida
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

                dgvBusca.DataSource = dt; //Tabela que será preenchida
                cn.Close();
            }
        }


        private void carregaPainel()
        {
            cn.Open();
            cmd.CommandText = "select * from FixManutencao";
            cmd.Connection = cn;

            SqlDataAdapter adp = new SqlDataAdapter(cmd); // recebe os dados de uma tabela depois da execução de um Select
            DataTable dt = new DataTable(); // representa uma ou mais tabelas que permanecem alocadas em memória

            adp.SelectCommand = cmd; // recebendo os dados da instrução Select
            adp.Fill(dt); //preenchendo o DataTable

            dgvBusca.DataSource = dt; //Tabela que será preenchida

            dgvBusca.Columns[0].HeaderText = "Id";
            dgvBusca.Columns[1].HeaderText = "Entrada";
            dgvBusca.Columns[2].HeaderText = "Patrimônio";
            dgvBusca.Columns[3].HeaderText = "Modelo";
            dgvBusca.Columns[4].HeaderText = "Cor";
            dgvBusca.Columns[5].HeaderText = "Defeito";
            dgvBusca.Columns[6].HeaderText = "Reparo";
            dgvBusca.Columns[7].HeaderText = "Status";
            dgvBusca.Columns[8].HeaderText = "Observações";
            dgvBusca.Columns[9].HeaderText = "Saida";



            cn.Close();

        }



        private void chardInfo()
        {
            /*dgvTabela.SelectedRows[0].Cells[0].Value.ToString();*/


            lblModelo.Text = dgvBusca.SelectedRows[0].Cells[3].Value.ToString();
            lblCor.Text = dgvBusca.SelectedRows[0].Cells[4].Value.ToString();
            lblStatus.Text = dgvBusca.SelectedRows[0].Cells[7].Value.ToString();
            txtDefeito.Text = dgvBusca.SelectedRows[0].Cells[5].Value.ToString();
        }


        private void frmBusca_Load(object sender, EventArgs e)
        {

            visaoInativa();
            lblData.Text = DateTime.Now.ToString();

            carregaPainel();





        }

        private void lblData_Click(object sender, EventArgs e)
        {

        }

        private void visaoAtiva()
        {
            lblModelo.Visible = true;
            lblCor.Visible = true;
            lblStatus.Visible = true;
            txtDefeito.Visible = true;
            lblDefeito.Visible = true;
        }
        private void visaoInativa()
        {
            lblModelo.Visible = false;
            lblCor.Visible = false;
            lblStatus.Visible = false;
            txtDefeito.Visible = false;
            lblDefeito.Visible = false;
        }

        private void dgvBusca_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            chardInfo();
            visaoAtiva();
        }

        private void button1_Click(object sender, EventArgs e)
        {



            using (var workbook = new XLWorkbook())
            {

                var worksheet = workbook.Worksheets.Add("FixManutenção");
                int c = 1;
                worksheet.Cell("A1").Value = "ID";
                worksheet.Cell("B1").Value = "Entrada";
                worksheet.Cell("C1").Value = "Patrimônio";
                worksheet.Cell("D1").Value = "Modelo";
                worksheet.Cell("E1").Value = "Cor";
                worksheet.Cell("F1").Value = "Defeito";
                worksheet.Cell("G1").Value = "Reparo";
                worksheet.Cell("H1").Value = "Status";
                worksheet.Cell("I1").Value = "Observações";
                worksheet.Cell("J1").Value = "Saida";
                for (int i = 0; i < dgvBusca.Rows.Count; i++)
                {
                    var id = dgvBusca.Rows[i].Cells["id"].Value;
                    var entrada = dgvBusca.Rows[i].Cells["entrada"].Value;
                    var patrimonio = dgvBusca.Rows[i].Cells["patrimonio"].Value;
                    var modelo = dgvBusca.Rows[i].Cells["modelo"].Value;
                    var cor = dgvBusca.Rows[i].Cells["cor"].Value;
                    var defeito = dgvBusca.Rows[i].Cells["defeito"].Value;
                    var reparo = dgvBusca.Rows[i].Cells["reparo"].Value;
                    var status = dgvBusca.Rows[i].Cells["status_tb"].Value;
                    var obs = dgvBusca.Rows[i].Cells["obs"].Value;
                    var saida = dgvBusca.Rows[i].Cells["saida"].Value;


                    c++;

                    worksheet.Cell("A" + c).Value = id;
                    worksheet.Cell("B" + c).Value = entrada;
                    worksheet.Cell("C" + c).Value = patrimonio;
                    worksheet.Cell("D" + c).Value = modelo;
                    worksheet.Cell("E" + c).Value = cor;
                    worksheet.Cell("F" + c).Value = defeito;
                    worksheet.Cell("G" + c).Value = reparo;
                    worksheet.Cell("H" + c).Value = status;
                    worksheet.Cell("I" + c).Value = obs;
                    worksheet.Cell("J" + c).Value = saida;


                }



                workbook.SaveAs(@"C:\Users\Administrador\Desktop\FixManutençãoFicha.xlsx");
            }
            MessageBox.Show("Arquivo salvo na sua area de trabalho!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            Process.Start(new ProcessStartInfo(@"C:\Users\Administrador\Desktop\FixManutençãoFicha.xlsx") { UseShellExecute = true });

        }
    }
}

