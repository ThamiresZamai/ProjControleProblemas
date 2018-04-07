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
    public partial class FrmTipo : Form
    {
        public FrmTipo()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Tipo tipo = new Tipo();
           // tipo.Id = Convert.ToInt32(txtID.Text);
            tipo.Descricao = txtDescricao.Text;

            //FrmPrincipal.lstTipo.Add(tipo);
            //

            if (new TipoDB().insert(tipo))
            {
                MessageBox.Show("Registro inserido");
            }
            else {
                MessageBox.Show("Erro ao inserir registro");
            }
            Dispose();


        }

        private void FrmTipo_Load(object sender, EventArgs e)
        {

        }
    }
}
