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
    public partial class frmLogsDeslog : Form
    {
        public frmLogsDeslog()
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

        private void frmLogsDeslog_Load(object sender, EventArgs e)
        {
            cn.Open();
            cmd.CommandText = "select * from registroDeLogin";
            cmd.Connection = cn;

            SqlDataAdapter adp = new SqlDataAdapter(cmd); // recebe os dados de uma tabela depois da execução de um Select
            DataTable dt = new DataTable(); // representa uma ou mais tabelas que permanecem alocadas em memória

            adp.SelectCommand = cmd; // recebendo os dados da instrução Select
            adp.Fill(dt); //preenchendo o DataTable

            dgvLogs.DataSource = dt; //Tabela que será preenchida

            dgvLogs.Columns[0].HeaderText = "Registro";
            dgvLogs.Columns[1].HeaderText = "Login";
            dgvLogs.Columns[2].HeaderText = "Senha";
            dgvLogs.Columns[3].HeaderText = "Nome";
            



            cn.Close();
        }
    }
}
