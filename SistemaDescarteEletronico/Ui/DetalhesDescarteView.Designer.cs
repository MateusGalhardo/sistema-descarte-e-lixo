namespace SistemaDescarteEletronico
{
    partial class DetalhesDescarteView
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.layout = new System.Windows.Forms.TableLayoutPanel();
            this.pnlResultado = new System.Windows.Forms.Panel();
            this.lblDestino = new System.Windows.Forms.Label();
            this.lblPontos = new System.Windows.Forms.Label();
            this.barra = new SistemaDescarteEletronico.BarraProgresso();
            this.lblMensagem = new System.Windows.Forms.Label();
            this.pnlInfo = new System.Windows.Forms.Panel();
            this.lblVazio = new System.Windows.Forms.Label();
            this.layout.SuspendLayout();
            this.pnlResultado.SuspendLayout();
            this.SuspendLayout();
            // 
            // layout
            // 
            this.layout.ColumnCount = 1;
            this.layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layout.Controls.Add(this.pnlResultado, 0, 0);
            this.layout.Controls.Add(this.pnlInfo, 0, 1);
            this.layout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layout.Location = new System.Drawing.Point(0, 0);
            this.layout.Margin = new System.Windows.Forms.Padding(0);
            this.layout.Name = "layout";
            this.layout.RowCount = 2;
            this.layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layout.Size = new System.Drawing.Size(384, 572);
            this.layout.TabIndex = 0;
            // 
            // pnlResultado
            // 
            this.pnlResultado.Controls.Add(this.lblDestino);
            this.pnlResultado.Controls.Add(this.lblPontos);
            this.pnlResultado.Controls.Add(this.barra);
            this.pnlResultado.Controls.Add(this.lblMensagem);
            this.pnlResultado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlResultado.Location = new System.Drawing.Point(0, 0);
            this.pnlResultado.Margin = new System.Windows.Forms.Padding(0);
            this.pnlResultado.Name = "pnlResultado";
            this.pnlResultado.Size = new System.Drawing.Size(384, 200);
            this.pnlResultado.TabIndex = 0;
            this.pnlResultado.Resize += new System.EventHandler(this.pnlResultado_Resize);
            // 
            // lblDestino
            // 
            this.lblDestino.AutoSize = true;
            this.lblDestino.BackColor = System.Drawing.Color.Transparent;
            this.lblDestino.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDestino.ForeColor = System.Drawing.Color.FromArgb(27, 38, 49);
            this.lblDestino.Location = new System.Drawing.Point(24, 18);
            this.lblDestino.Name = "lblDestino";
            this.lblDestino.Size = new System.Drawing.Size(140, 32);
            this.lblDestino.TabIndex = 0;
            this.lblDestino.Text = "● DESTINO";
            // 
            // lblPontos
            // 
            this.lblPontos.AutoSize = true;
            this.lblPontos.BackColor = System.Drawing.Color.Transparent;
            this.lblPontos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPontos.ForeColor = System.Drawing.Color.FromArgb(27, 38, 49);
            this.lblPontos.Location = new System.Drawing.Point(26, 58);
            this.lblPontos.Name = "lblPontos";
            this.lblPontos.Size = new System.Drawing.Size(118, 21);
            this.lblPontos.TabIndex = 1;
            this.lblPontos.Text = "0 / 100 pontos";
            // 
            // barra
            // 
            this.barra.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.barra.Location = new System.Drawing.Point(26, 94);
            this.barra.Name = "barra";
            this.barra.Size = new System.Drawing.Size(332, 12);
            this.barra.TabIndex = 2;
            // 
            // lblMensagem
            // 
            this.lblMensagem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMensagem.BackColor = System.Drawing.Color.Transparent;
            this.lblMensagem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensagem.ForeColor = System.Drawing.Color.FromArgb(27, 38, 49);
            this.lblMensagem.Location = new System.Drawing.Point(26, 120);
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(332, 66);
            this.lblMensagem.TabIndex = 3;
            // 
            // pnlInfo
            // 
            this.pnlInfo.AutoScroll = true;
            this.pnlInfo.BackColor = System.Drawing.Color.White;
            this.pnlInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlInfo.Location = new System.Drawing.Point(0, 200);
            this.pnlInfo.Margin = new System.Windows.Forms.Padding(0);
            this.pnlInfo.Name = "pnlInfo";
            this.pnlInfo.Size = new System.Drawing.Size(384, 372);
            this.pnlInfo.TabIndex = 1;
            this.pnlInfo.Resize += new System.EventHandler(this.pnlInfo_Resize);
            // 
            // lblVazio
            // 
            this.lblVazio.BackColor = System.Drawing.Color.White;
            this.lblVazio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblVazio.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVazio.ForeColor = System.Drawing.Color.FromArgb(106, 120, 133);
            this.lblVazio.Location = new System.Drawing.Point(0, 0);
            this.lblVazio.Name = "lblVazio";
            this.lblVazio.Size = new System.Drawing.Size(384, 572);
            this.lblVazio.TabIndex = 1;
            this.lblVazio.Text = "Selecione um descarte\r\npara ver os detalhes.";
            this.lblVazio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DetalhesDescarteView
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.layout);
            this.Controls.Add(this.lblVazio);
            this.Name = "DetalhesDescarteView";
            this.Size = new System.Drawing.Size(384, 572);
            this.layout.ResumeLayout(false);
            this.pnlResultado.ResumeLayout(false);
            this.pnlResultado.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel layout;
        private System.Windows.Forms.Panel pnlResultado;
        private System.Windows.Forms.Label lblDestino;
        private System.Windows.Forms.Label lblPontos;
        private BarraProgresso barra;
        private System.Windows.Forms.Label lblMensagem;
        private System.Windows.Forms.Panel pnlInfo;
        private System.Windows.Forms.Label lblVazio;
    }
}
