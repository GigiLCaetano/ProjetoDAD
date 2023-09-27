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
    }
}
