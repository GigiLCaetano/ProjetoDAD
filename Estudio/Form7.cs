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
    public partial class FormConsultar : Form
    {
        public FormConsultar()
        {
            InitializeComponent();
            Modalidade modalidade = new Modalidade();
            MySqlDataReader resultado = modalidade.consultarTodasModalidade();

            while (resultado.Read())
                cmbDescricao.Items.Add(resultado["descricaoModalidade"].ToString());

            DAO_Conexao.con.Close();

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            Modalidade modalidade = new Modalidade(cmbDescricao.Text, float.Parse(txtPreco.Text), int.Parse(txtQtdeAlunos.Text), int.Parse(txtQtdeAulas.Text));

            if (modalidade.atualizarModalidade())
                MessageBox.Show("Modalidade atualizada com sucesso");
            else
                MessageBox.Show("Erro");
        }

        private void grpbModalidades_Enter(object sender, EventArgs e)
        {

        }

        private void btnConsultarMod_Click(object sender, EventArgs e)
        {

        }

        private void FormConsultar_Load(object sender, EventArgs e)
        {

        }
    }
}
