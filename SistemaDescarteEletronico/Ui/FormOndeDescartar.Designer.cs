namespace SistemaDescarteEletronico
{
    partial class FormOndeDescartar
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
            this.pnlTopo = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblSubtitulo = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.gridPontos = new System.Windows.Forms.DataGridView();
            this.lblVazio = new System.Windows.Forms.Label();
            this.lblDica = new System.Windows.Forms.Label();
            this.pnlRodape = new System.Windows.Forms.Panel();
            this.btnFechar = new SistemaDescarteEletronico.BotaoAcao();
            this.pnlTopo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridPontos)).BeginInit();
            this.pnlRodape.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTopo
            // 
            this.pnlTopo.BackColor = System.Drawing.Color.FromArgb(0, 151, 167);
            this.pnlTopo.Controls.Add(this.lblTitulo);
            this.pnlTopo.Controls.Add(this.lblSubtitulo);
            this.pnlTopo.Location = new System.Drawing.Point(0, 0);
            this.pnlTopo.Name = "pnlTopo";
            this.pnlTopo.Size = new System.Drawing.Size(780, 92);
            this.pnlTopo.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(36, 14);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(166, 32);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Onde descartar";
            // 
            // lblSubtitulo
            // 
            this.lblSubtitulo.AutoEllipsis = true;
            this.lblSubtitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblSubtitulo.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtitulo.ForeColor = System.Drawing.Color.White;
            this.lblSubtitulo.Location = new System.Drawing.Point(38, 54);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Size = new System.Drawing.Size(700, 22);
            this.lblSubtitulo.TabIndex = 1;
            this.lblSubtitulo.Text = "Equipamento";
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.BackColor = System.Drawing.Color.Transparent;
            this.lblInfo.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.ForeColor = System.Drawing.Color.FromArgb(106, 120, 133);
            this.lblInfo.Location = new System.Drawing.Point(36, 108);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(208, 19);
            this.lblInfo.TabIndex = 1;
            this.lblInfo.Text = "Onde levar este equipamento:";
            // 
            // gridPontos
            // 
            this.gridPontos.Location = new System.Drawing.Point(36, 136);
            this.gridPontos.Name = "gridPontos";
            this.gridPontos.Size = new System.Drawing.Size(708, 300);
            this.gridPontos.TabIndex = 2;
            // 
            // lblVazio
            // 
            this.lblVazio.BackColor = System.Drawing.Color.White;
            this.lblVazio.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVazio.ForeColor = System.Drawing.Color.FromArgb(106, 120, 133);
            this.lblVazio.Location = new System.Drawing.Point(36, 136);
            this.lblVazio.Name = "lblVazio";
            this.lblVazio.Size = new System.Drawing.Size(708, 300);
            this.lblVazio.TabIndex = 3;
            this.lblVazio.Text = "Nenhum ponto de coleta cadastrado aceita este tipo de equipamento ainda.\r\nCadastre " +
    "um em \"Gerenciar pontos de coleta\".";
            this.lblVazio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblVazio.Visible = false;
            // 
            // lblDica
            // 
            this.lblDica.BackColor = System.Drawing.Color.Transparent;
            this.lblDica.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDica.ForeColor = System.Drawing.Color.FromArgb(106, 120, 133);
            this.lblDica.Location = new System.Drawing.Point(36, 448);
            this.lblDica.Name = "lblDica";
            this.lblDica.Size = new System.Drawing.Size(708, 44);
            this.lblDica.TabIndex = 4;
            this.lblDica.Text = "Dica";
            // 
            // pnlRodape
            // 
            this.pnlRodape.BackColor = System.Drawing.Color.FromArgb(243, 246, 249);
            this.pnlRodape.Controls.Add(this.btnFechar);
            this.pnlRodape.Location = new System.Drawing.Point(0, 504);
            this.pnlRodape.Name = "pnlRodape";
            this.pnlRodape.Size = new System.Drawing.Size(780, 76);
            this.pnlRodape.TabIndex = 5;
            // 
            // btnFechar
            // 
            this.btnFechar.BackColor = System.Drawing.Color.FromArgb(0, 151, 167);
            this.btnFechar.Cor = System.Drawing.Color.FromArgb(0, 151, 167);
            this.btnFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFechar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Location = new System.Drawing.Point(624, 19);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(120, 38);
            this.btnFechar.TabIndex = 0;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = false;
            // 
            // FormOndeDescartar
            // 
            this.AcceptButton = this.btnFechar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnFechar;
            this.ClientSize = new System.Drawing.Size(780, 580);
            this.Controls.Add(this.pnlRodape);
            this.Controls.Add(this.lblDica);
            this.Controls.Add(this.lblVazio);
            this.Controls.Add(this.gridPontos);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.pnlTopo);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormOndeDescartar";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Onde descartar";
            this.pnlTopo.ResumeLayout(false);
            this.pnlTopo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridPontos)).EndInit();
            this.pnlRodape.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTopo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.DataGridView gridPontos;
        private System.Windows.Forms.Label lblVazio;
        private System.Windows.Forms.Label lblDica;
        private System.Windows.Forms.Panel pnlRodape;
        private BotaoAcao btnFechar;
    }
}
