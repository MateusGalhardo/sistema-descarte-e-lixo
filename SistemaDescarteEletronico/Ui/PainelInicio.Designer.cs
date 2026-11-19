namespace SistemaDescarteEletronico
{
    partial class PainelInicio
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
            this.raiz = new System.Windows.Forms.TableLayoutPanel();
            this.pnlCabecalho = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblSubtitulo = new System.Windows.Forms.Label();
            this.tblCartoes = new System.Windows.Forms.TableLayoutPanel();
            this.cartaoPontos = new SistemaDescarteEletronico.Cartao();
            this.faixaPontos = new System.Windows.Forms.Panel();
            this.lblPontos = new System.Windows.Forms.Label();
            this.lblDescPontos = new System.Windows.Forms.Label();
            this.cartaoDescartes = new SistemaDescarteEletronico.Cartao();
            this.faixaDescartes = new System.Windows.Forms.Panel();
            this.lblDescartes = new System.Windows.Forms.Label();
            this.lblDescDescartes = new System.Windows.Forms.Label();
            this.cartaoReutilizaveis = new SistemaDescarteEletronico.Cartao();
            this.faixaReutilizaveis = new System.Windows.Forms.Panel();
            this.lblReutilizaveis = new System.Windows.Forms.Label();
            this.lblDescReutilizaveis = new System.Windows.Forms.Label();
            this.cartaoReciclaveis = new SistemaDescarteEletronico.Cartao();
            this.faixaReciclaveis = new System.Windows.Forms.Panel();
            this.lblReciclaveis = new System.Windows.Forms.Label();
            this.lblDescReciclaveis = new System.Windows.Forms.Label();
            this.cartaoEspeciais = new SistemaDescarteEletronico.Cartao();
            this.faixaEspeciais = new System.Windows.Forms.Panel();
            this.lblEspeciais = new System.Windows.Forms.Label();
            this.lblDescEspeciais = new System.Windows.Forms.Label();
            this.pnlAtalhos = new System.Windows.Forms.Panel();
            this.lblAtalhos = new System.Windows.Forms.Label();
            this.btnDescarte = new SistemaDescarteEletronico.BotaoAcao();
            this.btnPonto = new SistemaDescarteEletronico.BotaoAcao();
            this.raiz.SuspendLayout();
            this.pnlCabecalho.SuspendLayout();
            this.tblCartoes.SuspendLayout();
            this.cartaoPontos.SuspendLayout();
            this.cartaoDescartes.SuspendLayout();
            this.cartaoReutilizaveis.SuspendLayout();
            this.cartaoReciclaveis.SuspendLayout();
            this.cartaoEspeciais.SuspendLayout();
            this.pnlAtalhos.SuspendLayout();
            this.SuspendLayout();
            // 
            // raiz
            // 
            this.raiz.ColumnCount = 1;
            this.raiz.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.raiz.Controls.Add(this.pnlCabecalho, 0, 0);
            this.raiz.Controls.Add(this.tblCartoes, 0, 1);
            this.raiz.Controls.Add(this.pnlAtalhos, 0, 2);
            this.raiz.Dock = System.Windows.Forms.DockStyle.Fill;
            this.raiz.Location = new System.Drawing.Point(0, 0);
            this.raiz.Margin = new System.Windows.Forms.Padding(0);
            this.raiz.Name = "raiz";
            this.raiz.RowCount = 3;
            this.raiz.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 92F));
            this.raiz.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 272F));
            this.raiz.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.raiz.Size = new System.Drawing.Size(918, 704);
            this.raiz.TabIndex = 0;
            // 
            // pnlCabecalho
            // 
            this.pnlCabecalho.Controls.Add(this.lblTitulo);
            this.pnlCabecalho.Controls.Add(this.lblSubtitulo);
            this.pnlCabecalho.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCabecalho.Location = new System.Drawing.Point(0, 0);
            this.pnlCabecalho.Margin = new System.Windows.Forms.Padding(0);
            this.pnlCabecalho.Name = "pnlCabecalho";
            this.pnlCabecalho.Size = new System.Drawing.Size(918, 92);
            this.pnlCabecalho.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(27, 38, 49);
            this.lblTitulo.Location = new System.Drawing.Point(0, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(588, 37);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Bem-vindo ao sistema de descarte de e-lixo";
            // 
            // lblSubtitulo
            // 
            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblSubtitulo.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtitulo.ForeColor = System.Drawing.Color.FromArgb(106, 120, 133);
            this.lblSubtitulo.Location = new System.Drawing.Point(2, 44);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Size = new System.Drawing.Size(640, 19);
            this.lblSubtitulo.TabIndex = 1;
            this.lblSubtitulo.Text = "Avalie o melhor destino para cada equipamento eletrônico e encontre onde descartá-lo corretamente.";
            // 
            // tblCartoes
            // 
            this.tblCartoes.ColumnCount = 3;
            this.tblCartoes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tblCartoes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tblCartoes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tblCartoes.Controls.Add(this.cartaoPontos, 0, 0);
            this.tblCartoes.Controls.Add(this.cartaoDescartes, 1, 0);
            this.tblCartoes.Controls.Add(this.cartaoReutilizaveis, 2, 0);
            this.tblCartoes.Controls.Add(this.cartaoReciclaveis, 0, 1);
            this.tblCartoes.Controls.Add(this.cartaoEspeciais, 1, 1);
            this.tblCartoes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblCartoes.Location = new System.Drawing.Point(0, 92);
            this.tblCartoes.Margin = new System.Windows.Forms.Padding(0);
            this.tblCartoes.Name = "tblCartoes";
            this.tblCartoes.RowCount = 2;
            this.tblCartoes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 132F));
            this.tblCartoes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 132F));
            this.tblCartoes.Size = new System.Drawing.Size(918, 272);
            this.tblCartoes.TabIndex = 1;
            // 
            // cartaoPontos
            // 
            this.cartaoPontos.BackColor = System.Drawing.Color.White;
            this.cartaoPontos.Controls.Add(this.faixaPontos);
            this.cartaoPontos.Controls.Add(this.lblPontos);
            this.cartaoPontos.Controls.Add(this.lblDescPontos);
            this.cartaoPontos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cartaoPontos.Location = new System.Drawing.Point(0, 0);
            this.cartaoPontos.Margin = new System.Windows.Forms.Padding(0, 0, 18, 18);
            this.cartaoPontos.Name = "cartaoPontos";
            this.cartaoPontos.Size = new System.Drawing.Size(288, 114);
            this.cartaoPontos.TabIndex = 0;
            // 
            // faixaPontos
            // 
            this.faixaPontos.BackColor = System.Drawing.Color.FromArgb(0, 151, 167);
            this.faixaPontos.Dock = System.Windows.Forms.DockStyle.Left;
            this.faixaPontos.Location = new System.Drawing.Point(0, 0);
            this.faixaPontos.Name = "faixaPontos";
            this.faixaPontos.Size = new System.Drawing.Size(6, 114);
            this.faixaPontos.TabIndex = 0;
            // 
            // lblPontos
            // 
            this.lblPontos.AutoSize = true;
            this.lblPontos.BackColor = System.Drawing.Color.Transparent;
            this.lblPontos.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPontos.ForeColor = System.Drawing.Color.FromArgb(0, 128, 141);
            this.lblPontos.Location = new System.Drawing.Point(26, 14);
            this.lblPontos.Name = "lblPontos";
            this.lblPontos.Size = new System.Drawing.Size(46, 54);
            this.lblPontos.TabIndex = 1;
            this.lblPontos.Text = "0";
            // 
            // lblDescPontos
            // 
            this.lblDescPontos.AutoSize = true;
            this.lblDescPontos.BackColor = System.Drawing.Color.Transparent;
            this.lblDescPontos.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescPontos.ForeColor = System.Drawing.Color.FromArgb(106, 120, 133);
            this.lblDescPontos.Location = new System.Drawing.Point(28, 74);
            this.lblDescPontos.Name = "lblDescPontos";
            this.lblDescPontos.Size = new System.Drawing.Size(183, 19);
            this.lblDescPontos.TabIndex = 2;
            this.lblDescPontos.Text = "Pontos de coleta cadastrados";
            // 
            // cartaoDescartes
            // 
            this.cartaoDescartes.BackColor = System.Drawing.Color.White;
            this.cartaoDescartes.Controls.Add(this.faixaDescartes);
            this.cartaoDescartes.Controls.Add(this.lblDescartes);
            this.cartaoDescartes.Controls.Add(this.lblDescDescartes);
            this.cartaoDescartes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cartaoDescartes.Location = new System.Drawing.Point(306, 0);
            this.cartaoDescartes.Margin = new System.Windows.Forms.Padding(0, 0, 18, 18);
            this.cartaoDescartes.Name = "cartaoDescartes";
            this.cartaoDescartes.Size = new System.Drawing.Size(288, 114);
            this.cartaoDescartes.TabIndex = 1;
            // 
            // faixaDescartes
            // 
            this.faixaDescartes.BackColor = System.Drawing.Color.FromArgb(0, 151, 167);
            this.faixaDescartes.Dock = System.Windows.Forms.DockStyle.Left;
            this.faixaDescartes.Location = new System.Drawing.Point(0, 0);
            this.faixaDescartes.Name = "faixaDescartes";
            this.faixaDescartes.Size = new System.Drawing.Size(6, 114);
            this.faixaDescartes.TabIndex = 0;
            // 
            // lblDescartes
            // 
            this.lblDescartes.AutoSize = true;
            this.lblDescartes.BackColor = System.Drawing.Color.Transparent;
            this.lblDescartes.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescartes.ForeColor = System.Drawing.Color.FromArgb(0, 128, 141);
            this.lblDescartes.Location = new System.Drawing.Point(26, 14);
            this.lblDescartes.Name = "lblDescartes";
            this.lblDescartes.Size = new System.Drawing.Size(46, 54);
            this.lblDescartes.TabIndex = 1;
            this.lblDescartes.Text = "0";
            // 
            // lblDescDescartes
            // 
            this.lblDescDescartes.AutoSize = true;
            this.lblDescDescartes.BackColor = System.Drawing.Color.Transparent;
            this.lblDescDescartes.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescDescartes.ForeColor = System.Drawing.Color.FromArgb(106, 120, 133);
            this.lblDescDescartes.Location = new System.Drawing.Point(28, 74);
            this.lblDescDescartes.Name = "lblDescDescartes";
            this.lblDescDescartes.Size = new System.Drawing.Size(130, 19);
            this.lblDescDescartes.TabIndex = 2;
            this.lblDescDescartes.Text = "Descartes realizados";
            // 
            // cartaoReutilizaveis
            // 
            this.cartaoReutilizaveis.BackColor = System.Drawing.Color.White;
            this.cartaoReutilizaveis.Controls.Add(this.faixaReutilizaveis);
            this.cartaoReutilizaveis.Controls.Add(this.lblReutilizaveis);
            this.cartaoReutilizaveis.Controls.Add(this.lblDescReutilizaveis);
            this.cartaoReutilizaveis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cartaoReutilizaveis.Location = new System.Drawing.Point(612, 0);
            this.cartaoReutilizaveis.Margin = new System.Windows.Forms.Padding(0, 0, 18, 18);
            this.cartaoReutilizaveis.Name = "cartaoReutilizaveis";
            this.cartaoReutilizaveis.Size = new System.Drawing.Size(288, 114);
            this.cartaoReutilizaveis.TabIndex = 2;
            // 
            // faixaReutilizaveis
            // 
            this.faixaReutilizaveis.BackColor = System.Drawing.Color.FromArgb(39, 160, 94);
            this.faixaReutilizaveis.Dock = System.Windows.Forms.DockStyle.Left;
            this.faixaReutilizaveis.Location = new System.Drawing.Point(0, 0);
            this.faixaReutilizaveis.Name = "faixaReutilizaveis";
            this.faixaReutilizaveis.Size = new System.Drawing.Size(6, 114);
            this.faixaReutilizaveis.TabIndex = 0;
            // 
            // lblReutilizaveis
            // 
            this.lblReutilizaveis.AutoSize = true;
            this.lblReutilizaveis.BackColor = System.Drawing.Color.Transparent;
            this.lblReutilizaveis.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReutilizaveis.ForeColor = System.Drawing.Color.FromArgb(33, 136, 79);
            this.lblReutilizaveis.Location = new System.Drawing.Point(26, 14);
            this.lblReutilizaveis.Name = "lblReutilizaveis";
            this.lblReutilizaveis.Size = new System.Drawing.Size(46, 54);
            this.lblReutilizaveis.TabIndex = 1;
            this.lblReutilizaveis.Text = "0";
            // 
            // lblDescReutilizaveis
            // 
            this.lblDescReutilizaveis.AutoSize = true;
            this.lblDescReutilizaveis.BackColor = System.Drawing.Color.Transparent;
            this.lblDescReutilizaveis.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescReutilizaveis.ForeColor = System.Drawing.Color.FromArgb(106, 120, 133);
            this.lblDescReutilizaveis.Location = new System.Drawing.Point(28, 74);
            this.lblDescReutilizaveis.Name = "lblDescReutilizaveis";
            this.lblDescReutilizaveis.Size = new System.Drawing.Size(80, 19);
            this.lblDescReutilizaveis.TabIndex = 2;
            this.lblDescReutilizaveis.Text = "Reutilizáveis";
            // 
            // cartaoReciclaveis
            // 
            this.cartaoReciclaveis.BackColor = System.Drawing.Color.White;
            this.cartaoReciclaveis.Controls.Add(this.faixaReciclaveis);
            this.cartaoReciclaveis.Controls.Add(this.lblReciclaveis);
            this.cartaoReciclaveis.Controls.Add(this.lblDescReciclaveis);
            this.cartaoReciclaveis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cartaoReciclaveis.Location = new System.Drawing.Point(0, 132);
            this.cartaoReciclaveis.Margin = new System.Windows.Forms.Padding(0, 0, 18, 18);
            this.cartaoReciclaveis.Name = "cartaoReciclaveis";
            this.cartaoReciclaveis.Size = new System.Drawing.Size(288, 122);
            this.cartaoReciclaveis.TabIndex = 3;
            // 
            // faixaReciclaveis
            // 
            this.faixaReciclaveis.BackColor = System.Drawing.Color.FromArgb(240, 165, 0);
            this.faixaReciclaveis.Dock = System.Windows.Forms.DockStyle.Left;
            this.faixaReciclaveis.Location = new System.Drawing.Point(0, 0);
            this.faixaReciclaveis.Name = "faixaReciclaveis";
            this.faixaReciclaveis.Size = new System.Drawing.Size(6, 122);
            this.faixaReciclaveis.TabIndex = 0;
            // 
            // lblReciclaveis
            // 
            this.lblReciclaveis.AutoSize = true;
            this.lblReciclaveis.BackColor = System.Drawing.Color.Transparent;
            this.lblReciclaveis.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReciclaveis.ForeColor = System.Drawing.Color.FromArgb(204, 140, 0);
            this.lblReciclaveis.Location = new System.Drawing.Point(26, 14);
            this.lblReciclaveis.Name = "lblReciclaveis";
            this.lblReciclaveis.Size = new System.Drawing.Size(46, 54);
            this.lblReciclaveis.TabIndex = 1;
            this.lblReciclaveis.Text = "0";
            // 
            // lblDescReciclaveis
            // 
            this.lblDescReciclaveis.AutoSize = true;
            this.lblDescReciclaveis.BackColor = System.Drawing.Color.Transparent;
            this.lblDescReciclaveis.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescReciclaveis.ForeColor = System.Drawing.Color.FromArgb(106, 120, 133);
            this.lblDescReciclaveis.Location = new System.Drawing.Point(28, 74);
            this.lblDescReciclaveis.Name = "lblDescReciclaveis";
            this.lblDescReciclaveis.Size = new System.Drawing.Size(72, 19);
            this.lblDescReciclaveis.TabIndex = 2;
            this.lblDescReciclaveis.Text = "Recicláveis";
            // 
            // cartaoEspeciais
            // 
            this.cartaoEspeciais.BackColor = System.Drawing.Color.White;
            this.cartaoEspeciais.Controls.Add(this.faixaEspeciais);
            this.cartaoEspeciais.Controls.Add(this.lblEspeciais);
            this.cartaoEspeciais.Controls.Add(this.lblDescEspeciais);
            this.cartaoEspeciais.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cartaoEspeciais.Location = new System.Drawing.Point(306, 132);
            this.cartaoEspeciais.Margin = new System.Windows.Forms.Padding(0, 0, 18, 18);
            this.cartaoEspeciais.Name = "cartaoEspeciais";
            this.cartaoEspeciais.Size = new System.Drawing.Size(288, 122);
            this.cartaoEspeciais.TabIndex = 4;
            // 
            // faixaEspeciais
            // 
            this.faixaEspeciais.BackColor = System.Drawing.Color.FromArgb(214, 69, 65);
            this.faixaEspeciais.Dock = System.Windows.Forms.DockStyle.Left;
            this.faixaEspeciais.Location = new System.Drawing.Point(0, 0);
            this.faixaEspeciais.Name = "faixaEspeciais";
            this.faixaEspeciais.Size = new System.Drawing.Size(6, 122);
            this.faixaEspeciais.TabIndex = 0;
            // 
            // lblEspeciais
            // 
            this.lblEspeciais.AutoSize = true;
            this.lblEspeciais.BackColor = System.Drawing.Color.Transparent;
            this.lblEspeciais.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEspeciais.ForeColor = System.Drawing.Color.FromArgb(181, 58, 55);
            this.lblEspeciais.Location = new System.Drawing.Point(26, 14);
            this.lblEspeciais.Name = "lblEspeciais";
            this.lblEspeciais.Size = new System.Drawing.Size(46, 54);
            this.lblEspeciais.TabIndex = 1;
            this.lblEspeciais.Text = "0";
            // 
            // lblDescEspeciais
            // 
            this.lblDescEspeciais.AutoSize = true;
            this.lblDescEspeciais.BackColor = System.Drawing.Color.Transparent;
            this.lblDescEspeciais.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescEspeciais.ForeColor = System.Drawing.Color.FromArgb(106, 120, 133);
            this.lblDescEspeciais.Location = new System.Drawing.Point(28, 74);
            this.lblDescEspeciais.Name = "lblDescEspeciais";
            this.lblDescEspeciais.Size = new System.Drawing.Size(112, 19);
            this.lblDescEspeciais.TabIndex = 2;
            this.lblDescEspeciais.Text = "Descarte especial";
            // 
            // pnlAtalhos
            // 
            this.pnlAtalhos.Controls.Add(this.lblAtalhos);
            this.pnlAtalhos.Controls.Add(this.btnDescarte);
            this.pnlAtalhos.Controls.Add(this.btnPonto);
            this.pnlAtalhos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAtalhos.Location = new System.Drawing.Point(0, 364);
            this.pnlAtalhos.Margin = new System.Windows.Forms.Padding(0);
            this.pnlAtalhos.Name = "pnlAtalhos";
            this.pnlAtalhos.Size = new System.Drawing.Size(918, 340);
            this.pnlAtalhos.TabIndex = 2;
            // 
            // lblAtalhos
            // 
            this.lblAtalhos.AutoSize = true;
            this.lblAtalhos.BackColor = System.Drawing.Color.Transparent;
            this.lblAtalhos.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAtalhos.ForeColor = System.Drawing.Color.FromArgb(106, 120, 133);
            this.lblAtalhos.Location = new System.Drawing.Point(0, 10);
            this.lblAtalhos.Name = "lblAtalhos";
            this.lblAtalhos.Size = new System.Drawing.Size(64, 15);
            this.lblAtalhos.TabIndex = 0;
            this.lblAtalhos.Text = "COMEÇAR";
            // 
            // btnDescarte
            // 
            this.btnDescarte.BackColor = System.Drawing.Color.FromArgb(39, 160, 94);
            this.btnDescarte.Cor = System.Drawing.Color.FromArgb(39, 160, 94);
            this.btnDescarte.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDescarte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDescarte.Location = new System.Drawing.Point(0, 38);
            this.btnDescarte.Name = "btnDescarte";
            this.btnDescarte.Size = new System.Drawing.Size(250, 46);
            this.btnDescarte.TabIndex = 1;
            this.btnDescarte.Text = "Realizar descarte eletrônico";
            this.btnDescarte.UseVisualStyleBackColor = false;
            this.btnDescarte.Click += new System.EventHandler(this.btnDescarte_Click);
            // 
            // btnPonto
            // 
            this.btnPonto.BackColor = System.Drawing.Color.FromArgb(0, 151, 167);
            this.btnPonto.Cor = System.Drawing.Color.FromArgb(0, 151, 167);
            this.btnPonto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPonto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPonto.Location = new System.Drawing.Point(264, 38);
            this.btnPonto.Name = "btnPonto";
            this.btnPonto.Size = new System.Drawing.Size(250, 46);
            this.btnPonto.TabIndex = 2;
            this.btnPonto.Text = "Cadastrar ponto de coleta";
            this.btnPonto.UseVisualStyleBackColor = false;
            this.btnPonto.Click += new System.EventHandler(this.btnPonto_Click);
            // 
            // PainelInicio
            // 
            this.BackColor = System.Drawing.Color.FromArgb(243, 246, 249);
            this.Controls.Add(this.raiz);
            this.Name = "PainelInicio";
            this.Size = new System.Drawing.Size(918, 704);
            this.raiz.ResumeLayout(false);
            this.pnlCabecalho.ResumeLayout(false);
            this.pnlCabecalho.PerformLayout();
            this.tblCartoes.ResumeLayout(false);
            this.cartaoPontos.ResumeLayout(false);
            this.cartaoPontos.PerformLayout();
            this.cartaoDescartes.ResumeLayout(false);
            this.cartaoDescartes.PerformLayout();
            this.cartaoReutilizaveis.ResumeLayout(false);
            this.cartaoReutilizaveis.PerformLayout();
            this.cartaoReciclaveis.ResumeLayout(false);
            this.cartaoReciclaveis.PerformLayout();
            this.cartaoEspeciais.ResumeLayout(false);
            this.cartaoEspeciais.PerformLayout();
            this.pnlAtalhos.ResumeLayout(false);
            this.pnlAtalhos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel raiz;
        private System.Windows.Forms.Panel pnlCabecalho;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.TableLayoutPanel tblCartoes;
        private Cartao cartaoPontos;
        private System.Windows.Forms.Panel faixaPontos;
        private System.Windows.Forms.Label lblPontos;
        private System.Windows.Forms.Label lblDescPontos;
        private Cartao cartaoDescartes;
        private System.Windows.Forms.Panel faixaDescartes;
        private System.Windows.Forms.Label lblDescartes;
        private System.Windows.Forms.Label lblDescDescartes;
        private Cartao cartaoReutilizaveis;
        private System.Windows.Forms.Panel faixaReutilizaveis;
        private System.Windows.Forms.Label lblReutilizaveis;
        private System.Windows.Forms.Label lblDescReutilizaveis;
        private Cartao cartaoReciclaveis;
        private System.Windows.Forms.Panel faixaReciclaveis;
        private System.Windows.Forms.Label lblReciclaveis;
        private System.Windows.Forms.Label lblDescReciclaveis;
        private Cartao cartaoEspeciais;
        private System.Windows.Forms.Panel faixaEspeciais;
        private System.Windows.Forms.Label lblEspeciais;
        private System.Windows.Forms.Label lblDescEspeciais;
        private System.Windows.Forms.Panel pnlAtalhos;
        private System.Windows.Forms.Label lblAtalhos;
        private BotaoAcao btnDescarte;
        private BotaoAcao btnPonto;
    }
}
