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
    public partial class FrmPrincipal : Form
    {

       

        public FrmPrincipal()
        {
            InitializeComponent();

        }


        private void cadastroTipoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmTipo().Show();
        }

        private void cadastroNívelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmNível().Show();
        }

        private void cadastroProblemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProblema frmProblema = new FrmProblema();
            frmProblema.Disposed += FrmProblema_Disposed;
            frmProblema.Show();            
        }

        private void FrmProblema_Disposed(object sender, EventArgs e)
        {
            carregaGrid();
        }

        private void carregaGrid()
        {
            dataGridView1.DataSource = new ProblemaDB().ListarProblema();
            
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            carregaGrid();
            try
            {
                dataGridView1.Columns[0].Visible = false;
                
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
