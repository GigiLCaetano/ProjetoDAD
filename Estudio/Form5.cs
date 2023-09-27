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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Modalidade modalidade = new Modalidade (txtDescricaoMod.Text, float.Parse(txtPrecoMod.Text), int.Parse(txtQtdAlunos.Text), int.Parse(txtQtdeAulas.Text));

            if (modalidade.cadastrarModalidade())
                MessageBox.Show("Modalidade cadastrada com sucesso");
            else
                MessageBox.Show("Erro no cadastro");
        }

        private void grbModalidades_Enter(object sender, EventArgs e)
        {

        }
    }
}
