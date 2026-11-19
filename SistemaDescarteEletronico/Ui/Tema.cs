using System;
using System.Drawing;
using System.Windows.Forms;

namespace SistemaDescarteEletronico
{
    // cores e fontes usadas nas telas
    public static class Tema
    {
        // cores
        public static readonly Color Ciano = Color.FromArgb(0, 151, 167);
        public static readonly Color Verde = Color.FromArgb(39, 160, 94);
        public static readonly Color Amarelo = Color.FromArgb(240, 165, 0);
        public static readonly Color Vermelho = Color.FromArgb(214, 69, 65);
        public static readonly Color Magenta = Color.FromArgb(156, 39, 176);
        public static readonly Color Cinza = Color.FromArgb(120, 134, 148);

        // neutros
        public static readonly Color Fundo = Color.FromArgb(243, 246, 249);
        public static readonly Color Sidebar = Color.FromArgb(27, 38, 49);
        public static readonly Color SidebarAtivo = Color.FromArgb(38, 56, 72);
        public static readonly Color Borda = Color.FromArgb(222, 228, 234);
        public static readonly Color TextoPrincipal = Color.FromArgb(27, 38, 49);
        public static readonly Color TextoSecundario = Color.FromArgb(106, 120, 133);

        public static Font Fonte(float tamanho)
        {
            return new Font("Segoe UI", tamanho, FontStyle.Regular);
        }

        public static Font Fonte(float tamanho, FontStyle estilo)
        {
            return new Font("Segoe UI", tamanho, estilo);
        }

        // escurece a cor
        public static Color Escurecer(Color cor, float fator)
        {
            return Color.FromArgb(
                (int)(cor.R * (1 - fator)),
                (int)(cor.G * (1 - fator)),
                (int)(cor.B * (1 - fator)));
        }

        // clareia a cor
        public static Color Clarear(Color cor, float fator)
        {
            return Color.FromArgb(
                (int)(cor.R + (255 - cor.R) * fator),
                (int)(cor.G + (255 - cor.G) * fator),
                (int)(cor.B + (255 - cor.B) * fator));
        }

        // cor de cada classificação
        public static Color CorDaClassificacao(ClassificacaoDescarte classificacao)
        {
            switch (classificacao)
            {
                case ClassificacaoDescarte.Reutilizavel: return Verde;
                case ClassificacaoDescarte.Reciclavel: return Amarelo;
                default: return Vermelho;
            }
        }

        public static Color CorTextoDaClassificacao(ClassificacaoDescarte classificacao)
        {
            return Escurecer(CorDaClassificacao(classificacao), 0.22f);
        }

        public static Color CorFundoDaClassificacao(ClassificacaoDescarte classificacao)
        {
            return Clarear(CorDaClassificacao(classificacao), 0.88f);
        }

        public static Label CriarLabel(string texto, float tamanho, FontStyle estilo, Color cor)
        {
            Label label = new Label();
            label.Text = texto;
            label.AutoSize = true;
            label.Font = Fonte(tamanho, estilo);
            label.ForeColor = cor;
            label.BackColor = Color.Transparent;
            return label;
        }

        // estilo padrão das tabelas
        public static void EstilizarGrid(DataGridView grid)
        {
            grid.BorderStyle = BorderStyle.None;
            grid.BackgroundColor = Color.White;
            grid.GridColor = Borda;
            grid.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            grid.RowHeadersVisible = false;
            grid.AllowUserToAddRows = false;
            grid.AllowUserToDeleteRows = false;
            grid.AllowUserToResizeRows = false;
            grid.ReadOnly = true;
            grid.MultiSelect = false;
            grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid.ScrollBars = ScrollBars.Vertical;
            grid.Font = Fonte(10f);

            grid.EnableHeadersVisualStyles = false;
            grid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            grid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            grid.ColumnHeadersHeight = 42;
            grid.ColumnHeadersDefaultCellStyle.BackColor = Sidebar;
            grid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            grid.ColumnHeadersDefaultCellStyle.SelectionBackColor = Sidebar;
            grid.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.White;
            grid.ColumnHeadersDefaultCellStyle.Font = Fonte(9.5f, FontStyle.Bold);
            grid.ColumnHeadersDefaultCellStyle.Padding = new Padding(10, 0, 0, 0);

            grid.RowTemplate.Height = 40;
            grid.DefaultCellStyle.BackColor = Color.White;
            grid.DefaultCellStyle.ForeColor = TextoPrincipal;
            grid.DefaultCellStyle.SelectionBackColor = Color.FromArgb(214, 238, 242);
            grid.DefaultCellStyle.SelectionForeColor = TextoPrincipal;
            grid.DefaultCellStyle.Padding = new Padding(10, 0, 0, 0);
        }
    }
}
