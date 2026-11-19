using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace SistemaDescarteEletronico
{
    // tela dos pontos de coleta
    public partial class PainelPontos : PainelBase
    {
        private string filtro = "";
        private bool carregando;

        public PainelPontos()
        {
            InitializeComponent();

            Tema.EstilizarGrid(grid);

            lblSemSelecao.BringToFront();
        }

        // eventos

        // enter também busca
        private void txtBusca_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                Buscar();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Buscar();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparBusca();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            NovoPonto();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            EditarSelecionado();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            ExcluirSelecionado();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            PedirVoltar();
        }

        private void grid_SelectionChanged(object sender, EventArgs e)
        {
            if (!carregando) AtualizarSelecao();
        }

        // dois cliques abre a edição
        private void grid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) EditarSelecionado();
        }

        private void cartaoDetalhes_Resize(object sender, EventArgs e)
        {
            flowResiduos.Width = Math.Max(120, cartaoDetalhes.Width - flowResiduos.Left - 22);
            flowResiduos.Height = Math.Max(40, cartaoDetalhes.Height - flowResiduos.Top - 16);
        }

        public override void Atualizar()
        {
            Recarregar();
        }

        private PontoDeColeta PontoSelecionado
        {
            get
            {
                if (grid.SelectedRows.Count == 0) return null;
                return grid.SelectedRows[0].Tag as PontoDeColeta;
            }
        }

        // tabela

        // recarrega a tabela mantendo o ponto selecionado
        private void Recarregar()
        {
            PontoDeColeta anterior = PontoSelecionado;
            List<PontoDeColeta> lista = filtro.Length == 0
                ? new List<PontoDeColeta>(Repositorio.Pontos)
                : Repositorio.BuscarPontosPorResiduo(filtro);

            carregando = true;
            grid.Rows.Clear();
            foreach (PontoDeColeta ponto in lista)
            {
                int linha = grid.Rows.Add(
                    ponto.Id.ToString("00"),
                    ponto.NomeEstabelecimento,
                    ponto.Endereco,
                    ponto.Telefone,
                    ponto.HorarioFuncionamento,
                    string.Join(", ", ponto.ResiduosAceitos));
                grid.Rows[linha].Tag = ponto;
            }

            grid.ClearSelection();
            foreach (DataGridViewRow linha in grid.Rows)
            {
                if (linha.Tag == anterior && anterior != null)
                {
                    linha.Selected = true;
                    grid.CurrentCell = linha.Cells[1];
                }
            }
            if (grid.SelectedRows.Count == 0 && grid.Rows.Count > 0)
            {
                grid.Rows[0].Selected = true;
            }
            carregando = false;

            if (filtro.Length == 0)
            {
                lblStatus.Text = lista.Count + " ponto(s) de coleta cadastrado(s)";
                lblStatus.ForeColor = Tema.TextoSecundario;
            }
            else if (lista.Count == 0)
            {
                lblStatus.Text = "Nenhum ponto de coleta aceita o resíduo \"" + filtro + "\".";
                lblStatus.ForeColor = Tema.Vermelho;
            }
            else
            {
                lblStatus.Text = lista.Count + " ponto(s) aceitam \"" + filtro + "\"";
                lblStatus.ForeColor = Tema.Magenta;
            }

            AtualizarSelecao();
        }

        // atualiza os botões e os detalhes do ponto selecionado
        private void AtualizarSelecao()
        {
            PontoDeColeta ponto = PontoSelecionado;
            btnEditar.Enabled = ponto != null;
            btnExcluir.Enabled = ponto != null;

            lblSemSelecao.Visible = ponto == null;
            if (ponto == null) return;

            lblNome.Text = ponto.NomeEstabelecimento;
            lblEndereco.Text = ponto.Endereco;
            lblTelefone.Text = ponto.Telefone;
            lblHorario.Text = ponto.HorarioFuncionamento;

            flowResiduos.Controls.Clear();
            foreach (string residuo in ponto.ResiduosAceitos)
            {
                Label chip = new Label();
                chip.Text = residuo;
                chip.AutoSize = true;
                chip.Padding = new Padding(9, 4, 9, 4);
                chip.Margin = new Padding(0, 0, 6, 6);
                chip.Font = Tema.Fonte(9f, FontStyle.Bold);
                chip.BackColor = Tema.Clarear(Tema.Verde, 0.86f);
                chip.ForeColor = Tema.Escurecer(Tema.Verde, 0.2f);
                flowResiduos.Controls.Add(chip);
            }
        }

        // busca

        private void Buscar()
        {
            filtro = txtBusca.Text.Trim();
            Recarregar();
        }

        private void LimparBusca()
        {
            txtBusca.Text = "";
            filtro = "";
            Recarregar();
            txtBusca.Focus();
        }

        // cadastrar, editar e excluir

        public void NovoPonto()
        {
            using (FormPontoColeta janela = new FormPontoColeta(null))
            {
                if (janela.ShowDialog(FindForm()) != DialogResult.OK) return;

                PontoDeColeta novo = Repositorio.CadastrarPonto(janela.Nome, janela.Endereco, janela.Telefone, janela.Horario, janela.Residuos);
                Recarregar();
                SelecionarPonto(novo);
            }
        }

        private void EditarSelecionado()
        {
            PontoDeColeta ponto = PontoSelecionado;
            if (ponto == null) return;

            using (FormPontoColeta janela = new FormPontoColeta(ponto))
            {
                if (janela.ShowDialog(FindForm()) != DialogResult.OK) return;

                ponto.NomeEstabelecimento = janela.Nome;
                ponto.Endereco = janela.Endereco;
                ponto.Telefone = janela.Telefone;
                ponto.HorarioFuncionamento = janela.Horario;
                ponto.ResiduosAceitos = janela.Residuos;
                Repositorio.Salvar();
                Recarregar();
            }
        }

        private void ExcluirSelecionado()
        {
            PontoDeColeta ponto = PontoSelecionado;
            if (ponto == null) return;

            DialogResult resposta = MessageBox.Show(FindForm(),
                "Deseja excluir o ponto de coleta:\n\n" + ponto.NomeEstabelecimento + "\n\nEssa ação não pode ser desfeita.",
                "Confirmar exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

            if (resposta != DialogResult.Yes) return;

            Repositorio.ExcluirPonto(ponto);
            Recarregar();
        }

        private void SelecionarPonto(PontoDeColeta ponto)
        {
            foreach (DataGridViewRow linha in grid.Rows)
            {
                if (linha.Tag == ponto)
                {
                    grid.ClearSelection();
                    linha.Selected = true;
                    grid.CurrentCell = linha.Cells[1];
                    return;
                }
            }
        }
    }
}
