using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace SistemaDescarteEletronico
{
    // tela inicial com os números e os atalhos
    public partial class PainelInicio : PainelBase
    {
        public event EventHandler NovoDescarteSolicitado;
        public event EventHandler NovoPontoSolicitado;

        public PainelInicio()
        {
            InitializeComponent();
        }

        // eventos

        private void btnDescarte_Click(object sender, EventArgs e)
        {
            EventHandler evento = NovoDescarteSolicitado;
            if (evento != null) evento(this, EventArgs.Empty);
        }

        private void btnPonto_Click(object sender, EventArgs e)
        {
            EventHandler evento = NovoPontoSolicitado;
            if (evento != null) evento(this, EventArgs.Empty);
        }

        public override void Atualizar()
        {
            lblPontos.Text = Repositorio.Pontos.Count.ToString();
            lblDescartes.Text = Repositorio.Descartes.Count.ToString();
            lblReutilizaveis.Text = Contar(ClassificacaoDescarte.Reutilizavel).ToString();
            lblReciclaveis.Text = Contar(ClassificacaoDescarte.Reciclavel).ToString();
            lblEspeciais.Text = Contar(ClassificacaoDescarte.DescarteEspecial).ToString();
        }

        private static int Contar(ClassificacaoDescarte classificacao)
        {
            return Repositorio.Descartes.Count(d => d.Resultado.Classificacao == classificacao);
        }
    }
}
