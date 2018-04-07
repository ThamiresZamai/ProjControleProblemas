namespace ControleProblemasView
{
    partial class FrmNível
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
            this.txtDescricaonivel = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.txtIDnivel = new System.Windows.Forms.TextBox();
            this.btnSalvarnivel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(36, 113);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(55, 13);
            this.lblDescricao.TabIndex = 9;
            this.lblDescricao.Text = "Descrição";
            // 
            // txtDescricaonivel
            // 
            this.txtDescricaonivel.Location = new System.Drawing.Point(39, 129);
            this.txtDescricaonivel.Name = "txtDescricaonivel";
            this.txtDescricaonivel.Size = new System.Drawing.Size(210, 20);
            this.txtDescricaonivel.TabIndex = 8;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(36, 56);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(18, 13);
            this.lblID.TabIndex = 7;
            this.lblID.Text = "ID";
            // 
            // txtIDnivel
            // 
            this.txtIDnivel.Location = new System.Drawing.Point(39, 72);
            this.txtIDnivel.Name = "txtIDnivel";
            this.txtIDnivel.Size = new System.Drawing.Size(210, 20);
            this.txtIDnivel.TabIndex = 6;
            // 
            // btnSalvarnivel
            // 
            this.btnSalvarnivel.Location = new System.Drawing.Point(174, 182);
            this.btnSalvarnivel.Name = "btnSalvarnivel";
            this.btnSalvarnivel.Size = new System.Drawing.Size(75, 23);
            this.btnSalvarnivel.TabIndex = 5;
            this.btnSalvarnivel.Text = "Salvar";
            this.btnSalvarnivel.UseVisualStyleBackColor = true;
            this.btnSalvarnivel.Click += new System.EventHandler(this.btnSalvarnivel_Click);
            // 
            // FrmNível
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.txtDescricaonivel);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.txtIDnivel);
            this.Controls.Add(this.btnSalvarnivel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmNível";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmNível";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.TextBox txtDescricaonivel;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtIDnivel;
        private System.Windows.Forms.Button btnSalvarnivel;
    }
}