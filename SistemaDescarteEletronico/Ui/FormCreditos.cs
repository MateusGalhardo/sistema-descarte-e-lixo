using System;
using System.Windows.Forms;

namespace SistemaDescarteEletronico
{
    // tela de Créditos: disciplina, professor, equipe, curso, instituição, período,
    // versão, tecnologias e os logotipos de Desenvolvimento (Ciência da Computação) e Apoio (Extensão).
    // O botão "Fechar" tem DialogResult = OK, então ele fecha SÓ esta janela (aberta com ShowDialog) e o
    // usuário volta para a tela principal; o programa não é encerrado.
    public partial class FormCreditos : Form
    {
        public FormCreditos()
        {
            InitializeComponent();
        }
    }
}
