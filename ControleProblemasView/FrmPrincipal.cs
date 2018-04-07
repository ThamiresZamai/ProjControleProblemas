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
    public partial class FrmPrincipal : Form
    {

        public static List<Tipo> lstTipo { get; set; }
        public static List<Nivel> lstNivel { get; set; }
        public static List<Problema> lstProblema { get; set; }

        public FrmPrincipal()
        {
            InitializeComponent();

            if (lstTipo == null)
                lstTipo = new List<Tipo>();

            if (lstNivel == null)
                lstNivel = new List<Nivel>();

            if(lstProblema == null)
            {
                lstProblema = new List<Problema>();
            }
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
            dataGridView1.DataSource = lstProblema;
        }
    }
}
