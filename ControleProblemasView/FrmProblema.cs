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
    public partial class FrmProblema : Form
    {
        public FrmProblema()
        {
            InitializeComponent();            
        }

        Problema prob = new Problema();


        private void btnSalvarnivel_Click(object sender, EventArgs e)
        {
            //faça a validação para informar todos os campos antes de salvar o problema na lista.
            //Validei o Id(textbox) e o combo de tipo(Combo), valide o restante.

            if (txtID.Text == null)
            {
                MessageBox.Show("Informe o ID!");
                return;
            }

            if (txtDescricao.Text == null) {
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
            problemaObj.Id = Convert.ToInt32(txtID.Text);
            problemaObj.Descricao = txtDescricao.Text;
            problemaObj.Tipo = new Tipo() { Id = Convert.ToInt32(cbxTipo.SelectedValue), Descricao = cbxTipo.SelectedText };
            problemaObj.NivelDificuldade = new Nivel() { Id = Convert.ToInt32(cbxNivel.SelectedValue), Descricao = cbxNivel.SelectedText };
            FrmPrincipal.lstProblema.Add(problemaObj);

            MessageBox.Show("Problema inserido no sistema!");
            Dispose();
        }

        private void FrmProblema_Load(object sender, EventArgs e)
        {
            txtDataCriacaoProblema.Text = DateTime.Now.ToShortDateString();

            DataTable dtSource = new DataTable();
            dtSource.Columns.Add("ID", typeof(Int32));
            dtSource.Columns.Add("Descricao", typeof(string));
            for (int i = 0; i < FrmPrincipal.lstTipo.Count; i++)
            {
                dtSource.NewRow();
                DataRow dRow = dtSource.NewRow();
                dRow["ID"] = FrmPrincipal.lstTipo[i].Id;
                dRow["Descricao"] = FrmPrincipal.lstTipo[i].Descricao;

                dtSource.Rows.Add(dRow);
            }

            cbxTipo.DataSource = dtSource;
            cbxTipo.DisplayMember = "Descricao";
            cbxTipo.ValueMember = "ID";

            // ------ novo datasource
            dtSource = new DataTable();
            dtSource.Columns.Add("IDnivel", typeof(Int32));
            dtSource.Columns.Add("Descricao_Nivel", typeof(string));
            for (int i = 0; i < FrmPrincipal.lstNivel.Count; i++)
            {
                dtSource.NewRow();
                DataRow dRow = dtSource.NewRow();
                dRow["IDnivel"] = FrmPrincipal.lstNivel[i].Id;
                dRow["Descricao_Nivel"] = FrmPrincipal.lstNivel[i].Descricao;

                dtSource.Rows.Add(dRow);
            }

            cbxNivel.DataSource = dtSource;
            cbxNivel.DisplayMember = "Descricao_Nivel";
            cbxNivel.ValueMember = "IDnivel";

        }
    }
}
