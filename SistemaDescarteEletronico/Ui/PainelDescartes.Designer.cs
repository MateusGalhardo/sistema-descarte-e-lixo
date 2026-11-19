namespace SistemaDescarteEletronico
{
    partial class PainelDescartes
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
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblContagem = new System.Windows.Forms.Label();
            this.pnlBotaoNovo = new System.Windows.Forms.Panel();
            this.btnNovo = new SistemaDescarteEletronico.BotaoAcao();
            this.corpo = new System.Windows.Forms.TableLayoutPanel();
            this.pnlEsquerda = new System.Windows.Forms.Panel();
            this.grid = new System.Windows.Forms.DataGridView();
            this.colNumero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEquipamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPontos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDestino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblVazio = new System.Windows.Forms.Label();
            this.cartaoDetalhes = new SistemaDescarteEletronico.Cartao();
            this.detalhes = new SistemaDescarteEletronico.DetalhesDescarteView();
            this.pnlRodape = new System.Windows.Forms.Panel();
            this.btnVoltar = new SistemaDescarteEletronico.BotaoAcao();
            this.btnExportar = new SistemaDescarteEletronico.BotaoAcao();
            this.raiz.SuspendLayout();
            this.pnlTitulo.SuspendLayout();
            this.pnlBotaoNovo.SuspendLayout();
            this.corpo.SuspendLayout();
            this.pnlEsquerda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.cartaoDetalhes.SuspendLayout();
            this.pnlRodape.SuspendLayout();
            this.SuspendLayout();
            // 
            // raiz
            // 
            this.raiz.ColumnCount = 1;
            this.raiz.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.raiz.Controls.Add(this.pnlTitulo, 0, 0);
            this.raiz.Controls.Add(this.corpo, 0, 1);
            this.raiz.Controls.Add(this.pnlRodape, 0, 2);
            this.raiz.Dock = System.Windows.Forms.DockStyle.Fill;
            this.raiz.Location = new System.Drawing.Point(0, 0);
            this.raiz.Margin = new System.Windows.Forms.Padding(0);
            this.raiz.Name = "raiz";
            this.raiz.RowCount = 3;
            this.raiz.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.raiz.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.raiz.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.raiz.Size = new System.Drawing.Size(918, 704);
            this.raiz.TabIndex = 0;
            // 
            // pnlTitulo
            // 
            this.pnlTitulo.Controls.Add(this.lblTitulo);
            this.pnlTitulo.Controls.Add(this.lblContagem);
            this.pnlTitulo.Controls.Add(this.pnlBotaoNovo);
            this.pnlTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTitulo.Location = new System.Drawing.Point(0, 0);
            this.pnlTitulo.Margin = new System.Windows.Forms.Padding(0);
            this.pnlTitulo.Name = "pnlTitulo";
            this.pnlTitulo.Size = new System.Drawing.Size(918, 80);
            this.pnlTitulo.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(27, 38, 49);
            this.lblTitulo.Location = new System.Drawing.Point(0, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(305, 37);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Histórico de descartes";
            // 
            // lblContagem
            // 
            this.lblContagem.AutoSize = true;
            this.lblContagem.BackColor = System.Drawing.Color.Transparent;
            this.lblContagem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContagem.ForeColor = System.Drawing.Color.FromArgb(106, 120, 133);
            this.lblContagem.Location = new System.Drawing.Point(2, 42);
            this.lblContagem.Name = "lblContagem";
            this.lblContagem.Size = new System.Drawing.Size(380, 19);
            this.lblContagem.TabIndex = 1;
            this.lblContagem.Text = "Os equipamentos descartados e suas triagens aparecem aqui.";
            // 
            // pnlBotaoNovo
            // 
            this.pnlBotaoNovo.Controls.Add(this.btnNovo);
            this.pnlBotaoNovo.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlBotaoNovo.Location = new System.Drawing.Point(748, 0);
            this.pnlBotaoNovo.Name = "pnlBotaoNovo";
            this.pnlBotaoNovo.Padding = new System.Windows.Forms.Padding(0, 4, 0, 30);
            this.pnlBotaoNovo.Size = new System.Drawing.Size(170, 80);
            this.pnlBotaoNovo.TabIndex = 2;
            // 
            // btnNovo
            // 
            this.btnNovo.BackColor = System.Drawing.Color.FromArgb(39, 160, 94);
            this.btnNovo.Cor = System.Drawing.Color.FromArgb(39, 160, 94);
            this.btnNovo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNovo.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovo.Location = new System.Drawing.Point(0, 4);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(170, 46);
            this.btnNovo.TabIndex = 0;
            this.btnNovo.Text = "Realizar descarte";
            this.btnNovo.UseVisualStyleBackColor = false;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // corpo
            // 
            this.corpo.ColumnCount = 2;
            this.corpo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58F));
            this.corpo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42F));
            this.corpo.Controls.Add(this.pnlEsquerda, 0, 0);
            this.corpo.Controls.Add(this.cartaoDetalhes, 1, 0);
            this.corpo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.corpo.Location = new System.Drawing.Point(0, 80);
            this.corpo.Margin = new System.Windows.Forms.Padding(0);
            this.corpo.Name = "corpo";
            this.corpo.RowCount = 1;
            this.corpo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.corpo.Size = new System.Drawing.Size(918, 574);
            this.corpo.TabIndex = 1;
            // 
            // pnlEsquerda
            // 
            this.pnlEsquerda.Controls.Add(this.grid);
            this.pnlEsquerda.Controls.Add(this.lblVazio);
            this.pnlEsquerda.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlEsquerda.Location = new System.Drawing.Point(0, 0);
            this.pnlEsquerda.Margin = new System.Windows.Forms.Padding(0, 0, 16, 0);
            this.pnlEsquerda.Name = "pnlEsquerda";
            this.pnlEsquerda.Size = new System.Drawing.Size(516, 574);
            this.pnlEsquerda.TabIndex = 0;
            // 
            // grid
            // 
            this.grid.AllowUserToAddRows = false;
            this.grid.AllowUserToDeleteRows = false;
            this.grid.AllowUserToResizeRows = false;
            this.grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid.BackgroundColor = System.Drawing.Color.White;
            this.grid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grid.ColumnHeadersHeight = 42;
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNumero,
            this.colData,
            this.colEquipamento,
            this.colPontos,
            this.colDestino});
            this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid.Location = new System.Drawing.Point(0, 0);
            this.grid.MultiSelect = false;
            this.grid.Name = "grid";
            this.grid.ReadOnly = true;
            this.grid.RowHeadersVisible = false;
            this.grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid.Size = new System.Drawing.Size(516, 574);
            this.grid.TabIndex = 0;
            this.grid.SelectionChanged += new System.EventHandler(this.grid_SelectionChanged);
            this.grid.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.FormatarDestino);
            // 
            // colNumero
            // 
            this.colNumero.FillWeight = 7F;
            this.colNumero.HeaderText = "Nº";
            this.colNumero.Name = "colNumero";
            this.colNumero.ReadOnly = true;
            this.colNumero.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colData
            // 
            this.colData.FillWeight = 24F;
            this.colData.HeaderText = "Data";
            this.colData.Name = "colData";
            this.colData.ReadOnly = true;
            this.colData.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colEquipamento
            // 
            this.colEquipamento.FillWeight = 26F;
            this.colEquipamento.HeaderText = "Equipamento";
            this.colEquipamento.Name = "colEquipamento";
            this.colEquipamento.ReadOnly = true;
            this.colEquipamento.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colPontos
            // 
            this.colPontos.FillWeight = 13F;
            this.colPontos.HeaderText = "Pontos";
            this.colPontos.Name = "colPontos";
            this.colPontos.ReadOnly = true;
            this.colPontos.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colDestino
            // 
            this.colDestino.FillWeight = 30F;
            this.colDestino.HeaderText = "Destino";
            this.colDestino.Name = "colDestino";
            this.colDestino.ReadOnly = true;
            this.colDestino.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // lblVazio
            // 
            this.lblVazio.BackColor = System.Drawing.Color.White;
            this.lblVazio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblVazio.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVazio.ForeColor = System.Drawing.Color.FromArgb(106, 120, 133);
            this.lblVazio.Location = new System.Drawing.Point(0, 0);
            this.lblVazio.Name = "lblVazio";
            this.lblVazio.Size = new System.Drawing.Size(516, 574);
            this.lblVazio.TabIndex = 1;
            this.lblVazio.Text = "Nenhum descarte registrado ainda.\r\nClique em \"Realizar descarte\" para começar.";
            this.lblVazio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cartaoDetalhes
            // 
            this.cartaoDetalhes.BackColor = System.Drawing.Color.White;
            this.cartaoDetalhes.Controls.Add(this.detalhes);
            this.cartaoDetalhes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cartaoDetalhes.Location = new System.Drawing.Point(532, 0);
            this.cartaoDetalhes.Margin = new System.Windows.Forms.Padding(0);
            this.cartaoDetalhes.Name = "cartaoDetalhes";
            this.cartaoDetalhes.Padding = new System.Windows.Forms.Padding(1);
            this.cartaoDetalhes.Size = new System.Drawing.Size(386, 574);
            this.cartaoDetalhes.TabIndex = 1;
            // 
            // detalhes
            // 
            this.detalhes.BackColor = System.Drawing.Color.White;
            this.detalhes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.detalhes.Location = new System.Drawing.Point(1, 1);
            this.detalhes.Name = "detalhes";
            this.detalhes.Size = new System.Drawing.Size(384, 572);
            this.detalhes.TabIndex = 0;
            // 
            // pnlRodape
            // 
            this.pnlRodape.Controls.Add(this.btnVoltar);
            this.pnlRodape.Controls.Add(this.btnExportar);
            this.pnlRodape.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRodape.Location = new System.Drawing.Point(0, 654);
            this.pnlRodape.Margin = new System.Windows.Forms.Padding(0);
            this.pnlRodape.Name = "pnlRodape";
            this.pnlRodape.Padding = new System.Windows.Forms.Padding(0, 14, 0, 0);
            this.pnlRodape.Size = new System.Drawing.Size(918, 50);
            this.pnlRodape.TabIndex = 2;
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.White;
            this.btnVoltar.Cor = System.Drawing.Color.FromArgb(120, 134, 148);
            this.btnVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVoltar.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Location = new System.Drawing.Point(0, 14);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Secundario = true;
            this.btnVoltar.Size = new System.Drawing.Size(110, 36);
            this.btnVoltar.TabIndex = 0;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnExportar
            // 
            this.btnExportar.BackColor = System.Drawing.Color.FromArgb(0, 151, 167);
            this.btnExportar.Cor = System.Drawing.Color.FromArgb(0, 151, 167);
            this.btnExportar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExportar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportar.Location = new System.Drawing.Point(748, 14);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(170, 36);
            this.btnExportar.TabIndex = 1;
            this.btnExportar.Text = "Exportar histórico";
            this.btnExportar.UseVisualStyleBackColor = false;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // PainelDescartes
            // 
            this.BackColor = System.Drawing.Color.FromArgb(243, 246, 249);
            this.Controls.Add(this.raiz);
            this.Name = "PainelDescartes";
            this.Size = new System.Drawing.Size(918, 704);
            this.raiz.ResumeLayout(false);
            this.pnlTitulo.ResumeLayout(false);
            this.pnlTitulo.PerformLayout();
            this.pnlBotaoNovo.ResumeLayout(false);
            this.corpo.ResumeLayout(false);
            this.pnlEsquerda.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.cartaoDetalhes.ResumeLayout(false);
            this.pnlRodape.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel raiz;
        private System.Windows.Forms.Panel pnlTitulo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblContagem;
        private System.Windows.Forms.Panel pnlBotaoNovo;
        private BotaoAcao btnNovo;
        private System.Windows.Forms.TableLayoutPanel corpo;
        private System.Windows.Forms.Panel pnlEsquerda;
        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNumero;
        private System.Windows.Forms.DataGridViewTextBoxColumn colData;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEquipamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPontos;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDestino;
        private System.Windows.Forms.Label lblVazio;
        private Cartao cartaoDetalhes;
        private DetalhesDescarteView detalhes;
        private System.Windows.Forms.Panel pnlRodape;
        private BotaoAcao btnVoltar;
        private BotaoAcao btnExportar;
    }
}
