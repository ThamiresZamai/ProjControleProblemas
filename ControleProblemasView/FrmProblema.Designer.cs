﻿namespace ControleProblemasView
{
    partial class FrmProblema
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblDescricao = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.cbxTipo = new System.Windows.Forms.ComboBox();
            this.cbxNivel = new System.Windows.Forms.ComboBox();
            this.txtDataCriacaoProblema = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(36, 113);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(55, 13);
            this.lblDescricao.TabIndex = 14;
            this.lblDescricao.Text = "Descrição";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(39, 129);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(210, 20);
            this.txtDescricao.TabIndex = 13;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(36, 63);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(18, 13);
            this.lblID.TabIndex = 12;
            this.lblID.Text = "ID";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(39, 79);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(210, 20);
            this.txtID.TabIndex = 11;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(197, 284);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 10;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvarnivel_Click);
            // 
            // cbxTipo
            // 
            this.cbxTipo.FormattingEnabled = true;
            this.cbxTipo.Location = new System.Drawing.Point(39, 185);
            this.cbxTipo.Name = "cbxTipo";
            this.cbxTipo.Size = new System.Drawing.Size(210, 21);
            this.cbxTipo.TabIndex = 15;
            // 
            // cbxNivel
            // 
            this.cbxNivel.FormattingEnabled = true;
            this.cbxNivel.Location = new System.Drawing.Point(39, 236);
            this.cbxNivel.Name = "cbxNivel";
            this.cbxNivel.Size = new System.Drawing.Size(210, 21);
            this.cbxNivel.TabIndex = 16;
            // 
            // txtDataCriacaoProblema
            // 
            this.txtDataCriacaoProblema.Location = new System.Drawing.Point(39, 25);
            this.txtDataCriacaoProblema.Name = "txtDataCriacaoProblema";
            this.txtDataCriacaoProblema.Size = new System.Drawing.Size(100, 20);
            this.txtDataCriacaoProblema.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Data de Criação do Problema";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Tipo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Nível";
            // 
            // FrmProblema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 319);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDataCriacaoProblema);
            this.Controls.Add(this.cbxNivel);
            this.Controls.Add(this.cbxTipo);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.btnSalvar);
            this.Name = "FrmProblema";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmProblema";
            this.Load += new System.EventHandler(this.FrmProblema_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.ComboBox cbxTipo;
        private System.Windows.Forms.ComboBox cbxNivel;
        private System.Windows.Forms.TextBox txtDataCriacaoProblema;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}