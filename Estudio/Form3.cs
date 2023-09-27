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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnAtua_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void btnCad_Click(object sender, EventArgs e)
        {
            Aluno aluno = new Aluno(txtCPF.Text, txtNome.Text, txtEnd.Text, txtNumero.Text, txtBairro.Text,
                txtCompl.Text, txtCEP.Text, txtCidade.Text, txtEstado.Text, txtTel.Text, txtEmail.Text);

            if (aluno.cadastrarAluno())
                MessageBox.Show("Aluno cadastrado com sucesso");
            else
                MessageBox.Show("Erro no cadastro");

        }

        private void txtCPF_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
           

        }

        private void txtCPF_KeyPress(object sender, KeyPressEventArgs e)
        {
            Aluno aluno = new Aluno(txtCPF.Text);
            if (e.KeyChar == 13)
            {
                if (aluno.consultarAluno())
                {
                    MessageBox.Show("Aluno já cadastrado");
                }
                else
                {
                    txtNome.Focus();
                }
                DAO_Conexao.con.Close();
            }
        }

        private void btnAtua_Click(object sender, EventArgs e)
        {
            Aluno aluno = new Aluno(txtNome.Text, txtEnd.Text, txtNumero.Text, txtBairro.Text,
                txtCompl.Text, txtCEP.Text, txtCidade.Text, txtEstado.Text, txtTel.Text, txtEmail.Text);

            if (aluno.atualizarAluno())
                MessageBox.Show("Aluno atualizado com sucesso");
            else
                MessageBox.Show("Erro no cadastro");
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
