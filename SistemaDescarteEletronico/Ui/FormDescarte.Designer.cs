namespace SistemaDescarteEletronico
{
    partial class FormDescarte
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
            this.lblEtapa = new System.Windows.Forms.Label();
            this.pnlRodape = new System.Windows.Forms.Panel();
            this.btnCancelar = new SistemaDescarteEletronico.BotaoAcao();
            this.btnVoltar = new SistemaDescarteEletronico.BotaoAcao();
            this.btnAvancar = new SistemaDescarteEletronico.BotaoAcao();
            this.pnlEquipamento = new System.Windows.Forms.Panel();
            this.lblTipo = new System.Windows.Forms.Label();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.lblOutroTipo = new System.Windows.Forms.Label();
            this.txtOutroTipo = new System.Windows.Forms.TextBox();
            this.lblMarca = new System.Windows.Forms.Label();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.lblModelo = new System.Windows.Forms.Label();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.lblErro = new System.Windows.Forms.Label();
            this.lblDicaEquipamento = new System.Windows.Forms.Label();
            this.pnlTriagem = new System.Windows.Forms.Panel();
            this.lblProgresso = new System.Windows.Forms.Label();
            this.lblPercentual = new System.Windows.Forms.Label();
            this.barra = new SistemaDescarteEletronico.BarraProgresso();
            this.lblPergunta = new System.Windows.Forms.Label();
            this.flowOpcoes = new System.Windows.Forms.FlowLayoutPanel();
            this.lblDica = new System.Windows.Forms.Label();
            this.pnlResultado = new System.Windows.Forms.Panel();
            this.cartaoResultado = new SistemaDescarteEletronico.Cartao();
            this.detalhes = new SistemaDescarteEletronico.DetalhesDescarteView();
            this.pnlTopo.SuspendLayout();
            this.pnlRodape.SuspendLayout();
            this.pnlEquipamento.SuspendLayout();
            this.pnlTriagem.SuspendLayout();
            this.pnlResultado.SuspendLayout();
            this.cartaoResultado.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTopo
            // 
            this.pnlTopo.BackColor = System.Drawing.Color.FromArgb(39, 160, 94);
            this.pnlTopo.Controls.Add(this.lblTitulo);
            this.pnlTopo.Controls.Add(this.lblEtapa);
            this.pnlTopo.Location = new System.Drawing.Point(0, 0);
            this.pnlTopo.Name = "pnlTopo";
            this.pnlTopo.Size = new System.Drawing.Size(840, 92);
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
            this.lblTitulo.Size = new System.Drawing.Size(281, 32);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Novo descarte eletrônico";
            // 
            // lblEtapa
            // 
            this.lblEtapa.AutoSize = true;
            this.lblEtapa.BackColor = System.Drawing.Color.Transparent;
            this.lblEtapa.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEtapa.ForeColor = System.Drawing.Color.White;
            this.lblEtapa.Location = new System.Drawing.Point(38, 54);
            this.lblEtapa.Name = "lblEtapa";
            this.lblEtapa.Size = new System.Drawing.Size(170, 19);
            this.lblEtapa.TabIndex = 1;
            this.lblEtapa.Text = "Etapa 1 de 3  •  Equipamento";
            // 
            // pnlRodape
            // 
            this.pnlRodape.BackColor = System.Drawing.Color.FromArgb(243, 246, 249);
            this.pnlRodape.Controls.Add(this.btnCancelar);
            this.pnlRodape.Controls.Add(this.btnVoltar);
            this.pnlRodape.Controls.Add(this.btnAvancar);
            this.pnlRodape.Location = new System.Drawing.Point(0, 624);
            this.pnlRodape.Name = "pnlRodape";
            this.pnlRodape.Size = new System.Drawing.Size(840, 76);
            this.pnlRodape.TabIndex = 1;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.White;
            this.btnCancelar.Cor = System.Drawing.Color.FromArgb(120, 134, 148);
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Location = new System.Drawing.Point(36, 19);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Secundario = true;
            this.btnCancelar.Size = new System.Drawing.Size(120, 38);
            this.btnCancelar.TabIndex = 0;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.White;
            this.btnVoltar.Cor = System.Drawing.Color.FromArgb(120, 134, 148);
            this.btnVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Location = new System.Drawing.Point(484, 19);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Secundario = true;
            this.btnVoltar.Size = new System.Drawing.Size(120, 38);
            this.btnVoltar.TabIndex = 1;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnAvancar
            // 
            this.btnAvancar.BackColor = System.Drawing.Color.FromArgb(39, 160, 94);
            this.btnAvancar.Cor = System.Drawing.Color.FromArgb(39, 160, 94);
            this.btnAvancar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAvancar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAvancar.Location = new System.Drawing.Point(614, 19);
            this.btnAvancar.Name = "btnAvancar";
            this.btnAvancar.Size = new System.Drawing.Size(190, 38);
            this.btnAvancar.TabIndex = 2;
            this.btnAvancar.Text = "Iniciar triagem";
            this.btnAvancar.UseVisualStyleBackColor = false;
            this.btnAvancar.Click += new System.EventHandler(this.btnAvancar_Click);
            // 
            // pnlEquipamento
            // 
            this.pnlEquipamento.Controls.Add(this.lblTipo);
            this.pnlEquipamento.Controls.Add(this.cmbTipo);
            this.pnlEquipamento.Controls.Add(this.lblOutroTipo);
            this.pnlEquipamento.Controls.Add(this.txtOutroTipo);
            this.pnlEquipamento.Controls.Add(this.lblMarca);
            this.pnlEquipamento.Controls.Add(this.txtMarca);
            this.pnlEquipamento.Controls.Add(this.lblModelo);
            this.pnlEquipamento.Controls.Add(this.txtModelo);
            this.pnlEquipamento.Controls.Add(this.lblErro);
            this.pnlEquipamento.Controls.Add(this.lblDicaEquipamento);
            this.pnlEquipamento.Location = new System.Drawing.Point(0, 92);
            this.pnlEquipamento.Name = "pnlEquipamento";
            this.pnlEquipamento.Size = new System.Drawing.Size(840, 532);
            this.pnlEquipamento.TabIndex = 2;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.BackColor = System.Drawing.Color.Transparent;
            this.lblTipo.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.ForeColor = System.Drawing.Color.FromArgb(106, 120, 133);
            this.lblTipo.Location = new System.Drawing.Point(60, 40);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(107, 17);
            this.lblTipo.TabIndex = 0;
            this.lblTipo.Text = "Tipo de eletrônico";
            // 
            // cmbTipo
            // 
            this.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipo.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Location = new System.Drawing.Point(60, 66);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(330, 28);
            this.cmbTipo.TabIndex = 1;
            this.cmbTipo.SelectedIndexChanged += new System.EventHandler(this.cmbTipo_SelectedIndexChanged);
            // 
            // lblOutroTipo
            // 
            this.lblOutroTipo.AutoSize = true;
            this.lblOutroTipo.BackColor = System.Drawing.Color.Transparent;
            this.lblOutroTipo.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutroTipo.ForeColor = System.Drawing.Color.FromArgb(106, 120, 133);
            this.lblOutroTipo.Location = new System.Drawing.Point(430, 40);
            this.lblOutroTipo.Name = "lblOutroTipo";
            this.lblOutroTipo.Size = new System.Drawing.Size(98, 17);
            this.lblOutroTipo.TabIndex = 2;
            this.lblOutroTipo.Text = "Qual é o tipo? *";
            // 
            // txtOutroTipo
            // 
            this.txtOutroTipo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOutroTipo.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOutroTipo.Location = new System.Drawing.Point(430, 66);
            this.txtOutroTipo.Name = "txtOutroTipo";
            this.txtOutroTipo.Size = new System.Drawing.Size(350, 27);
            this.txtOutroTipo.TabIndex = 3;
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.BackColor = System.Drawing.Color.Transparent;
            this.lblMarca.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca.ForeColor = System.Drawing.Color.FromArgb(106, 120, 133);
            this.lblMarca.Location = new System.Drawing.Point(60, 130);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(50, 17);
            this.lblMarca.TabIndex = 4;
            this.lblMarca.Text = "Marca *";
            // 
            // txtMarca
            // 
            this.txtMarca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMarca.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMarca.Location = new System.Drawing.Point(60, 156);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(330, 27);
            this.txtMarca.TabIndex = 5;
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.BackColor = System.Drawing.Color.Transparent;
            this.lblModelo.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModelo.ForeColor = System.Drawing.Color.FromArgb(106, 120, 133);
            this.lblModelo.Location = new System.Drawing.Point(430, 130);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(58, 17);
            this.lblModelo.TabIndex = 6;
            this.lblModelo.Text = "Modelo *";
            // 
            // txtModelo
            // 
            this.txtModelo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtModelo.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModelo.Location = new System.Drawing.Point(430, 156);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(350, 27);
            this.txtModelo.TabIndex = 7;
            // 
            // lblErro
            // 
            this.lblErro.AutoSize = true;
            this.lblErro.BackColor = System.Drawing.Color.Transparent;
            this.lblErro.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErro.ForeColor = System.Drawing.Color.FromArgb(214, 69, 65);
            this.lblErro.Location = new System.Drawing.Point(60, 216);
            this.lblErro.Name = "lblErro";
            this.lblErro.Size = new System.Drawing.Size(0, 19);
            this.lblErro.TabIndex = 8;
            // 
            // lblDicaEquipamento
            // 
            this.lblDicaEquipamento.AutoSize = true;
            this.lblDicaEquipamento.BackColor = System.Drawing.Color.Transparent;
            this.lblDicaEquipamento.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDicaEquipamento.ForeColor = System.Drawing.Color.FromArgb(106, 120, 133);
            this.lblDicaEquipamento.Location = new System.Drawing.Point(60, 280);
            this.lblDicaEquipamento.Name = "lblDicaEquipamento";
            this.lblDicaEquipamento.Size = new System.Drawing.Size(412, 38);
            this.lblDicaEquipamento.TabIndex = 9;
            this.lblDicaEquipamento.Text = "Depois de informar o equipamento, vamos fazer uma triagem rápida\r\ncom 5 pergunta" +
    "s para classificar o melhor destino dele.";
            // 
            // pnlTriagem
            // 
            this.pnlTriagem.Controls.Add(this.lblProgresso);
            this.pnlTriagem.Controls.Add(this.lblPercentual);
            this.pnlTriagem.Controls.Add(this.barra);
            this.pnlTriagem.Controls.Add(this.lblPergunta);
            this.pnlTriagem.Controls.Add(this.flowOpcoes);
            this.pnlTriagem.Controls.Add(this.lblDica);
            this.pnlTriagem.Location = new System.Drawing.Point(0, 92);
            this.pnlTriagem.Name = "pnlTriagem";
            this.pnlTriagem.Size = new System.Drawing.Size(840, 532);
            this.pnlTriagem.TabIndex = 3;
            // 
            // lblProgresso
            // 
            this.lblProgresso.AutoSize = true;
            this.lblProgresso.BackColor = System.Drawing.Color.Transparent;
            this.lblProgresso.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProgresso.ForeColor = System.Drawing.Color.FromArgb(106, 120, 133);
            this.lblProgresso.Location = new System.Drawing.Point(60, 36);
            this.lblProgresso.Name = "lblProgresso";
            this.lblProgresso.Size = new System.Drawing.Size(106, 19);
            this.lblProgresso.TabIndex = 0;
            this.lblProgresso.Text = "Pergunta 1 de 5";
            // 
            // lblPercentual
            // 
            this.lblPercentual.BackColor = System.Drawing.Color.Transparent;
            this.lblPercentual.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPercentual.ForeColor = System.Drawing.Color.FromArgb(39, 160, 94);
            this.lblPercentual.Location = new System.Drawing.Point(680, 36);
            this.lblPercentual.Name = "lblPercentual";
            this.lblPercentual.Size = new System.Drawing.Size(100, 22);
            this.lblPercentual.TabIndex = 1;
            this.lblPercentual.Text = "20%";
            this.lblPercentual.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // barra
            // 
            this.barra.BackColor = System.Drawing.Color.White;
            this.barra.Location = new System.Drawing.Point(60, 66);
            this.barra.Name = "barra";
            this.barra.Size = new System.Drawing.Size(720, 12);
            this.barra.TabIndex = 2;
            this.barra.Text = "barra";
            this.barra.Valor = 20;
            // 
            // lblPergunta
            // 
            this.lblPergunta.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPergunta.ForeColor = System.Drawing.Color.FromArgb(27, 38, 49);
            this.lblPergunta.Location = new System.Drawing.Point(60, 130);
            this.lblPergunta.Name = "lblPergunta";
            this.lblPergunta.Size = new System.Drawing.Size(720, 80);
            this.lblPergunta.TabIndex = 3;
            this.lblPergunta.Text = "O aparelho liga?";
            // 
            // flowOpcoes
            // 
            this.flowOpcoes.Location = new System.Drawing.Point(60, 230);
            this.flowOpcoes.Name = "flowOpcoes";
            this.flowOpcoes.Size = new System.Drawing.Size(740, 170);
            this.flowOpcoes.TabIndex = 4;
            // 
            // lblDica
            // 
            this.lblDica.AutoSize = true;
            this.lblDica.BackColor = System.Drawing.Color.Transparent;
            this.lblDica.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDica.ForeColor = System.Drawing.Color.FromArgb(106, 120, 133);
            this.lblDica.Location = new System.Drawing.Point(60, 430);
            this.lblDica.Name = "lblDica";
            this.lblDica.Size = new System.Drawing.Size(207, 19);
            this.lblDica.TabIndex = 5;
            this.lblDica.Text = "Escolha uma opção para continuar.";
            // 
            // pnlResultado
            // 
            this.pnlResultado.Controls.Add(this.cartaoResultado);
            this.pnlResultado.Location = new System.Drawing.Point(0, 92);
            this.pnlResultado.Name = "pnlResultado";
            this.pnlResultado.Padding = new System.Windows.Forms.Padding(40, 28, 40, 20);
            this.pnlResultado.Size = new System.Drawing.Size(840, 532);
            this.pnlResultado.TabIndex = 4;
            // 
            // cartaoResultado
            // 
            this.cartaoResultado.BackColor = System.Drawing.Color.White;
            this.cartaoResultado.Controls.Add(this.detalhes);
            this.cartaoResultado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cartaoResultado.Location = new System.Drawing.Point(40, 28);
            this.cartaoResultado.Name = "cartaoResultado";
            this.cartaoResultado.Padding = new System.Windows.Forms.Padding(1);
            this.cartaoResultado.Size = new System.Drawing.Size(760, 484);
            this.cartaoResultado.TabIndex = 0;
            // 
            // detalhes
            // 
            this.detalhes.BackColor = System.Drawing.Color.White;
            this.detalhes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.detalhes.Location = new System.Drawing.Point(1, 1);
            this.detalhes.Name = "detalhes";
            this.detalhes.PermiteDuasLinhas = false;
            this.detalhes.Size = new System.Drawing.Size(758, 482);
            this.detalhes.TabIndex = 0;
            // 
            // FormDescarte
            // 
            this.AcceptButton = this.btnAvancar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(840, 700);
            this.Controls.Add(this.pnlResultado);
            this.Controls.Add(this.pnlTriagem);
            this.Controls.Add(this.pnlEquipamento);
            this.Controls.Add(this.pnlRodape);
            this.Controls.Add(this.pnlTopo);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormDescarte";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Realizar descarte eletrônico";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ConfirmarSaida);
            this.pnlTopo.ResumeLayout(false);
            this.pnlTopo.PerformLayout();
            this.pnlRodape.ResumeLayout(false);
            this.pnlEquipamento.ResumeLayout(false);
            this.pnlEquipamento.PerformLayout();
            this.pnlTriagem.ResumeLayout(false);
            this.pnlTriagem.PerformLayout();
            this.pnlResultado.ResumeLayout(false);
            this.cartaoResultado.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTopo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblEtapa;
        private System.Windows.Forms.Panel pnlRodape;
        private BotaoAcao btnCancelar;
        private BotaoAcao btnVoltar;
        private BotaoAcao btnAvancar;
        private System.Windows.Forms.Panel pnlEquipamento;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.Label lblOutroTipo;
        private System.Windows.Forms.TextBox txtOutroTipo;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.Label lblErro;
        private System.Windows.Forms.Label lblDicaEquipamento;
        private System.Windows.Forms.Panel pnlTriagem;
        private System.Windows.Forms.Label lblProgresso;
        private System.Windows.Forms.Label lblPercentual;
        private BarraProgresso barra;
        private System.Windows.Forms.Label lblPergunta;
        private System.Windows.Forms.FlowLayoutPanel flowOpcoes;
        private System.Windows.Forms.Label lblDica;
        private System.Windows.Forms.Panel pnlResultado;
        private Cartao cartaoResultado;
        private DetalhesDescarteView detalhes;
    }
}
