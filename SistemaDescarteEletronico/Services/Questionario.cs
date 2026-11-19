using System;
using System.Collections.Generic;

namespace SistemaDescarteEletronico
{
    public class PerguntaTriagem
    {
        public string Texto { get; private set; }
        public string[] Opcoes { get; private set; }

        public PerguntaTriagem(string texto, string[] opcoes)
        {
            Texto = texto;
            Opcoes = opcoes;
        }
    }

    // perguntas da triagem e as opções de resposta
    public static class Questionario
    {
        public static readonly string[] OpcoesLiga = { "Sim", "Não" };
        public static readonly string[] OpcoesTela = { "Sim", "Não", "Não se aplica" };
        public static readonly string[] OpcoesBateria = { "Sim", "Degradada", "Não", "Não se aplica" };
        public static readonly string[] OpcoesDanos = { "Nenhum", "Leves", "Graves" };
        public static readonly string[] OpcoesComponentes = { "Sim", "Parcialmente", "Não", "Não se aplica" };

        public static readonly string[] RotulosCriterios = { "Liga", "Tela", "Bateria", "Danos", "Componentes" };

        public static readonly List<PerguntaTriagem> Perguntas = new List<PerguntaTriagem>
        {
            new PerguntaTriagem("O aparelho liga?", OpcoesLiga),
            new PerguntaTriagem("A tela funciona?", OpcoesTela),
            new PerguntaTriagem("A bateria está funcionando?", OpcoesBateria),
            new PerguntaTriagem("Possui danos físicos?", OpcoesDanos),
            new PerguntaTriagem("Os componentes internos estão funcionais?", OpcoesComponentes)
        };

        // transforma as respostas escolhidas nos enums
        public static Triagem MontarTriagem(int[] respostas)
        {
            Triagem triagem = new Triagem();
            triagem.Liga = (RespostaSimNao)respostas[0];
            triagem.Tela = (RespostaTela)respostas[1];
            triagem.Bateria = (RespostaBateria)respostas[2];
            triagem.Danos = (NivelDano)respostas[3];
            triagem.Componentes = (RespostaComponentes)respostas[4];
            return triagem;
        }

        // texto de cada resposta
        public static string[] DescreverRespostas(Triagem t)
        {
            return new string[]
            {
                OpcoesLiga[(int)t.Liga],
                OpcoesTela[(int)t.Tela],
                OpcoesBateria[(int)t.Bateria],
                OpcoesDanos[(int)t.Danos],
                OpcoesComponentes[(int)t.Componentes]
            };
        }
    }
}
