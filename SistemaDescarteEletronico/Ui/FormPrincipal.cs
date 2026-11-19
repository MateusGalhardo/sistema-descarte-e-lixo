using System;
using System.Drawing;
using System.Windows.Forms;

namespace SistemaDescarteEletronico
{
    // tela principal: menu na esquerda e as telas na direita
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();

            // usa o ícone do executável
            Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);

            painelInicio.NovoDescarteSolicitado += delegate { RealizarDescarte(); };
            painelDescartes.NovoDescarteSolicitado += delegate { RealizarDescarte(); };
            painelInicio.NovoPontoSolicitado += delegate
            {
                Navegar(painelPontos, btnPontos);
                painelPontos.NovoPonto();
            };

            // botão voltar das telas volta pro início
            painelDescartes.VoltarSolicitado += delegate { Navegar(painelInicio, btnInicio); };
            painelPontos.VoltarSolicitado += delegate { Navegar(painelInicio, btnInicio); };

            Navegar(painelInicio, btnInicio);
        }

        // botões do menu

        private void btnInicio_Click(object sender, EventArgs e)
        {
            Navegar(painelInicio, btnInicio);
        }

        private void btnDescarte_Click(object sender, EventArgs e)
        {
            RealizarDescarte();
        }

        private void btnHistorico_Click(object sender, EventArgs e)
        {
            Navegar(painelDescartes, btnHistorico);
        }

        private void btnPontos_Click(object sender, EventArgs e)
        {
            Navegar(painelPontos, btnPontos);
        }

        private void btnCreditos_Click(object sender, EventArgs e)
        {
            using (FormCreditos creditos = new FormCreditos())
            {
                creditos.ShowDialog(this);
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        // navegação

        // mostra só a tela escolhida
        private void Navegar(PainelBase painel, BotaoMenu botao)
        {
            btnInicio.Ativo = botao == btnInicio;
            btnHistorico.Ativo = botao == btnHistorico;
            btnPontos.Ativo = botao == btnPontos;

            painelInicio.Visible = painel == painelInicio;
            painelDescartes.Visible = painel == painelDescartes;
            painelPontos.Visible = painel == painelPontos;

            painel.Atualizar();
        }

        // abre o descarte, depois mostra o histórico e onde descartar
        private void RealizarDescarte()
        {
            using (FormDescarte janela = new FormDescarte())
            {
                if (janela.ShowDialog(this) != DialogResult.OK) return;

                Navegar(painelDescartes, btnHistorico);
                painelDescartes.Selecionar(janela.DescarteRegistrado);

                using (FormOndeDescartar ondeDescartar = new FormOndeDescartar(janela.DescarteRegistrado))
                {
                    ondeDescartar.ShowDialog(this);
                }
            }
        }
    }
}
