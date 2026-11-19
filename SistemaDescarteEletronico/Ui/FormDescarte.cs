using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace SistemaDescarteEletronico
{
    // tela do descarte em 3 etapas: equipamento, triagem e resultado
    public partial class FormDescarte : Form
    {
        private const int EtapaEquipamento = 0;
        private const int EtapaTriagem = 1;
        private const int EtapaResultado = 2;

        private int etapa = EtapaEquipamento;
        private int perguntaAtual;
        private readonly int[] respostas; // -1 = não respondeu
        private bool concluido;

        private string tipo;
        private string marca;
        private string modelo;

        public Descarte DescarteRegistrado { get; private set; }

        public FormDescarte()
        {
            InitializeComponent();

            respostas = new int[Questionario.Perguntas.Count];
            for (int i = 0; i < respostas.Length; i++) respostas[i] = -1;

            foreach (string t in Catalogos.TiposEletronicos) cmbTipo.Items.Add(t);
            cmbTipo.SelectedIndex = 0;

            barra.CorBarra = Tema.Verde;

            MostrarEtapa(EtapaEquipamento);
        }

        // eventos

        private void cmbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            AtualizarCampoOutroTipo();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Voltar();
        }

        private void btnAvancar_Click(object sender, EventArgs e)
        {
            Avancar();
        }

        // o campo só aparece se escolher "Outros"
        private void AtualizarCampoOutroTipo()
        {
            bool outros = (string)cmbTipo.SelectedItem == Catalogos.TipoOutros;
            lblOutroTipo.Visible = outros;
            txtOutroTipo.Visible = outros;
        }

        // navegação entre as etapas

        private void MostrarEtapa(int novaEtapa)
        {
            etapa = novaEtapa;
            pnlEquipamento.Visible = etapa == EtapaEquipamento;
            pnlTriagem.Visible = etapa == EtapaTriagem;
            pnlResultado.Visible = etapa == EtapaResultado;

            if (etapa == EtapaEquipamento)
            {
                lblEtapa.Text = "Etapa 1 de 3  •  Equipamento";
                lblErro.Text = "";
                AtualizarCampoOutroTipo();
                btnAvancar.Text = "Iniciar triagem";
                btnVoltar.Visible = false;
                btnAvancar.Enabled = true;
                txtMarca.Focus();
            }
            else if (etapa == EtapaTriagem)
            {
                lblEtapa.Text = "Etapa 2 de 3  •  Triagem  —  " + tipo + " " + marca + " " + modelo;
                btnVoltar.Visible = true;
                MostrarPergunta();
            }
            else
            {
                lblEtapa.Text = "Etapa 3 de 3  •  Resultado  —  descarte registrado";
                btnAvancar.Text = "Concluir";
                btnAvancar.Enabled = true;
                btnVoltar.Visible = false;
                btnCancelar.Visible = false;
            }
        }

        private void Avancar()
        {
            if (etapa == EtapaEquipamento)
            {
                if (!ValidarEquipamento()) return;
                perguntaAtual = 0;
                MostrarEtapa(EtapaTriagem);
            }
            else if (etapa == EtapaTriagem)
            {
                if (respostas[perguntaAtual] < 0) return;

                if (perguntaAtual < Questionario.Perguntas.Count - 1)
                {
                    perguntaAtual++;
                    MostrarPergunta();
                }
                else
                {
                    FinalizarTriagem();
                }
            }
            else
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void Voltar()
        {
            if (etapa != EtapaTriagem) return;

            if (perguntaAtual == 0)
            {
                MostrarEtapa(EtapaEquipamento);
            }
            else
            {
                perguntaAtual--;
                MostrarPergunta();
            }
        }

        private bool ValidarEquipamento()
        {
            string tipoEscolhido = (string)cmbTipo.SelectedItem;
            if (tipoEscolhido == Catalogos.TipoOutros)
            {
                if (txtOutroTipo.Text.Trim().Length == 0)
                {
                    lblErro.Text = "Informe qual é o tipo de eletrônico.";
                    txtOutroTipo.Focus();
                    return false;
                }
                tipoEscolhido = txtOutroTipo.Text.Trim();
            }

            if (txtMarca.Text.Trim().Length == 0)
            {
                lblErro.Text = "Informe a marca do equipamento.";
                txtMarca.Focus();
                return false;
            }
            if (txtModelo.Text.Trim().Length == 0)
            {
                lblErro.Text = "Informe o modelo do equipamento.";
                txtModelo.Focus();
                return false;
            }

            tipo = tipoEscolhido;
            marca = txtMarca.Text.Trim();
            modelo = txtModelo.Text.Trim();
            lblErro.Text = "";
            return true;
        }

        // triagem

        // mostra a pergunta atual com um botão pra cada resposta
        private void MostrarPergunta()
        {
            int total = Questionario.Perguntas.Count;
            PerguntaTriagem pergunta = Questionario.Perguntas[perguntaAtual];
            int percentual = (perguntaAtual + 1) * 100 / total;

            lblProgresso.Text = "Pergunta " + (perguntaAtual + 1) + " de " + total;
            lblPercentual.Text = percentual + "%";
            barra.Valor = percentual;
            lblPergunta.Text = pergunta.Texto;

            flowOpcoes.Controls.Clear();
            for (int i = 0; i < pergunta.Opcoes.Length; i++)
            {
                flowOpcoes.Controls.Add(CriarBotaoOpcao(pergunta.Opcoes[i], i));
            }

            AtualizarBotoesTriagem();
        }

        private RadioButton CriarBotaoOpcao(string texto, int indice)
        {
            RadioButton botao = new RadioButton();
            botao.Appearance = Appearance.Button;
            botao.FlatStyle = FlatStyle.Flat;
            botao.FlatAppearance.BorderSize = 2;
            botao.FlatAppearance.BorderColor = Tema.Borda;
            botao.UseVisualStyleBackColor = false;
            botao.Text = texto;
            botao.TextAlign = ContentAlignment.MiddleCenter;
            botao.Font = Tema.Fonte(11.5f, FontStyle.Bold);
            botao.Size = new Size(164, 68);
            botao.Margin = new Padding(0, 0, 14, 14);
            botao.Cursor = Cursors.Hand;
            botao.Tag = indice;
            PintarOpcao(botao);

            botao.CheckedChanged += delegate
            {
                PintarOpcao(botao);
                if (botao.Checked)
                {
                    respostas[perguntaAtual] = indice;
                    AtualizarBotoesTriagem();
                }
            };

            // marca a resposta se já tinha respondido
            if (respostas[perguntaAtual] == indice) botao.Checked = true;
            return botao;
        }

        // muda a cor do botão marcado
        private static void PintarOpcao(RadioButton botao)
        {
            Color verdeClaro = Tema.Clarear(Tema.Verde, 0.74f);
            Color fundo = botao.Checked ? verdeClaro : Color.White;
            Color fundoHover = botao.Checked ? verdeClaro : Tema.Clarear(Tema.Verde, 0.92f);

            botao.BackColor = fundo;
            botao.ForeColor = botao.Checked ? Tema.Escurecer(Tema.Verde, 0.35f) : Tema.TextoPrincipal;
            botao.FlatAppearance.CheckedBackColor = verdeClaro;
            botao.FlatAppearance.BorderColor = botao.Checked ? Tema.Verde : Tema.Borda;
            botao.FlatAppearance.MouseOverBackColor = fundoHover;
            botao.FlatAppearance.MouseDownBackColor = fundoHover;
        }

        private void AtualizarBotoesTriagem()
        {
            bool respondida = respostas[perguntaAtual] >= 0;
            bool ultima = perguntaAtual == Questionario.Perguntas.Count - 1;

            btnAvancar.Text = ultima ? "Concluir triagem" : "Próxima";
            btnAvancar.Enabled = respondida;
            lblDica.Visible = !respondida;
        }

        // calcula a pontuação, registra o descarte e mostra o resultado
        private void FinalizarTriagem()
        {
            Triagem triagem = Questionario.MontarTriagem(respostas);
            ResultadoTriagem resultado = AvaliadorTriagem.Avaliar(triagem);

            DescarteRegistrado = Repositorio.RegistrarDescarte(tipo, marca, modelo, triagem, resultado);
            concluido = true;

            detalhes.Mostrar(DescarteRegistrado);
            MostrarEtapa(EtapaResultado);
        }

        // confirma antes de fechar no meio da triagem
        private void ConfirmarSaida(object sender, FormClosingEventArgs e)
        {
            if (concluido || etapa != EtapaTriagem || DialogResult == DialogResult.OK) return;

            DialogResult resposta = MessageBox.Show(this,
                "A triagem ainda não foi concluída.\nSe sair agora, nada será registrado.\n\nDeseja cancelar o descarte?",
                "Cancelar descarte", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (resposta != DialogResult.Yes) e.Cancel = true;
        }
    }
}
