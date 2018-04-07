using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controle;
using Entidade;

namespace ControleProblemasView
{
    public partial class FrmNível : Form
    {
        public FrmNível()
        {
            InitializeComponent();
        }

        private void btnSalvarnivel_Click(object sender, EventArgs e)
        {
            Nivel nivel = new Nivel();
            nivel.Descricao = txtDescricaonivel.Text;

            // FrmPrincipal.lstNivel.Add(nivel);

            if (new NivelDB().insert(nivel))
            {
                MessageBox.Show("Registro inserido");
            }
            else
            {
                MessageBox.Show("Erro ao inserir registro");
            }
            Dispose();
        }
    }
}
