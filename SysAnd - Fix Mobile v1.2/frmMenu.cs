using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace SysAnd___Fix_Mobile_v1._2
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }
        

        SqlConnection cn = new SqlConnection(@"Data Source=brm3907\SQLEXPRESS;integrated security=SSPI;initial Catalog=FixMobileDataBase;"); // Conecta ao DB
        SqlCommand cmd = new SqlCommand(); // Aceita comandos em SQL
        SqlDataReader dt; // Faz a leitura da DB

        private void frmMenu_Load(object sender, EventArgs e)
        {


        }



        private void lblClose_Click(object sender, EventArgs e)
        {


        }

        private void frmMenu_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void lblClose_Click_1(object sender, EventArgs e)
        {
            /*SqlConnection cn = new SqlConnection(@"Data Source=brm3907\SQLEXPRESS;integrated security=SSPI;initial Catalog=FixMobileDataBase;"); // Conecta ao DB
            SqlCommand cmd = new SqlCommand(); // Aceita comandos em SQL
            SqlDataReader dt; // Faz a leitura da DB
            cn.Close();*/
            frmLogin menuLogin = new frmLogin();
            menuLogin.Show();
            this.Close();

        }

        private void lblClose2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmRegistro1_Load(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            frmRegistro frm = new frmRegistro();
            frm.Enabled = true;

        }






        private Form frmAtivo;

        private void btnBusca_Click(object sender, EventArgs e)
        {
            ActiveButton(btnBusca);

            FormShow(new frmBusca());
        }

        private void FormShow(Form frm)
        {
            ActiveFormClose();
            frmAtivo = frm;
            frm.TopLevel = false;
            pnForm.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }

        private void ActiveFormClose()
        {
            if (frmAtivo != null)
                frmAtivo.Close();
        }

        private void ActiveButton(Button frmAtivo)
        {
            foreach (Control ctrl in pnMenu.Controls)
                ctrl.ForeColor = Color.White;

            frmAtivo.ForeColor = Color.Aquamarine;
        }

        private void btnRegistrar_Click_1(object sender, EventArgs e)
        {
            ActiveButton(btnRegistrar);
            ActiveFormClose();
        }

        private void btnBusca_Click_1(object sender, EventArgs e)
        {

            ActiveButton(btnBusca);
            FormShow(new frmBusca());
        }

        private void frmRegistro1_Load_1(object sender, EventArgs e)
        {
            

        }

        private void btnHoras_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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

        private void meusDadosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void meuPontoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPontos ponto = new frmPontos();
            ponto.Show();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {



            
        }

        private void btnSair_Click_1(object sender, EventArgs e)
        {
            this.Close();
            frmTeste
            teste.Hide();
        }

        private void frmRegistro2_Load(object sender, EventArgs e)
        {
            btnRest.Hide();
        }
    }
}
