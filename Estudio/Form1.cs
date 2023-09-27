using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estudio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            menuStrip1.Enabled = false;

            if (DAO_Conexao.getConexao("143.106.241.3", "cl202226", "cl202226", "fredzaradom")) 
                Console.WriteLine("Conectado");
            else
                Console.WriteLine("Erro de conexão");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int tipo = DAO_Conexao.login(textBox1.Text, textBox2.Text);
            if (tipo == 0)
            {
                MessageBox.Show("Usuário ou senha invalidos");
            }
            if(tipo==1)
            {
                groupBox1.Visible = false;
                menuStrip1.Enabled = true;
            }
            if(tipo==2)
            {
                groupBox1.Visible = false;
                menuStrip1.Enabled = true;
                cadastrarLoginToolStripMenuItem.Enabled = false;
            }


        }

        private void cadastrarAlunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.MdiParent = this;
            form3.Show();
            groupBox1.Visible = false;
        }

        private void cadastrarLoginToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            Form2 form2 = new Form2();
            form2.MdiParent = this;
            form2.Show();
            groupBox1.Visible = false;
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void arquivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void excluirAlunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.MdiParent = this;
            form4.Show();
            groupBox1.Visible = false;
        }

        private void sairToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cadastrarModalidadeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.MdiParent = this;
            form5.Show();
            groupBox1.Visible = false;
        }

        private void atualizarModalidadeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormConsultar form7 = new FormConsultar();
            form7.MdiParent = this;
            form7.Show();
            groupBox1.Visible = false;
        }

        private void excluirModalidadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();
            form6.MdiParent = this;
            form6.Show();
            groupBox1.Visible = false;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void consultarModalidadeToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
    }
}
