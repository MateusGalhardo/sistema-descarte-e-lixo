namespace SistemaDescarteEletronico
{
    partial class FormPontoColeta
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
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.lblHorario = new System.Windows.Forms.Label();
            this.txtHorario = new System.Windows.Forms.TextBox();
            this.lblResiduos = new System.Windows.Forms.Label();
            this.flowResiduos = new System.Windows.Forms.FlowLayoutPanel();
            this.chkCelulares = new System.Windows.Forms.CheckBox();
            this.chkComputadores = new System.Windows.Forms.CheckBox();
            this.chkPilhas = new System.Windows.Forms.CheckBox();
            this.chkTvs = new System.Windows.Forms.CheckBox();
            this.chkCabos = new System.Windows.Forms.CheckBox();
            this.chkEletrodomesticos = new System.Windows.Forms.CheckBox();
            this.lblOutros = new System.Windows.Forms.Label();
            this.txtOutros = new System.Windows.Forms.TextBox();
            this.lblErro = new System.Windows.Forms.Label();
            this.btnCancelar = new SistemaDescarteEletronico.BotaoAcao();
            this.btnSalvar = new SistemaDescarteEletronico.BotaoAcao();
            this.pnlTopo.SuspendLayout();
            this.flowResiduos.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTopo
            // 
            this.pnlTopo.BackColor = System.Drawing.Color.FromArgb(39, 160, 94);
            this.pnlTopo.Controls.Add(this.lblTitulo);
            this.pnlTopo.Controls.Add(this.lblSubtitulo);
            this.pnlTopo.Location = new System.Drawing.Point(0, 0);
            this.pnlTopo.Name = "pnlTopo";
            this.pnlTopo.Size = new System.Drawing.Size(640, 84);
            this.pnlTopo.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(32, 14);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(284, 31);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Cadastrar ponto de coleta";
            // 
            // lblSubtitulo
            // 
            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblSubtitulo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtitulo.ForeColor = System.Drawing.Color.White;
            this.lblSubtitulo.Location = new System.Drawing.Point(34, 50);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Size = new System.Drawing.Size(266, 19);
            this.lblSubtitulo.TabIndex = 1;
            this.lblSubtitulo.Text = "Preencha os dados do novo local de descarte.";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.BackColor = System.Drawing.Color.Transparent;
            this.lblNome.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.Color.FromArgb(106, 120, 133);
            this.lblNome.Location = new System.Drawing.Point(32, 104);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(161, 17);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome do estabelecimento *";
            // 
            // txtNome
            // 
            this.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNome.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(32, 128);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(576, 26);
            this.txtNome.TabIndex = 2;
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.BackColor = System.Drawing.Color.Transparent;
            this.lblEndereco.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndereco.ForeColor = System.Drawing.Color.FromArgb(106, 120, 133);
            this.lblEndereco.Location = new System.Drawing.Point(32, 172);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(121, 17);
            this.lblEndereco.TabIndex = 3;
            this.lblEndereco.Text = "Endereço completo *";
            // 
            // txtEndereco
            // 
            this.txtEndereco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEndereco.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEndereco.Location = new System.Drawing.Point(32, 196);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(576, 26);
            this.txtEndereco.TabIndex = 4;
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.BackColor = System.Drawing.Color.Transparent;
            this.lblTelefone.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefone.ForeColor = System.Drawing.Color.FromArgb(106, 120, 133);
            this.lblTelefone.Location = new System.Drawing.Point(32, 240);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(113, 17);
            this.lblTelefone.TabIndex = 5;
            this.lblTelefone.Text = "Telefone de contato";
            // 
            // txtTelefone
            // 
            this.txtTelefone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTelefone.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefone.Location = new System.Drawing.Point(32, 264);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(276, 26);
            this.txtTelefone.TabIndex = 6;
            // 
            // lblHorario
            // 
            this.lblHorario.AutoSize = true;
            this.lblHorario.BackColor = System.Drawing.Color.Transparent;
            this.lblHorario.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHorario.ForeColor = System.Drawing.Color.FromArgb(106, 120, 133);
            this.lblHorario.Location = new System.Drawing.Point(332, 240);
            this.lblHorario.Name = "lblHorario";
            this.lblHorario.Size = new System.Drawing.Size(145, 17);
            this.lblHorario.TabIndex = 7;
            this.lblHorario.Text = "Horário de funcionamento";
            // 
            // txtHorario
            // 
            this.txtHorario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHorario.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHorario.Location = new System.Drawing.Point(332, 264);
            this.txtHorario.Name = "txtHorario";
            this.txtHorario.Size = new System.Drawing.Size(276, 26);
            this.txtHorario.TabIndex = 8;
            // 
            // lblResiduos
            // 
            this.lblResiduos.AutoSize = true;
            this.lblResiduos.BackColor = System.Drawing.Color.Transparent;
            this.lblResiduos.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResiduos.ForeColor = System.Drawing.Color.FromArgb(106, 120, 133);
            this.lblResiduos.Location = new System.Drawing.Point(32, 308);
            this.lblResiduos.Name = "lblResiduos";
            this.lblResiduos.Size = new System.Drawing.Size(113, 17);
            this.lblResiduos.TabIndex = 9;
            this.lblResiduos.Text = "Resíduos aceitos *";
            // 
            // flowResiduos
            // 
            this.flowResiduos.Controls.Add(this.chkCelulares);
            this.flowResiduos.Controls.Add(this.chkComputadores);
            this.flowResiduos.Controls.Add(this.chkPilhas);
            this.flowResiduos.Controls.Add(this.chkTvs);
            this.flowResiduos.Controls.Add(this.chkCabos);
            this.flowResiduos.Controls.Add(this.chkEletrodomesticos);
            this.flowResiduos.Location = new System.Drawing.Point(32, 332);
            this.flowResiduos.Name = "flowResiduos";
            this.flowResiduos.Size = new System.Drawing.Size(576, 84);
            this.flowResiduos.TabIndex = 10;
            // 
            // chkCelulares
            // 
            this.chkCelulares.AutoSize = false;
            this.chkCelulares.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCelulares.ForeColor = System.Drawing.Color.FromArgb(27, 38, 49);
            this.chkCelulares.Location = new System.Drawing.Point(0, 0);
            this.chkCelulares.Margin = new System.Windows.Forms.Padding(0, 0, 8, 6);
            this.chkCelulares.Name = "chkCelulares";
            this.chkCelulares.Size = new System.Drawing.Size(180, 32);
            this.chkCelulares.TabIndex = 0;
            this.chkCelulares.Text = "Celulares";
            this.chkCelulares.UseVisualStyleBackColor = true;
            // 
            // chkComputadores
            // 
            this.chkComputadores.AutoSize = false;
            this.chkComputadores.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkComputadores.ForeColor = System.Drawing.Color.FromArgb(27, 38, 49);
            this.chkComputadores.Location = new System.Drawing.Point(188, 0);
            this.chkComputadores.Margin = new System.Windows.Forms.Padding(0, 0, 8, 6);
            this.chkComputadores.Name = "chkComputadores";
            this.chkComputadores.Size = new System.Drawing.Size(180, 32);
            this.chkComputadores.TabIndex = 1;
            this.chkComputadores.Text = "Computadores";
            this.chkComputadores.UseVisualStyleBackColor = true;
            // 
            // chkPilhas
            // 
            this.chkPilhas.AutoSize = false;
            this.chkPilhas.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkPilhas.ForeColor = System.Drawing.Color.FromArgb(27, 38, 49);
            this.chkPilhas.Location = new System.Drawing.Point(376, 0);
            this.chkPilhas.Margin = new System.Windows.Forms.Padding(0, 0, 8, 6);
            this.chkPilhas.Name = "chkPilhas";
            this.chkPilhas.Size = new System.Drawing.Size(180, 32);
            this.chkPilhas.TabIndex = 2;
            this.chkPilhas.Text = "Pilhas/Baterias";
            this.chkPilhas.UseVisualStyleBackColor = true;
            // 
            // chkTvs
            // 
            this.chkTvs.AutoSize = false;
            this.chkTvs.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTvs.ForeColor = System.Drawing.Color.FromArgb(27, 38, 49);
            this.chkTvs.Location = new System.Drawing.Point(0, 38);
            this.chkTvs.Margin = new System.Windows.Forms.Padding(0, 0, 8, 6);
            this.chkTvs.Name = "chkTvs";
            this.chkTvs.Size = new System.Drawing.Size(180, 32);
            this.chkTvs.TabIndex = 3;
            this.chkTvs.Text = "TVs";
            this.chkTvs.UseVisualStyleBackColor = true;
            // 
            // chkCabos
            // 
            this.chkCabos.AutoSize = false;
            this.chkCabos.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCabos.ForeColor = System.Drawing.Color.FromArgb(27, 38, 49);
            this.chkCabos.Location = new System.Drawing.Point(188, 38);
            this.chkCabos.Margin = new System.Windows.Forms.Padding(0, 0, 8, 6);
            this.chkCabos.Name = "chkCabos";
            this.chkCabos.Size = new System.Drawing.Size(180, 32);
            this.chkCabos.TabIndex = 4;
            this.chkCabos.Text = "Cabos";
            this.chkCabos.UseVisualStyleBackColor = true;
            // 
            // chkEletrodomesticos
            // 
            this.chkEletrodomesticos.AutoSize = false;
            this.chkEletrodomesticos.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkEletrodomesticos.ForeColor = System.Drawing.Color.FromArgb(27, 38, 49);
            this.chkEletrodomesticos.Location = new System.Drawing.Point(376, 38);
            this.chkEletrodomesticos.Margin = new System.Windows.Forms.Padding(0, 0, 8, 6);
            this.chkEletrodomesticos.Name = "chkEletrodomesticos";
            this.chkEletrodomesticos.Size = new System.Drawing.Size(180, 32);
            this.chkEletrodomesticos.TabIndex = 5;
            this.chkEletrodomesticos.Text = "Eletrodomésticos";
            this.chkEletrodomesticos.UseVisualStyleBackColor = true;
            // 
            // lblOutros
            // 
            this.lblOutros.AutoSize = true;
            this.lblOutros.BackColor = System.Drawing.Color.Transparent;
            this.lblOutros.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutros.ForeColor = System.Drawing.Color.FromArgb(106, 120, 133);
            this.lblOutros.Location = new System.Drawing.Point(32, 426);
            this.lblOutros.Name = "lblOutros";
            this.lblOutros.Size = new System.Drawing.Size(221, 17);
            this.lblOutros.TabIndex = 11;
            this.lblOutros.Text = "Outros resíduos (separe por vírgula)";
            // 
            // txtOutros
            // 
            this.txtOutros.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOutros.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOutros.Location = new System.Drawing.Point(32, 450);
            this.txtOutros.Name = "txtOutros";
            this.txtOutros.Size = new System.Drawing.Size(576, 26);
            this.txtOutros.TabIndex = 12;
            // 
            // lblErro
            // 
            this.lblErro.AutoSize = true;
            this.lblErro.BackColor = System.Drawing.Color.Transparent;
            this.lblErro.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErro.ForeColor = System.Drawing.Color.FromArgb(214, 69, 65);
            this.lblErro.Location = new System.Drawing.Point(32, 490);
            this.lblErro.Name = "lblErro";
            this.lblErro.Size = new System.Drawing.Size(0, 17);
            this.lblErro.TabIndex = 13;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.White;
            this.btnCancelar.Cor = System.Drawing.Color.FromArgb(120, 134, 148);
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Location = new System.Drawing.Point(32, 580);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Secundario = true;
            this.btnCancelar.Size = new System.Drawing.Size(120, 38);
            this.btnCancelar.TabIndex = 14;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.FromArgb(39, 160, 94);
            this.btnSalvar.Cor = System.Drawing.Color.FromArgb(39, 160, 94);
            this.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Location = new System.Drawing.Point(438, 580);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(170, 38);
            this.btnSalvar.TabIndex = 15;
            this.btnSalvar.Text = "Cadastrar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // FormPontoColeta
            // 
            this.AcceptButton = this.btnSalvar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(640, 640);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.lblErro);
            this.Controls.Add(this.txtOutros);
            this.Controls.Add(this.lblOutros);
            this.Controls.Add(this.flowResiduos);
            this.Controls.Add(this.lblResiduos);
            this.Controls.Add(this.txtHorario);
            this.Controls.Add(this.lblHorario);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.lblEndereco);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.pnlTopo);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormPontoColeta";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cadastrar ponto de coleta";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ConfirmarSaida);
            this.pnlTopo.ResumeLayout(false);
            this.pnlTopo.PerformLayout();
            this.flowResiduos.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTopo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.Label lblHorario;
        private System.Windows.Forms.TextBox txtHorario;
        private System.Windows.Forms.Label lblResiduos;
        private System.Windows.Forms.FlowLayoutPanel flowResiduos;
        private System.Windows.Forms.CheckBox chkCelulares;
        private System.Windows.Forms.CheckBox chkComputadores;
        private System.Windows.Forms.CheckBox chkPilhas;
        private System.Windows.Forms.CheckBox chkTvs;
        private System.Windows.Forms.CheckBox chkCabos;
        private System.Windows.Forms.CheckBox chkEletrodomesticos;
        private System.Windows.Forms.Label lblOutros;
        private System.Windows.Forms.TextBox txtOutros;
        private System.Windows.Forms.Label lblErro;
        private BotaoAcao btnCancelar;
        private BotaoAcao btnSalvar;
    }
}
