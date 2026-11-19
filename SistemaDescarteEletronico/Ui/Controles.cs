using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace SistemaDescarteEletronico
{
    // base das telas que aparecem na área de conteúdo
    public class PainelBase : UserControl
    {
        public PainelBase()
        {
            DoubleBuffered = true;
            BackColor = Tema.Fundo;
        }

        public virtual void Atualizar()
        {
        }

        // evento do botão voltar
        public event EventHandler VoltarSolicitado;

        protected void PedirVoltar()
        {
            EventHandler evento = VoltarSolicitado;
            if (evento != null) evento(this, EventArgs.Empty);
        }
    }

    public static class Desenho
    {
        public static GraphicsPath RetanguloArredondado(Rectangle r, int raio)
        {
            int d = Math.Max(1, Math.Min(raio * 2, Math.Min(r.Width, r.Height)));
            GraphicsPath caminho = new GraphicsPath();
            caminho.AddArc(r.X, r.Y, d, d, 180, 90);
            caminho.AddArc(r.Right - d, r.Y, d, d, 270, 90);
            caminho.AddArc(r.Right - d, r.Bottom - d, d, d, 0, 90);
            caminho.AddArc(r.X, r.Bottom - d, d, d, 90, 90);
            caminho.CloseFigure();
            return caminho;
        }
    }

    // botão do menu lateral
    public class BotaoMenu : Button
    {
        private bool ativo;

        // construtor vazio pro designer
        public BotaoMenu() : this("")
        {
        }

        public BotaoMenu(string texto)
        {
            Text = texto;
            Height = 46;
            FlatStyle = FlatStyle.Flat;
            FlatAppearance.BorderSize = 0;
            FlatAppearance.MouseOverBackColor = Tema.SidebarAtivo;
            FlatAppearance.MouseDownBackColor = Tema.SidebarAtivo;
            TextAlign = ContentAlignment.MiddleLeft;
            Padding = new Padding(26, 0, 0, 0);
            Font = Tema.Fonte(10.5f);
            Cursor = Cursors.Hand;
            UseVisualStyleBackColor = false;
            Aplicar();
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool Ativo
        {
            get { return ativo; }
            set
            {
                ativo = value;
                Aplicar();
            }
        }

        private void Aplicar()
        {
            BackColor = ativo ? Tema.SidebarAtivo : Tema.Sidebar;
            ForeColor = ativo ? Color.White : Color.FromArgb(188, 201, 212);
            Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            if (ativo)
            {
                using (SolidBrush pincel = new SolidBrush(Tema.Ciano))
                {
                    e.Graphics.FillRectangle(pincel, 0, 0, 5, Height);
                }
            }
        }
    }

    // botão colorido do sistema
    public class BotaoAcao : Button
    {
        private Color cor;
        private bool secundario;

        // construtor vazio pro designer
        public BotaoAcao() : this("Botão", Tema.Verde, false)
        {
        }

        public BotaoAcao(string texto, Color cor, bool secundario)
        {
            this.cor = cor;
            this.secundario = secundario;
            Text = texto;
            Height = 38;
            Width = 120;
            FlatStyle = FlatStyle.Flat;
            Font = Tema.Fonte(10f, FontStyle.Bold);
            UseVisualStyleBackColor = false;
            EnabledChanged += delegate { Aplicar(); };
            Aplicar();
        }

        public BotaoAcao(string texto, Color cor) : this(texto, cor, false)
        {
        }

        [Category("Aparência")]
        [Description("Cor principal do botão (verde = positivo, amarelo = edição, vermelho = exclusão...).")]
        public Color Cor
        {
            get { return cor; }
            set
            {
                cor = value;
                Aplicar();
            }
        }

        [Category("Aparência")]
        [Description("Quando verdadeiro, o botão fica só com contorno (sem preenchimento).")]
        [DefaultValue(false)]
        public bool Secundario
        {
            get { return secundario; }
            set
            {
                secundario = value;
                Aplicar();
            }
        }

        private void Aplicar()
        {
            if (!Enabled)
            {
                Color cinza = Color.FromArgb(228, 233, 238);
                BackColor = cinza;
                ForeColor = Color.FromArgb(150, 160, 170);
                FlatAppearance.BorderSize = 0;
                FlatAppearance.MouseOverBackColor = cinza;
                FlatAppearance.MouseDownBackColor = cinza;
                Cursor = Cursors.Default;
                return;
            }

            Cursor = Cursors.Hand;

            if (secundario)
            {
                BackColor = Color.White;
                ForeColor = cor;
                FlatAppearance.BorderSize = 1;
                FlatAppearance.BorderColor = cor;
                FlatAppearance.MouseOverBackColor = Tema.Clarear(cor, 0.9f);
                FlatAppearance.MouseDownBackColor = Tema.Clarear(cor, 0.8f);
            }
            else
            {
                BackColor = cor;
                ForeColor = Color.White;
                FlatAppearance.BorderSize = 0;
                FlatAppearance.MouseOverBackColor = Tema.Escurecer(cor, 0.12f);
                FlatAppearance.MouseDownBackColor = Tema.Escurecer(cor, 0.22f);
            }
        }
    }

    // barra de progresso
    public class BarraProgresso : Control
    {
        private int valor;
        private int maximo = 100;
        private Color corBarra = Tema.Ciano;
        private Color corTrilho = Color.FromArgb(226, 232, 238);

        public BarraProgresso()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint |
                     ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw, true);
            Height = 12;
            BackColor = Color.White;
        }

        [DefaultValue(0)]
        public int Valor
        {
            get { return valor; }
            set
            {
                valor = Math.Max(0, Math.Min(maximo, value));
                Invalidate();
            }
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Color CorBarra
        {
            get { return corBarra; }
            set
            {
                corBarra = value;
                Invalidate();
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.Clear(BackColor);
            g.SmoothingMode = SmoothingMode.AntiAlias;

            int largura = Width - 1;
            int altura = Height - 1;
            if (largura <= 0 || altura <= 0) return;

            using (GraphicsPath trilho = Desenho.RetanguloArredondado(new Rectangle(0, 0, largura, altura), altura / 2))
            using (SolidBrush pincel = new SolidBrush(corTrilho))
            {
                g.FillPath(pincel, trilho);
            }

            if (valor <= 0) return;

            int preenchido = Math.Max(altura, (int)Math.Round(largura * (double)valor / maximo));
            using (GraphicsPath parte = Desenho.RetanguloArredondado(new Rectangle(0, 0, preenchido, altura), altura / 2))
            using (SolidBrush pincel = new SolidBrush(corBarra))
            {
                g.FillPath(pincel, parte);
            }
        }
    }

    // painel branco com borda
    public class Cartao : Panel
    {
        public Cartao()
        {
            DoubleBuffered = true;
            ResizeRedraw = true;
            BackColor = Color.White;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            using (Pen caneta = new Pen(Tema.Borda))
            {
                e.Graphics.DrawRectangle(caneta, 0, 0, Width - 1, Height - 1);
            }
        }
    }
}
