using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace SistemaDescarteEletronico
{
    // tela de cadastro e edição de ponto de coleta
    public partial class FormPontoColeta : Form
    {
        public string Nome { get; private set; }
        public string Endereco { get; private set; }
        public string Telefone { get; private set; }
        public string Horario { get; private set; }
        public List<string> Residuos { get; private set; }

        // guarda como os campos estavam quando abriu
        private readonly string estadoInicial;

        // construtor vazio pro designer
        public FormPontoColeta() : this(null)
        {
        }

        // ponto null = cadastro, senão é edição
        public FormPontoColeta(PontoDeColeta ponto)
        {
            InitializeComponent();

            if (ponto != null)
            {
                // na edição fica amarelo
                Text = "Editar ponto de coleta";
                pnlTopo.BackColor = Tema.Amarelo;
                lblTitulo.Text = "Editar ponto de coleta";
                lblSubtitulo.Text = "Deixe como está o que não quiser alterar.";
                btnSalvar.Cor = Tema.Amarelo;
                btnSalvar.Text = "Salvar alterações";
                PreencherComDados(ponto);
            }

            estadoInicial = EstadoAtual();
        }

        // junta os campos num texto pra comparar depois
        private string EstadoAtual()
        {
            string estado = txtNome.Text + "|" + txtEndereco.Text + "|" + txtTelefone.Text + "|" + txtHorario.Text + "|" + txtOutros.Text;
            foreach (CheckBox caixa in flowResiduos.Controls)
            {
                estado += caixa.Checked ? "|1" : "|0";
            }
            return estado;
        }

        // se mudou alguma coisa pergunta antes de fechar sem salvar
        private void ConfirmarSaida(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == DialogResult.OK || EstadoAtual() == estadoInicial) return;

            DialogResult resposta = MessageBox.Show(this,
                "Os dados preenchidos ainda não foram salvos.\nDeseja sair mesmo assim?",
                "Sair sem salvar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (resposta != DialogResult.Yes) e.Cancel = true;
        }

        private void PreencherComDados(PontoDeColeta ponto)
        {
            txtNome.Text = ponto.NomeEstabelecimento;
            txtEndereco.Text = ponto.Endereco;
            txtTelefone.Text = ponto.Telefone;
            txtHorario.Text = ponto.HorarioFuncionamento;

            // marca as caixinhas, o que não tiver vai pro campo outros
            List<string> extras = new List<string>();
            foreach (string residuo in ponto.ResiduosAceitos)
            {
                CheckBox correspondente = null;
                foreach (CheckBox caixa in flowResiduos.Controls)
                {
                    if (string.Equals(caixa.Text, residuo, StringComparison.OrdinalIgnoreCase))
                    {
                        correspondente = caixa;
                    }
                }

                if (correspondente != null) correspondente.Checked = true;
                else extras.Add(residuo);
            }
            txtOutros.Text = string.Join(", ", extras);
        }

        // botão cadastrar / salvar
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            List<string> residuos = new List<string>();
            foreach (CheckBox caixa in flowResiduos.Controls)
            {
                if (caixa.Checked) residuos.Add(caixa.Text);
            }
            foreach (string item in txtOutros.Text.Split(','))
            {
                string texto = item.Trim();
                bool jaExiste = residuos.Any(r => string.Equals(r, texto, StringComparison.OrdinalIgnoreCase));
                if (texto.Length > 0 && !jaExiste) residuos.Add(texto);
            }

            if (txtNome.Text.Trim().Length == 0)
            {
                Erro("Informe o nome do estabelecimento.", txtNome);
                return;
            }
            if (txtEndereco.Text.Trim().Length == 0)
            {
                Erro("Informe o endereço.", txtEndereco);
                return;
            }
            if (residuos.Count == 0)
            {
                Erro("Marque ao menos um resíduo aceito (ou digite em \"Outros\").", txtOutros);
                return;
            }

            Nome = txtNome.Text.Trim();
            Endereco = txtEndereco.Text.Trim();
            Telefone = txtTelefone.Text.Trim();
            Horario = txtHorario.Text.Trim();
            Residuos = residuos;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void Erro(string mensagem, Control campo)
        {
            lblErro.Text = mensagem;
            campo.Focus();
        }
    }
}
