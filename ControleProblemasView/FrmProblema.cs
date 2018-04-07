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
    public partial class FrmProblema : Form
    {
        public FrmProblema()
        {
            InitializeComponent();            
        }

       


        private void btnSalvarnivel_Click(object sender, EventArgs e)
        {
           if (String.IsNullOrWhiteSpace( txtDescricao.Text)) {
                MessageBox.Show("Informe a descrição!");
                return;
            }

            if (cbxTipo.SelectedIndex < 0)
            {
                MessageBox.Show("Selecione o tipo!");
                return;
            }

            if (cbxNivel.SelectedIndex < 0) {
                MessageBox.Show("Selecione o nível");
                return;
            }
            

            Problema problemaObj = new Problema();
            problemaObj.DataCriacao = Convert.ToDateTime(txtDataCriacaoProblema.Text);
            problemaObj.Descricao = txtDescricao.Text;
            problemaObj.Tipo = new Tipo() { Id = Convert.ToInt32(cbxTipo.SelectedValue), Descricao = cbxTipo.SelectedText };
            problemaObj.NivelDificuldade = new Nivel() { Id = Convert.ToInt32(cbxNivel.SelectedValue), Descricao = cbxNivel.SelectedText };

            if (new ProblemaDB().insert(problemaObj))
            {
                MessageBox.Show("Registro inserido");
            }
            else
            {
                MessageBox.Show("Erro ao inserir registro");
            }

            Dispose();
        }

        private void FrmProblema_Load(object sender, EventArgs e)
        {
            txtDataCriacaoProblema.Text = DateTime.Now.ToShortDateString();

            DataTable dtSource = new DataTable();
            dtSource.Columns.Add("ID", typeof(Int32));
            dtSource.Columns.Add("Descricao", typeof(string));

            List<Tipo> lstTipo = new TipoDB().ListarTipo();

            for (int i = 0; i < lstTipo.Count; i++)
            {
                dtSource.NewRow();
                DataRow dRow = dtSource.NewRow();
                dRow["ID"] = lstTipo[i].Id;
                dRow["Descricao"] = lstTipo[i].Descricao;

                dtSource.Rows.Add(dRow);
            }

            cbxTipo.DataSource = dtSource;
            cbxTipo.DisplayMember = "Descricao";
            cbxTipo.ValueMember = "ID";

            // ------ novo datasource
            dtSource = new DataTable();
            dtSource.Columns.Add("IDnivel", typeof(Int32));
            dtSource.Columns.Add("Descricao_Nivel", typeof(string));

            List<Nivel> lstNivel = new NivelDB().ListarNivel();

            for (int i = 0; i < lstNivel.Count; i++)
            {
                dtSource.NewRow();
                DataRow dRow = dtSource.NewRow();
                dRow["IDnivel"] = lstNivel[i].Id;
                dRow["Descricao_Nivel"] = lstNivel[i].Descricao;

                dtSource.Rows.Add(dRow);
            }

            cbxNivel.DataSource = dtSource;
            cbxNivel.DisplayMember = "Descricao_Nivel";
            cbxNivel.ValueMember = "IDnivel";

        }
    }
}
