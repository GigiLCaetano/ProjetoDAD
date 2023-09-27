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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void grpbModalidades_Enter(object sender, EventArgs e)
        {

        }

        private void btnExcluirMod_Click(object sender, EventArgs e)
        {
            try
            {
                Modalidade m = new Modalidade(cmbDescricaoMod.SelectedItem.ToString());
                if (m.excluirModalidade()) ;
                {
                    cmbDescricaoMod.Text = "";
                    MessageBox.Show("Modalidade excluída com sucesso");
                }
            } catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
