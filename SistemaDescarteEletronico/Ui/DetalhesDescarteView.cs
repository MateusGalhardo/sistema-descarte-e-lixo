using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace SistemaDescarteEletronico
{
    // mostra o resultado e os dados de um descarte
    public partial class DetalhesDescarteView : UserControl
    {
        private bool permiteDuasLinhas = true;

        [DefaultValue(true)]
        public bool PermiteDuasLinhas
        {
            get { return permiteDuasLinhas; }
            set { permiteDuasLinhas = value; }
        }

        public DetalhesDescarteView()
        {
            InitializeComponent();
            DoubleBuffered = true;

            lblVazio.BringToFront();
        }

        private void pnlResultado_Resize(object sender, EventArgs e)
        {
            barra.Width = Math.Max(50, pnlResultado.Width - 52);
            lblMensagem.Width = Math.Max(50, pnlResultado.Width - 52);
        }

        private void pnlInfo_Resize(object sender, EventArgs e)
        {
            foreach (Control controle in pnlInfo.Controls)
            {
                if ((controle.Tag as string) == "valor")
                {
                    controle.Width = Math.Max(60, pnlInfo.ClientSize.Width - 160);
                }
            }
        }

        // limpa os detalhes
        public void Limpar()
        {
            lblVazio.Visible = true;
            lblVazio.BringToFront();
        }

        public void Mostrar(Descarte descarte)
        {
            lblVazio.Visible = false;

            ClassificacaoDescarte classificacao = descarte.Resultado.Classificacao;
            Color fundo = Tema.CorFundoDaClassificacao(classificacao);

            pnlResultado.BackColor = fundo;
            lblDestino.Text = "● " + AvaliadorTriagem.ObterRotulo(classificacao);
            lblDestino.ForeColor = Tema.CorTextoDaClassificacao(classificacao);
            lblPontos.Text = descarte.Resultado.Pontuacao + " / " + AvaliadorTriagem.PontuacaoMaxima + " pontos";
            barra.BackColor = fundo;
            barra.CorBarra = Tema.CorDaClassificacao(classificacao);
            barra.Valor = descarte.Resultado.Pontuacao;
            lblMensagem.Text = AvaliadorTriagem.ObterMensagem(classificacao);

            pnlInfo.Controls.Clear();
            int y = 14;

            AdicionarSecao("EQUIPAMENTO", ref y);
            AdicionarLinha("Equipamento", descarte.NomeCompleto, true, ref y);
            AdicionarLinha("Data", descarte.DataDescarte.ToString("dd/MM/yyyy HH:mm"), false, ref y);

            y += 8;
            AdicionarSecao("RESPOSTAS DA TRIAGEM", ref y);
            string[] respostas = Questionario.DescreverRespostas(descarte.Triagem);
            for (int i = 0; i < respostas.Length; i++)
            {
                AdicionarLinha(Questionario.RotulosCriterios[i], respostas[i], false, ref y);
            }
        }

        private void AdicionarSecao(string titulo, ref int y)
        {
            Label label = Tema.CriarLabel(titulo, 8.5f, FontStyle.Bold, Tema.TextoSecundario);
            label.Location = new Point(24, y);
            pnlInfo.Controls.Add(label);
            y += 26;
        }

        private void AdicionarLinha(string rotulo, string valor, bool multilinha, ref int y)
        {
            // usa duas linhas só se o texto não couber
            int larguraDisponivel = Math.Max(60, pnlInfo.ClientSize.Width - 160);
            bool duasLinhas = multilinha && permiteDuasLinhas &&
                TextRenderer.MeasureText(valor, Tema.Fonte(10f, FontStyle.Bold)).Width > larguraDisponivel - 8;

            Label lblRotulo = Tema.CriarLabel(rotulo, 10f, FontStyle.Regular, Tema.TextoSecundario);
            lblRotulo.Location = new Point(24, y);

            Label lblValor = new Label();
            lblValor.AutoSize = false;
            lblValor.AutoEllipsis = !duasLinhas;
            lblValor.Font = Tema.Fonte(10f, FontStyle.Bold);
            lblValor.ForeColor = Tema.TextoPrincipal;
            lblValor.Text = valor;
            lblValor.Location = new Point(140, y);
            lblValor.Size = new Size(Math.Max(60, pnlInfo.ClientSize.Width - 160), duasLinhas ? 42 : 22);
            lblValor.Tag = "valor";

            pnlInfo.Controls.Add(lblRotulo);
            pnlInfo.Controls.Add(lblValor);
            y += duasLinhas ? 46 : 26;
        }
    }
}
