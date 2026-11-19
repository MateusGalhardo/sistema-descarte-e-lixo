namespace SistemaDescarteEletronico
{
    partial class FormPrincipal
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
            this.layoutPrincipal = new System.Windows.Forms.TableLayoutPanel();
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.lblIcone = new System.Windows.Forms.Label();
            this.lblTitulo1 = new System.Windows.Forms.Label();
            this.lblTitulo2 = new System.Windows.Forms.Label();
            this.lblEquipe = new System.Windows.Forms.Label();
            this.lblSecDescarte = new System.Windows.Forms.Label();
            this.lblSecPontos = new System.Windows.Forms.Label();
            this.btnInicio = new SistemaDescarteEletronico.BotaoMenu();
            this.btnDescarte = new SistemaDescarteEletronico.BotaoMenu();
            this.btnHistorico = new SistemaDescarteEletronico.BotaoMenu();
            this.btnPontos = new SistemaDescarteEletronico.BotaoMenu();
            this.btnCreditos = new SistemaDescarteEletronico.BotaoMenu();
            this.btnSair = new SistemaDescarteEletronico.BotaoMenu();
            this.pnlConteudo = new System.Windows.Forms.Panel();
            this.painelInicio = new SistemaDescarteEletronico.PainelInicio();
            this.painelDescartes = new SistemaDescarteEletronico.PainelDescartes();
            this.painelPontos = new SistemaDescarteEletronico.PainelPontos();
            this.layoutPrincipal.SuspendLayout();
            this.pnlSidebar.SuspendLayout();
            this.pnlConteudo.SuspendLayout();
            this.SuspendLayout();
            // 
            // layoutPrincipal
            // 
            this.layoutPrincipal.ColumnCount = 2;
            this.layoutPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 250F));
            this.layoutPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layoutPrincipal.Controls.Add(this.pnlSidebar, 0, 0);
            this.layoutPrincipal.Controls.Add(this.pnlConteudo, 1, 0);
            this.layoutPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutPrincipal.Location = new System.Drawing.Point(0, 0);
            this.layoutPrincipal.Margin = new System.Windows.Forms.Padding(0);
            this.layoutPrincipal.Name = "layoutPrincipal";
            this.layoutPrincipal.RowCount = 1;
            this.layoutPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layoutPrincipal.Size = new System.Drawing.Size(1240, 760);
            this.layoutPrincipal.TabIndex = 0;
            // 
            // pnlSidebar
            // 
            this.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(27, 38, 49);
            this.pnlSidebar.Controls.Add(this.lblIcone);
            this.pnlSidebar.Controls.Add(this.lblTitulo1);
            this.pnlSidebar.Controls.Add(this.lblTitulo2);
            this.pnlSidebar.Controls.Add(this.lblEquipe);
            this.pnlSidebar.Controls.Add(this.lblSecDescarte);
            this.pnlSidebar.Controls.Add(this.lblSecPontos);
            this.pnlSidebar.Controls.Add(this.btnInicio);
            this.pnlSidebar.Controls.Add(this.btnDescarte);
            this.pnlSidebar.Controls.Add(this.btnHistorico);
            this.pnlSidebar.Controls.Add(this.btnPontos);
            this.pnlSidebar.Controls.Add(this.btnCreditos);
            this.pnlSidebar.Controls.Add(this.btnSair);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSidebar.Location = new System.Drawing.Point(0, 0);
            this.pnlSidebar.Margin = new System.Windows.Forms.Padding(0);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(250, 760);
            this.pnlSidebar.TabIndex = 0;
            // 
            // lblIcone
            // 
            this.lblIcone.AutoSize = true;
            this.lblIcone.BackColor = System.Drawing.Color.Transparent;
            this.lblIcone.Font = new System.Drawing.Font("Segoe UI Symbol", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIcone.ForeColor = System.Drawing.Color.FromArgb(39, 160, 94);
            this.lblIcone.Location = new System.Drawing.Point(22, 20);
            this.lblIcone.Name = "lblIcone";
            this.lblIcone.Size = new System.Drawing.Size(61, 54);
            this.lblIcone.TabIndex = 0;
            this.lblIcone.Text = "♻";
            // 
            // lblTitulo1
            // 
            this.lblTitulo1.AutoSize = true;
            this.lblTitulo1.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo1.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo1.ForeColor = System.Drawing.Color.White;
            this.lblTitulo1.Location = new System.Drawing.Point(24, 82);
            this.lblTitulo1.Name = "lblTitulo1";
            this.lblTitulo1.Size = new System.Drawing.Size(105, 25);
            this.lblTitulo1.TabIndex = 1;
            this.lblTitulo1.Text = "SISTEMA DE";
            // 
            // lblTitulo2
            // 
            this.lblTitulo2.AutoSize = true;
            this.lblTitulo2.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo2.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo2.ForeColor = System.Drawing.Color.FromArgb(0, 151, 167);
            this.lblTitulo2.Location = new System.Drawing.Point(24, 106);
            this.lblTitulo2.Name = "lblTitulo2";
            this.lblTitulo2.Size = new System.Drawing.Size(188, 25);
            this.lblTitulo2.TabIndex = 2;
            this.lblTitulo2.Text = "DESCARTE DE E-LIXO";
            // 
            // lblEquipe
            // 
            this.lblEquipe.AutoSize = true;
            this.lblEquipe.BackColor = System.Drawing.Color.Transparent;
            this.lblEquipe.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEquipe.ForeColor = System.Drawing.Color.FromArgb(130, 148, 163);
            this.lblEquipe.Location = new System.Drawing.Point(26, 136);
            this.lblEquipe.Name = "lblEquipe";
            this.lblEquipe.Size = new System.Drawing.Size(114, 15);
            this.lblEquipe.TabIndex = 3;
            this.lblEquipe.Text = "Equipe 10  •  2026";
            // 
            // lblSecDescarte
            // 
            this.lblSecDescarte.AutoSize = true;
            this.lblSecDescarte.BackColor = System.Drawing.Color.Transparent;
            this.lblSecDescarte.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecDescarte.ForeColor = System.Drawing.Color.FromArgb(110, 128, 144);
            this.lblSecDescarte.Location = new System.Drawing.Point(26, 262);
            this.lblSecDescarte.Name = "lblSecDescarte";
            this.lblSecDescarte.Size = new System.Drawing.Size(131, 15);
            this.lblSecDescarte.TabIndex = 4;
            this.lblSecDescarte.Text = "DESCARTE ELETRÔNICO";
            // 
            // lblSecPontos
            // 
            this.lblSecPontos.AutoSize = true;
            this.lblSecPontos.BackColor = System.Drawing.Color.Transparent;
            this.lblSecPontos.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecPontos.ForeColor = System.Drawing.Color.FromArgb(110, 128, 144);
            this.lblSecPontos.Location = new System.Drawing.Point(26, 412);
            this.lblSecPontos.Name = "lblSecPontos";
            this.lblSecPontos.Size = new System.Drawing.Size(115, 15);
            this.lblSecPontos.TabIndex = 5;
            this.lblSecPontos.Text = "PONTOS DE COLETA";
            // 
            // btnInicio
            // 
            this.btnInicio.Location = new System.Drawing.Point(0, 188);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(250, 46);
            this.btnInicio.TabIndex = 6;
            this.btnInicio.Text = "Início";
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // btnDescarte
            // 
            this.btnDescarte.Location = new System.Drawing.Point(0, 290);
            this.btnDescarte.Name = "btnDescarte";
            this.btnDescarte.Size = new System.Drawing.Size(250, 46);
            this.btnDescarte.TabIndex = 7;
            this.btnDescarte.Text = "Realizar descarte";
            this.btnDescarte.Click += new System.EventHandler(this.btnDescarte_Click);
            // 
            // btnHistorico
            // 
            this.btnHistorico.Location = new System.Drawing.Point(0, 336);
            this.btnHistorico.Name = "btnHistorico";
            this.btnHistorico.Size = new System.Drawing.Size(250, 46);
            this.btnHistorico.TabIndex = 8;
            this.btnHistorico.Text = "Histórico de descartes";
            this.btnHistorico.Click += new System.EventHandler(this.btnHistorico_Click);
            // 
            // btnPontos
            // 
            this.btnPontos.Location = new System.Drawing.Point(0, 440);
            this.btnPontos.Name = "btnPontos";
            this.btnPontos.Size = new System.Drawing.Size(250, 46);
            this.btnPontos.TabIndex = 9;
            this.btnPontos.Text = "Gerenciar pontos de coleta";
            this.btnPontos.Click += new System.EventHandler(this.btnPontos_Click);
            // 
            // btnCreditos
            // 
            this.btnCreditos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreditos.Location = new System.Drawing.Point(0, 652);
            this.btnCreditos.Name = "btnCreditos";
            this.btnCreditos.Size = new System.Drawing.Size(250, 46);
            this.btnCreditos.TabIndex = 11;
            this.btnCreditos.Text = "Créditos";
            this.btnCreditos.Click += new System.EventHandler(this.btnCreditos_Click);
            // 
            // btnSair
            // 
            this.btnSair.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSair.Location = new System.Drawing.Point(0, 698);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(250, 46);
            this.btnSair.TabIndex = 10;
            this.btnSair.Text = "Sair";
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // pnlConteudo
            // 
            this.pnlConteudo.BackColor = System.Drawing.Color.FromArgb(243, 246, 249);
            this.pnlConteudo.Controls.Add(this.painelPontos);
            this.pnlConteudo.Controls.Add(this.painelDescartes);
            this.pnlConteudo.Controls.Add(this.painelInicio);
            this.pnlConteudo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlConteudo.Location = new System.Drawing.Point(250, 0);
            this.pnlConteudo.Margin = new System.Windows.Forms.Padding(0);
            this.pnlConteudo.Name = "pnlConteudo";
            this.pnlConteudo.Padding = new System.Windows.Forms.Padding(36, 30, 36, 26);
            this.pnlConteudo.Size = new System.Drawing.Size(990, 760);
            this.pnlConteudo.TabIndex = 1;
            // 
            // painelInicio
            // 
            this.painelInicio.BackColor = System.Drawing.Color.FromArgb(243, 246, 249);
            this.painelInicio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.painelInicio.Location = new System.Drawing.Point(36, 30);
            this.painelInicio.Name = "painelInicio";
            this.painelInicio.Size = new System.Drawing.Size(918, 704);
            this.painelInicio.TabIndex = 0;
            // 
            // painelDescartes
            // 
            this.painelDescartes.BackColor = System.Drawing.Color.FromArgb(243, 246, 249);
            this.painelDescartes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.painelDescartes.Location = new System.Drawing.Point(36, 30);
            this.painelDescartes.Name = "painelDescartes";
            this.painelDescartes.Size = new System.Drawing.Size(918, 704);
            this.painelDescartes.TabIndex = 1;
            // 
            // painelPontos
            // 
            this.painelPontos.BackColor = System.Drawing.Color.FromArgb(243, 246, 249);
            this.painelPontos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.painelPontos.Location = new System.Drawing.Point(36, 30);
            this.painelPontos.Name = "painelPontos";
            this.painelPontos.Size = new System.Drawing.Size(918, 704);
            this.painelPontos.TabIndex = 2;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(243, 246, 249);
            this.ClientSize = new System.Drawing.Size(1240, 760);
            this.Controls.Add(this.layoutPrincipal);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimumSize = new System.Drawing.Size(1080, 700);
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Descarte de E-lixo — Equipe 10";
            this.layoutPrincipal.ResumeLayout(false);
            this.pnlSidebar.ResumeLayout(false);
            this.pnlSidebar.PerformLayout();
            this.pnlConteudo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel layoutPrincipal;
        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Label lblIcone;
        private System.Windows.Forms.Label lblTitulo1;
        private System.Windows.Forms.Label lblTitulo2;
        private System.Windows.Forms.Label lblEquipe;
        private System.Windows.Forms.Label lblSecDescarte;
        private System.Windows.Forms.Label lblSecPontos;
        private BotaoMenu btnInicio;
        private BotaoMenu btnDescarte;
        private BotaoMenu btnHistorico;
        private BotaoMenu btnPontos;
        private BotaoMenu btnCreditos;
        private BotaoMenu btnSair;
        private System.Windows.Forms.Panel pnlConteudo;
        private PainelInicio painelInicio;
        private PainelDescartes painelDescartes;
        private PainelPontos painelPontos;
    }
}
