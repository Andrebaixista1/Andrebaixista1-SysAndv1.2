using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SysAnd___Fix_Mobile_v1._2
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        /*Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Administrador\Documents\FixManutencaoDB.mdf;Integrated Security = True; Connect Timeout = 30*/
        SqlConnection cn = new SqlConnection(@"Data Source=brm3907\SQLEXPRESS;integrated security=SSPI;initial Catalog=FixMobileDataBase;"); // Conecta ao DB
        SqlCommand cmd = new SqlCommand(); // Aceita comandos em SQL
        SqlDataReader dt; // Faz a leitura da DB

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        void lblClose_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void btnCriarLogin_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Esse recurso se encontra em desenvolvimento", "Informação - SysAndv1.2", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void teste()
        {

            /*cn.Open();*/
            DateTime timeDate2 = DateTime.Now;
            string login = txtLogin.Text;
            string senha = txtSenha.Text;
            string name_us = "André Felipe";

            

            string sql = "insert into registroDeLogin(dataHora,login_user,pass_user,nm_user) values(@timeDate2,@login,@senha,@name_us)";

            SqlCommand cm = new SqlCommand(sql, cn);

            cm.Parameters.Add("@timeDate2", SqlDbType.DateTime).Value = timeDate2;
            cm.Parameters.Add("@login", SqlDbType.VarChar).Value = login;
            cm.Parameters.Add("@senha", SqlDbType.VarChar).Value = senha;
            cm.Parameters.Add("@name_us", SqlDbType.VarChar).Value = name_us;

            cm.ExecuteNonQuery(); //Executar sem consulta
            /*cn.Close();*/
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            if (txtLogin.Text == "" || txtSenha.Text == "")
            {
                MessageBox.Show("Preencha todos os campos !", "Atenção !", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {

                    SqlCommand cm = new SqlCommand();
                    cn.Open();
                    cm.CommandText = "select * from user_loginADM where login_user = ('" + txtLogin.Text + "') and pass_user = ('" + txtSenha.Text + "') ";
                    cm.Connection = cn;
                    dt = cm.ExecuteReader();
                    

                    



                    if (dt.HasRows)
                    {
                        
                        teste();
                        

                        frmMenu menu = new frmMenu();
                        menu.Show();
                        this.Hide();

                        
                    }
                    else
                    {
                        MessageBox.Show("Usuário não encontrado! Verifique o usuário/senha", "Atenção !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtLogin.Clear();
                        txtSenha.Clear();
                        txtLogin.Focus();
                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro no banco de dados '" + ex.Message + "'", "Atenção !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cn.Close();
                }
                finally
                {
                    

                    cn.Close();
                    

                }
                
            }

        }

        private void frmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}
