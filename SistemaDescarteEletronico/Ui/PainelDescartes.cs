using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace SistemaDescarteEletronico
{
    // tela do histórico de descartes
    public partial class PainelDescartes : PainelBase
    {
        public event EventHandler NovoDescarteSolicitado;

        public PainelDescartes()
        {
            InitializeComponent();

            Tema.EstilizarGrid(grid);
            grid.DefaultCellStyle.WrapMode = DataGridViewTriState.False;
        }

        // eventos

        private void btnNovo_Click(object sender, EventArgs e)
        {
            EventHandler evento = NovoDescarteSolicitado;
            if (evento != null) evento(this, EventArgs.Empty);
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            PedirVoltar();
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            ExportarHistorico();
        }

        private void grid_SelectionChanged(object sender, EventArgs e)
        {
            MostrarSelecionado();
        }

        public override void Atualizar()
        {
            Recarregar(null);
        }

        // recarrega a tabela
        private void Recarregar(Descarte selecionar)
        {
            List<Descarte> lista = Repositorio.DescartesMaisRecentesPrimeiro();

            grid.Rows.Clear();
            foreach (Descarte descarte in lista)
            {
                int linha = grid.Rows.Add(
                    descarte.Id.ToString("00"),
                    descarte.DataDescarte.ToString("dd/MM/yyyy HH:mm"),
                    descarte.NomeCompleto,
                    descarte.Resultado.Pontuacao.ToString(),
                    AvaliadorTriagem.ObterRotulo(descarte.Resultado.Classificacao));
                grid.Rows[linha].Tag = descarte;
            }

            bool vazio = lista.Count == 0;
            lblVazio.Visible = vazio;
            lblVazio.BringToFront();
            if (!vazio) grid.BringToFront();
            lblContagem.Text = vazio
                ? "Os equipamentos descartados e suas triagens aparecem aqui."
                : lista.Count + " descarte(s) registrado(s) — clique em um para ver a triagem completa";

            grid.ClearSelection();
            if (selecionar != null) Selecionar(selecionar);
            else if (grid.Rows.Count > 0) grid.Rows[0].Selected = true;

            MostrarSelecionado();
        }

        // seleciona o descarte na tabela
        public void Selecionar(Descarte descarte)
        {
            foreach (DataGridViewRow linha in grid.Rows)
            {
                if (linha.Tag == descarte)
                {
                    grid.ClearSelection();
                    linha.Selected = true;
                    grid.CurrentCell = linha.Cells[1];
                    return;
                }
            }
        }

        private void MostrarSelecionado()
        {
            if (grid.SelectedRows.Count == 0)
            {
                detalhes.Limpar();
                return;
            }

            Descarte descarte = grid.SelectedRows[0].Tag as Descarte;
            if (descarte == null) detalhes.Limpar();
            else detalhes.Mostrar(descarte);
        }

        // exporta o histórico pra csv
        private void ExportarHistorico()
        {
            List<Descarte> lista = Repositorio.DescartesMaisRecentesPrimeiro();
            if (lista.Count == 0)
            {
                MessageBox.Show(FindForm(), "Ainda não há descartes registrados para exportar.",
                    "Exportar histórico", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using (SaveFileDialog janela = new SaveFileDialog())
            {
                janela.Title = "Exportar histórico de descartes";
                janela.Filter = "Planilha CSV (*.csv)|*.csv";
                janela.FileName = "historico_descartes_" + DateTime.Now.ToString("yyyy-MM-dd") + ".csv";
                if (janela.ShowDialog(FindForm()) != DialogResult.OK) return;

                try
                {
                    ExportadorHistorico.Exportar(lista, janela.FileName);
                    MessageBox.Show(FindForm(), lista.Count + " descarte(s) exportado(s) para:\n" + janela.FileName,
                        "Exportar histórico", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception erro)
                {
                    // ex: arquivo aberto no excel
                    MessageBox.Show(FindForm(), "Não foi possível salvar o arquivo.\n" + erro.Message,
                        "Exportar histórico", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        // cor da coluna destino
        private void FormatarDestino(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex != 4) return;

            Descarte descarte = grid.Rows[e.RowIndex].Tag as Descarte;
            if (descarte == null) return;

            Color cor = Tema.CorTextoDaClassificacao(descarte.Resultado.Classificacao);
            e.CellStyle.ForeColor = cor;
            e.CellStyle.SelectionForeColor = cor;
            e.CellStyle.Font = Tema.Fonte(9.5f, FontStyle.Bold);
        }
    }
}
