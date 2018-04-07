namespace ControleProblemasView
{
    partial class FrmPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.principalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroTipoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroNívelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroProblemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.principalToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(585, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // principalToolStripMenuItem
            // 
            this.principalToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroTipoToolStripMenuItem,
            this.cadastroNívelToolStripMenuItem,
            this.cadastroProblemaToolStripMenuItem});
            this.principalToolStripMenuItem.Name = "principalToolStripMenuItem";
            this.principalToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.principalToolStripMenuItem.Text = "Principal";
            // 
            // cadastroTipoToolStripMenuItem
            // 
            this.cadastroTipoToolStripMenuItem.Name = "cadastroTipoToolStripMenuItem";
            this.cadastroTipoToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.cadastroTipoToolStripMenuItem.Text = "Cadastro tipo";
            this.cadastroTipoToolStripMenuItem.Click += new System.EventHandler(this.cadastroTipoToolStripMenuItem_Click);
            // 
            // cadastroNívelToolStripMenuItem
            // 
            this.cadastroNívelToolStripMenuItem.Name = "cadastroNívelToolStripMenuItem";
            this.cadastroNívelToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.cadastroNívelToolStripMenuItem.Text = "Cadastro nível";
            this.cadastroNívelToolStripMenuItem.Click += new System.EventHandler(this.cadastroNívelToolStripMenuItem_Click);
            // 
            // cadastroProblemaToolStripMenuItem
            // 
            this.cadastroProblemaToolStripMenuItem.Name = "cadastroProblemaToolStripMenuItem";
            this.cadastroProblemaToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.cadastroProblemaToolStripMenuItem.Text = "Cadastro problema";
            this.cadastroProblemaToolStripMenuItem.Click += new System.EventHandler(this.cadastroProblemaToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 39);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(556, 150);
            this.dataGridView1.TabIndex = 1;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 217);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPrincipal";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem principalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroTipoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroNívelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroProblemaToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}