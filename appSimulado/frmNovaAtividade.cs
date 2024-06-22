using appSimulado.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appSimulado
{
    public partial class frmNovaAtividade : Form
    {
        public frmNovaAtividade(string id_turma)
        {
            InitializeComponent();
            lblIdTurma.Text = id_turma;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            ControllerAtividade atv = new ControllerAtividade();
            if (atv.RegistroRepetido(txtNome.Text) == false)
            {
                atv.Inserir(txtNome.Text, Convert.ToInt32(lblIdTurma.Text));
                MessageBox.Show("Atividade cadastrada com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNome.Text = "";
            }
            else
            {
                MessageBox.Show("Atividade já cadastrada no sistema! Por Favor verifique!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNome.Text = "";
            }
            
        }
    }
}
