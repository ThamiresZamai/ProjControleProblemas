using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
            nivel.Id = Convert.ToInt32(txtIDnivel.Text);
            nivel.Descricao = txtDescricaonivel.Text;

            FrmPrincipal.lstNivel.Add(nivel);

            MessageBox.Show("Nivel salvo:"+ nivel);
            Dispose();
        }
    }
}
