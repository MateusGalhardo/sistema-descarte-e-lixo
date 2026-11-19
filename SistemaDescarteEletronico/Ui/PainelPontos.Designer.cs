namespace SistemaDescarteEletronico
{
    partial class PainelPontos
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
            this.lblSubtitulo = new System.Windows.Forms.Label();
            this.pnlBarra = new System.Windows.Forms.Panel();
            this.lblBusca = new System.Windows.Forms.Label();
            this.txtBusca = new System.Windows.Forms.TextBox();
            this.btnBuscar = new SistemaDescarteEletronico.BotaoAcao();
            this.btnLimpar = new SistemaDescarteEletronico.BotaoAcao();
            this.lblStatus = new System.Windows.Forms.Label();
            this.flowAcoes = new System.Windows.Forms.FlowLayoutPanel();
            this.btnNovo = new SistemaDescarteEletronico.BotaoAcao();
            this.btnEditar = new SistemaDescarteEletronico.BotaoAcao();
            this.btnExcluir = new SistemaDescarteEletronico.BotaoAcao();
            this.grid = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEstabelecimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEndereco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTelefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHorario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colResiduos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cartaoDetalhes = new SistemaDescarteEletronico.Cartao();
            this.lblDetTitulo = new System.Windows.Forms.Label();
            this.lblRotNome = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblRotEndereco = new System.Windows.Forms.Label();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.lblRotTelefone = new System.Windows.Forms.Label();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.lblRotHorario = new System.Windows.Forms.Label();
            this.lblHorario = new System.Windows.Forms.Label();
            this.lblRotResiduos = new System.Windows.Forms.Label();
            this.flowResiduos = new System.Windows.Forms.FlowLayoutPanel();
            this.lblSemSelecao = new System.Windows.Forms.Label();
            this.pnlRodape = new System.Windows.Forms.Panel();
            this.btnVoltar = new SistemaDescarteEletronico.BotaoAcao();
            this.raiz.SuspendLayout();
            this.pnlTitulo.SuspendLayout();
            this.pnlBarra.SuspendLayout();
            this.flowAcoes.SuspendLayout();
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
            this.raiz.Controls.Add(this.pnlBarra, 0, 1);
            this.raiz.Controls.Add(this.grid, 0, 2);
            this.raiz.Controls.Add(this.cartaoDetalhes, 0, 3);
            this.raiz.Controls.Add(this.pnlRodape, 0, 4);
            this.raiz.Dock = System.Windows.Forms.DockStyle.Fill;
            this.raiz.Location = new System.Drawing.Point(0, 0);
            this.raiz.Margin = new System.Windows.Forms.Padding(0);
            this.raiz.Name = "raiz";
            this.raiz.RowCount = 5;
            this.raiz.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 72F));
            this.raiz.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 92F));
            this.raiz.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.raiz.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 196F));
            this.raiz.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.raiz.Size = new System.Drawing.Size(918, 704);
            this.raiz.TabIndex = 0;
            // 
            // pnlTitulo
            // 
            this.pnlTitulo.Controls.Add(this.lblTitulo);
            this.pnlTitulo.Controls.Add(this.lblSubtitulo);
            this.pnlTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTitulo.Location = new System.Drawing.Point(0, 0);
            this.pnlTitulo.Margin = new System.Windows.Forms.Padding(0);
            this.pnlTitulo.Name = "pnlTitulo";
            this.pnlTitulo.Size = new System.Drawing.Size(918, 72);
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
            this.lblTitulo.Size = new System.Drawing.Size(226, 37);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Pontos de coleta";
            // 
            // lblSubtitulo
            // 
            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblSubtitulo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtitulo.ForeColor = System.Drawing.Color.FromArgb(106, 120, 133);
            this.lblSubtitulo.Location = new System.Drawing.Point(2, 42);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Size = new System.Drawing.Size(520, 19);
            this.lblSubtitulo.TabIndex = 1;
            this.lblSubtitulo.Text = "Cadastre, consulte, edite e exclua os locais onde o lixo eletrônico pode ser entregue.";
            // 
            // pnlBarra
            // 
            this.pnlBarra.Controls.Add(this.lblBusca);
            this.pnlBarra.Controls.Add(this.txtBusca);
            this.pnlBarra.Controls.Add(this.btnBuscar);
            this.pnlBarra.Controls.Add(this.btnLimpar);
            this.pnlBarra.Controls.Add(this.lblStatus);
            this.pnlBarra.Controls.Add(this.flowAcoes);
            this.pnlBarra.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBarra.Location = new System.Drawing.Point(0, 72);
            this.pnlBarra.Margin = new System.Windows.Forms.Padding(0);
            this.pnlBarra.Name = "pnlBarra";
            this.pnlBarra.Size = new System.Drawing.Size(918, 92);
            this.pnlBarra.TabIndex = 1;
            // 
            // lblBusca
            // 
            this.lblBusca.AutoSize = true;
            this.lblBusca.BackColor = System.Drawing.Color.Transparent;
            this.lblBusca.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBusca.ForeColor = System.Drawing.Color.FromArgb(106, 120, 133);
            this.lblBusca.Location = new System.Drawing.Point(0, 8);
            this.lblBusca.Name = "lblBusca";
            this.lblBusca.Size = new System.Drawing.Size(300, 17);
            this.lblBusca.TabIndex = 0;
            this.lblBusca.Text = "Buscar por tipo de resíduo (ex.: pilhas, TVs, cabos)";
            // 
            // txtBusca
            // 
            this.txtBusca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBusca.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusca.Location = new System.Drawing.Point(0, 34);
            this.txtBusca.Name = "txtBusca";
            this.txtBusca.Size = new System.Drawing.Size(320, 26);
            this.txtBusca.TabIndex = 1;
            this.txtBusca.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBusca_KeyDown);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(156, 39, 176);
            this.btnBuscar.Cor = System.Drawing.Color.FromArgb(156, 39, 176);
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Location = new System.Drawing.Point(332, 33);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(96, 33);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.White;
            this.btnLimpar.Cor = System.Drawing.Color.FromArgb(120, 134, 148);
            this.btnLimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Location = new System.Drawing.Point(436, 33);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Secundario = true;
            this.btnLimpar.Size = new System.Drawing.Size(90, 33);
            this.btnLimpar.TabIndex = 3;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(106, 120, 133);
            this.lblStatus.Location = new System.Drawing.Point(0, 70);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(210, 17);
            this.lblStatus.TabIndex = 4;
            this.lblStatus.Text = "0 ponto(s) de coleta cadastrado(s)";
            // 
            // flowAcoes
            // 
            this.flowAcoes.AutoSize = true;
            this.flowAcoes.Controls.Add(this.btnNovo);
            this.flowAcoes.Controls.Add(this.btnEditar);
            this.flowAcoes.Controls.Add(this.btnExcluir);
            this.flowAcoes.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowAcoes.Location = new System.Drawing.Point(582, 0);
            this.flowAcoes.Name = "flowAcoes";
            this.flowAcoes.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.flowAcoes.Size = new System.Drawing.Size(336, 92);
            this.flowAcoes.TabIndex = 5;
            this.flowAcoes.WrapContents = false;
            // 
            // btnNovo
            // 
            this.btnNovo.BackColor = System.Drawing.Color.FromArgb(39, 160, 94);
            this.btnNovo.Cor = System.Drawing.Color.FromArgb(39, 160, 94);
            this.btnNovo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovo.Location = new System.Drawing.Point(0, 32);
            this.btnNovo.Margin = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(120, 36);
            this.btnNovo.TabIndex = 0;
            this.btnNovo.Text = "Novo ponto";
            this.btnNovo.UseVisualStyleBackColor = false;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(240, 165, 0);
            this.btnEditar.Cor = System.Drawing.Color.FromArgb(240, 165, 0);
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Location = new System.Drawing.Point(128, 32);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(100, 36);
            this.btnEditar.TabIndex = 1;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.FromArgb(214, 69, 65);
            this.btnExcluir.Cor = System.Drawing.Color.FromArgb(214, 69, 65);
            this.btnExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Location = new System.Drawing.Point(236, 32);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(0);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(100, 36);
            this.btnExcluir.TabIndex = 2;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
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
            this.colId,
            this.colEstabelecimento,
            this.colEndereco,
            this.colTelefone,
            this.colHorario,
            this.colResiduos});
            this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid.Location = new System.Drawing.Point(0, 168);
            this.grid.Margin = new System.Windows.Forms.Padding(0, 4, 0, 14);
            this.grid.MultiSelect = false;
            this.grid.Name = "grid";
            this.grid.ReadOnly = true;
            this.grid.RowHeadersVisible = false;
            this.grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid.Size = new System.Drawing.Size(918, 276);
            this.grid.TabIndex = 2;
            this.grid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_CellDoubleClick);
            this.grid.SelectionChanged += new System.EventHandler(this.grid_SelectionChanged);
            // 
            // colId
            // 
            this.colId.FillWeight = 7F;
            this.colId.HeaderText = "ID";
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            this.colId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colEstabelecimento
            // 
            this.colEstabelecimento.FillWeight = 24F;
            this.colEstabelecimento.HeaderText = "Estabelecimento";
            this.colEstabelecimento.Name = "colEstabelecimento";
            this.colEstabelecimento.ReadOnly = true;
            this.colEstabelecimento.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colEndereco
            // 
            this.colEndereco.FillWeight = 25F;
            this.colEndereco.HeaderText = "Endereço";
            this.colEndereco.Name = "colEndereco";
            this.colEndereco.ReadOnly = true;
            this.colEndereco.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colTelefone
            // 
            this.colTelefone.FillWeight = 13F;
            this.colTelefone.HeaderText = "Telefone";
            this.colTelefone.Name = "colTelefone";
            this.colTelefone.ReadOnly = true;
            this.colTelefone.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colHorario
            // 
            this.colHorario.FillWeight = 15F;
            this.colHorario.HeaderText = "Horário";
            this.colHorario.Name = "colHorario";
            this.colHorario.ReadOnly = true;
            this.colHorario.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colResiduos
            // 
            this.colResiduos.FillWeight = 28F;
            this.colResiduos.HeaderText = "Resíduos aceitos";
            this.colResiduos.Name = "colResiduos";
            this.colResiduos.ReadOnly = true;
            this.colResiduos.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // cartaoDetalhes
            // 
            this.cartaoDetalhes.BackColor = System.Drawing.Color.White;
            this.cartaoDetalhes.Controls.Add(this.lblDetTitulo);
            this.cartaoDetalhes.Controls.Add(this.lblRotNome);
            this.cartaoDetalhes.Controls.Add(this.lblNome);
            this.cartaoDetalhes.Controls.Add(this.lblRotEndereco);
            this.cartaoDetalhes.Controls.Add(this.lblEndereco);
            this.cartaoDetalhes.Controls.Add(this.lblRotTelefone);
            this.cartaoDetalhes.Controls.Add(this.lblTelefone);
            this.cartaoDetalhes.Controls.Add(this.lblRotHorario);
            this.cartaoDetalhes.Controls.Add(this.lblHorario);
            this.cartaoDetalhes.Controls.Add(this.lblRotResiduos);
            this.cartaoDetalhes.Controls.Add(this.flowResiduos);
            this.cartaoDetalhes.Controls.Add(this.lblSemSelecao);
            this.cartaoDetalhes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cartaoDetalhes.Location = new System.Drawing.Point(0, 458);
            this.cartaoDetalhes.Margin = new System.Windows.Forms.Padding(0);
            this.cartaoDetalhes.Name = "cartaoDetalhes";
            this.cartaoDetalhes.Size = new System.Drawing.Size(918, 196);
            this.cartaoDetalhes.TabIndex = 3;
            this.cartaoDetalhes.Resize += new System.EventHandler(this.cartaoDetalhes_Resize);
            // 
            // lblDetTitulo
            // 
            this.lblDetTitulo.AutoSize = true;
            this.lblDetTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblDetTitulo.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetTitulo.ForeColor = System.Drawing.Color.FromArgb(106, 120, 133);
            this.lblDetTitulo.Location = new System.Drawing.Point(22, 14);
            this.lblDetTitulo.Name = "lblDetTitulo";
            this.lblDetTitulo.Size = new System.Drawing.Size(205, 15);
            this.lblDetTitulo.TabIndex = 0;
            this.lblDetTitulo.Text = "DETALHES DO PONTO SELECIONADO";
            // 
            // lblRotNome
            // 
            this.lblRotNome.AutoSize = true;
            this.lblRotNome.BackColor = System.Drawing.Color.Transparent;
            this.lblRotNome.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRotNome.ForeColor = System.Drawing.Color.FromArgb(106, 120, 133);
            this.lblRotNome.Location = new System.Drawing.Point(22, 42);
            this.lblRotNome.Name = "lblRotNome";
            this.lblRotNome.Size = new System.Drawing.Size(92, 15);
            this.lblRotNome.TabIndex = 1;
            this.lblRotNome.Text = "Estabelecimento";
            // 
            // lblNome
            // 
            this.lblNome.AutoEllipsis = true;
            this.lblNome.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.Color.FromArgb(27, 38, 49);
            this.lblNome.Location = new System.Drawing.Point(22, 64);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(280, 24);
            this.lblNome.TabIndex = 2;
            this.lblNome.Text = "-";
            // 
            // lblRotEndereco
            // 
            this.lblRotEndereco.AutoSize = true;
            this.lblRotEndereco.BackColor = System.Drawing.Color.Transparent;
            this.lblRotEndereco.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRotEndereco.ForeColor = System.Drawing.Color.FromArgb(106, 120, 133);
            this.lblRotEndereco.Location = new System.Drawing.Point(22, 104);
            this.lblRotEndereco.Name = "lblRotEndereco";
            this.lblRotEndereco.Size = new System.Drawing.Size(56, 15);
            this.lblRotEndereco.TabIndex = 3;
            this.lblRotEndereco.Text = "Endereço";
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoEllipsis = true;
            this.lblEndereco.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndereco.ForeColor = System.Drawing.Color.FromArgb(27, 38, 49);
            this.lblEndereco.Location = new System.Drawing.Point(22, 126);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(280, 24);
            this.lblEndereco.TabIndex = 4;
            this.lblEndereco.Text = "-";
            // 
            // lblRotTelefone
            // 
            this.lblRotTelefone.AutoSize = true;
            this.lblRotTelefone.BackColor = System.Drawing.Color.Transparent;
            this.lblRotTelefone.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRotTelefone.ForeColor = System.Drawing.Color.FromArgb(106, 120, 133);
            this.lblRotTelefone.Location = new System.Drawing.Point(330, 42);
            this.lblRotTelefone.Name = "lblRotTelefone";
            this.lblRotTelefone.Size = new System.Drawing.Size(51, 15);
            this.lblRotTelefone.TabIndex = 5;
            this.lblRotTelefone.Text = "Telefone";
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoEllipsis = true;
            this.lblTelefone.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefone.ForeColor = System.Drawing.Color.FromArgb(27, 38, 49);
            this.lblTelefone.Location = new System.Drawing.Point(330, 64);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(170, 24);
            this.lblTelefone.TabIndex = 6;
            this.lblTelefone.Text = "-";
            // 
            // lblRotHorario
            // 
            this.lblRotHorario.AutoSize = true;
            this.lblRotHorario.BackColor = System.Drawing.Color.Transparent;
            this.lblRotHorario.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRotHorario.ForeColor = System.Drawing.Color.FromArgb(106, 120, 133);
            this.lblRotHorario.Location = new System.Drawing.Point(330, 104);
            this.lblRotHorario.Name = "lblRotHorario";
            this.lblRotHorario.Size = new System.Drawing.Size(144, 15);
            this.lblRotHorario.TabIndex = 7;
            this.lblRotHorario.Text = "Horário de funcionamento";
            // 
            // lblHorario
            // 
            this.lblHorario.AutoEllipsis = true;
            this.lblHorario.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHorario.ForeColor = System.Drawing.Color.FromArgb(27, 38, 49);
            this.lblHorario.Location = new System.Drawing.Point(330, 126);
            this.lblHorario.Name = "lblHorario";
            this.lblHorario.Size = new System.Drawing.Size(170, 24);
            this.lblHorario.TabIndex = 8;
            this.lblHorario.Text = "-";
            // 
            // lblRotResiduos
            // 
            this.lblRotResiduos.AutoSize = true;
            this.lblRotResiduos.BackColor = System.Drawing.Color.Transparent;
            this.lblRotResiduos.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRotResiduos.ForeColor = System.Drawing.Color.FromArgb(106, 120, 133);
            this.lblRotResiduos.Location = new System.Drawing.Point(530, 42);
            this.lblRotResiduos.Name = "lblRotResiduos";
            this.lblRotResiduos.Size = new System.Drawing.Size(94, 15);
            this.lblRotResiduos.TabIndex = 9;
            this.lblRotResiduos.Text = "Resíduos aceitos";
            // 
            // flowResiduos
            // 
            this.flowResiduos.Location = new System.Drawing.Point(530, 66);
            this.flowResiduos.Name = "flowResiduos";
            this.flowResiduos.Size = new System.Drawing.Size(366, 114);
            this.flowResiduos.TabIndex = 10;
            // 
            // lblSemSelecao
            // 
            this.lblSemSelecao.BackColor = System.Drawing.Color.White;
            this.lblSemSelecao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSemSelecao.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSemSelecao.ForeColor = System.Drawing.Color.FromArgb(106, 120, 133);
            this.lblSemSelecao.Location = new System.Drawing.Point(0, 0);
            this.lblSemSelecao.Name = "lblSemSelecao";
            this.lblSemSelecao.Size = new System.Drawing.Size(918, 196);
            this.lblSemSelecao.TabIndex = 11;
            this.lblSemSelecao.Text = "Selecione um ponto na tabela para ver os detalhes.";
            this.lblSemSelecao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlRodape
            // 
            this.pnlRodape.Controls.Add(this.btnVoltar);
            this.pnlRodape.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRodape.Location = new System.Drawing.Point(0, 654);
            this.pnlRodape.Margin = new System.Windows.Forms.Padding(0);
            this.pnlRodape.Name = "pnlRodape";
            this.pnlRodape.Padding = new System.Windows.Forms.Padding(0, 14, 0, 0);
            this.pnlRodape.Size = new System.Drawing.Size(918, 50);
            this.pnlRodape.TabIndex = 4;
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
            // PainelPontos
            // 
            this.BackColor = System.Drawing.Color.FromArgb(243, 246, 249);
            this.Controls.Add(this.raiz);
            this.Name = "PainelPontos";
            this.Size = new System.Drawing.Size(918, 704);
            this.raiz.ResumeLayout(false);
            this.pnlTitulo.ResumeLayout(false);
            this.pnlTitulo.PerformLayout();
            this.pnlBarra.ResumeLayout(false);
            this.pnlBarra.PerformLayout();
            this.flowAcoes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.cartaoDetalhes.ResumeLayout(false);
            this.cartaoDetalhes.PerformLayout();
            this.pnlRodape.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel raiz;
        private System.Windows.Forms.Panel pnlTitulo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.Panel pnlBarra;
        private System.Windows.Forms.Label lblBusca;
        private System.Windows.Forms.TextBox txtBusca;
        private BotaoAcao btnBuscar;
        private BotaoAcao btnLimpar;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.FlowLayoutPanel flowAcoes;
        private BotaoAcao btnNovo;
        private BotaoAcao btnEditar;
        private BotaoAcao btnExcluir;
        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEstabelecimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEndereco;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTelefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHorario;
        private System.Windows.Forms.DataGridViewTextBoxColumn colResiduos;
        private Cartao cartaoDetalhes;
        private System.Windows.Forms.Label lblDetTitulo;
        private System.Windows.Forms.Label lblRotNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblRotEndereco;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.Label lblRotTelefone;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Label lblRotHorario;
        private System.Windows.Forms.Label lblHorario;
        private System.Windows.Forms.Label lblRotResiduos;
        private System.Windows.Forms.FlowLayoutPanel flowResiduos;
        private System.Windows.Forms.Label lblSemSelecao;
        private System.Windows.Forms.Panel pnlRodape;
        private BotaoAcao btnVoltar;
    }
}
