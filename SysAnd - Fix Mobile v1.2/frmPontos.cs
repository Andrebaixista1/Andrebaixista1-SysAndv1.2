using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SysAnd___Fix_Mobile_v1._2
{
    public partial class frmPontos : Form
    {
        
        SqlConnection cn = new SqlConnection(@"Data Source=brm3907\SQLEXPRESS;integrated security=SSPI;initial Catalog=FixMobileDataBase;"); // Conecta ao DB
        SqlDataReader dt; // Faz a leitura da DB
        SqlCommand cmd = new SqlCommand();
        SqlCommand cm = new SqlCommand();

        public frmPontos()
        {
            InitializeComponent();
            /*try
            {
                
                cn.Open();
                cm.CommandText = "select * from registroDeLogin";
                cm.Connection = cn;

                SqlDataAdapter adp = new SqlDataAdapter(cm); // recebe os dados de uma tabela depois da execução de um Select




                DateTime data = DateTime.Now;
                string entradasaida = "Entrada";



                string sql = "insert into registroDeLogin(dataHora,login_user,pass_user,entrada_saida) values(@data,@login,@senha,@entradasaida)";


                SqlCommand cmd = new SqlCommand(sql, cn);

                cmd.Parameters.Add("@data", SqlDbType.DateTime).Value = data;
                cmd.Parameters.Add("@login", SqlDbType.VarChar).Value = login;
                cmd.Parameters.Add("@senha", SqlDbType.VarChar).Value = senha;
                cmd.Parameters.Add("@entradasaida", SqlDbType.VarChar).Value = senha;
                cn.Open();
                cmd.ExecuteNonQuery(); //Executar sem consulta
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                cn.Close();
            }*/
        }
      

        private void bancoDeDados()
        {
            cn.Open();
            cmd.CommandText = "select * from registroDeLogin";
            cmd.Connection = cn;
            
            SqlDataAdapter adp = new SqlDataAdapter(cmd); // recebe os dados de uma tabela depois da execução de um Select
            DataTable dt = new DataTable(); // representa uma ou mais tabelas que permanecem alocadas em memória

            adp.SelectCommand = cmd; // recebendo os dados da instrução Select
            adp.Fill(dt); //preenchendo o DataTable

            dgvPontos.DataSource = dt; //Tabela que será preenchida
            dgvPontos.Columns[0].HeaderText = "Data/Hora";
            dgvPontos.Columns[1].HeaderText = "Login";
            dgvPontos.Columns[2].HeaderText = "Senha";
            dgvPontos.Columns[3].HeaderText = "Entrada/Saida";


            cn.Close();

        }

        
        private void frmPontos_Load(object sender, EventArgs e)
        {
            bancoDeDados();
            btnRest.Hide();
            
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMax.Hide();
            btnRest.Show();
        }

        private void btnRest_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnRest.Hide();
            btnMax.Show();
        }
    }
}
