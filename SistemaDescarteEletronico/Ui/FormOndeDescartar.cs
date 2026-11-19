using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SistemaDescarteEletronico
{
    // mostra os pontos de coleta que aceitam o equipamento descartado
    public partial class FormOndeDescartar : Form
    {
        // construtor vazio pro designer
        public FormOndeDescartar() : this(null)
        {
        }

        public FormOndeDescartar(Descarte descarte)
        {
            InitializeComponent();
            if (descarte == null) return;

            Tema.EstilizarGrid(gridPontos);
            gridPontos.Columns.Add(CriarColuna("Estabelecimento", 30));
            gridPontos.Columns.Add(CriarColuna("Endereço", 30));
            gridPontos.Columns.Add(CriarColuna("Telefone", 16));
            gridPontos.Columns.Add(CriarColuna("Horário", 24));

            lblSubtitulo.Text = descarte.NomeCompleto;

            // dica de acordo com a classificação
            ClassificacaoDescarte faixa = descarte.Resultado.Classificacao;
            lblDica.Text = DicaDaFaixa(faixa);
            lblDica.ForeColor = Tema.CorTextoDaClassificacao(faixa);

            List<PontoDeColeta> pontos = SugestorDePontos.Sugerir(descarte.TipoEquipamento);

            if (pontos.Count == 0)
            {
                gridPontos.Visible = false;
                lblVazio.Visible = true;
                lblInfo.Text = "Nenhum ponto encontrado para este tipo de equipamento.";
                return;
            }

            foreach (PontoDeColeta ponto in pontos)
            {
                gridPontos.Rows.Add(ponto.NomeEstabelecimento, ponto.Endereco, ponto.Telefone, ponto.HorarioFuncionamento);
            }
            gridPontos.ClearSelection();
            lblInfo.Text = pontos.Count + " ponto(s) de coleta aceitam este tipo de equipamento:";
        }

        private static string DicaDaFaixa(ClassificacaoDescarte faixa)
        {
            switch (faixa)
            {
                case ClassificacaoDescarte.Reutilizavel:
                    return "Dica: o equipamento está em bom estado. Antes de descartar, considere doar ou reutilizar.";
                case ClassificacaoDescarte.Reciclavel:
                    return "Dica: o equipamento tem componentes aproveitáveis. Leve a um ponto de reciclagem.";
                default:
                    return "Atenção: o equipamento precisa de descarte especializado. Confirme com o ponto antes de levar.";
            }
        }

        private static DataGridViewTextBoxColumn CriarColuna(string titulo, float peso)
        {
            DataGridViewTextBoxColumn coluna = new DataGridViewTextBoxColumn();
            coluna.HeaderText = titulo;
            coluna.FillWeight = peso;
            coluna.SortMode = DataGridViewColumnSortMode.NotSortable;
            return coluna;
        }
    }
}
