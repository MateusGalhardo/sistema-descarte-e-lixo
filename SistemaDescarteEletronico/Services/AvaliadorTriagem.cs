using System;

namespace SistemaDescarteEletronico
{
    // calcula a pontuação e a classificação da triagem
    public static class AvaliadorTriagem
    {
        public const int PontuacaoMaxima = 100;

        // peso de cada critério (soma 100)
        private const int PesoLiga = 30;
        private const int PesoTela = 20;
        private const int PesoBateria = 15;
        private const int PesoComponentes = 25;
        private const int PesoDanos = 10;

        // pontos das respostas intermediárias
        private const int PontosBateriaDegradada = 7;
        private const int PontosComponentesParcial = 12;
        private const int PontosDanosLeves = 5;

        // pontuação mínima de cada faixa
        private const int LimiteReutilizavel = 80;
        private const int LimiteReciclavel = 40;

        public static ResultadoTriagem Avaliar(Triagem triagem)
        {
            int obtidos = 0; // pontos que ganhou
            int possiveis = 0; // pontos que podia ganhar

            // liga e danos valem pra qualquer equipamento
            possiveis += PesoLiga;
            if (triagem.Liga == RespostaSimNao.Sim) obtidos += PesoLiga;

            possiveis += PesoDanos;
            obtidos += PontosDeDanos(triagem.Danos);

            // quando a resposta é "não se aplica" o critério não entra na conta
            // nota = obtidos / possíveis * 100
            if (triagem.Tela != RespostaTela.NaoSeAplica)
            {
                possiveis += PesoTela;
                if (triagem.Tela == RespostaTela.Sim) obtidos += PesoTela;
            }

            if (triagem.Bateria != RespostaBateria.NaoSeAplica)
            {
                possiveis += PesoBateria;
                obtidos += PontosDeBateria(triagem.Bateria);
            }

            if (triagem.Componentes != RespostaComponentes.NaoSeAplica)
            {
                possiveis += PesoComponentes;
                obtidos += PontosDeComponentes(triagem.Componentes);
            }

            int pontuacao = (int)Math.Round(obtidos * (double)PontuacaoMaxima / possiveis, MidpointRounding.AwayFromZero);
            return new ResultadoTriagem(pontuacao, Classificar(pontuacao));
        }

        private static int PontosDeDanos(NivelDano dano)
        {
            switch (dano)
            {
                case NivelDano.Nenhum: return PesoDanos;
                case NivelDano.Leves: return PontosDanosLeves;
                default: return 0;
            }
        }

        private static int PontosDeBateria(RespostaBateria resposta)
        {
            switch (resposta)
            {
                case RespostaBateria.Sim: return PesoBateria;
                case RespostaBateria.Degradada: return PontosBateriaDegradada;
                default: return 0;
            }
        }

        private static int PontosDeComponentes(RespostaComponentes resposta)
        {
            switch (resposta)
            {
                case RespostaComponentes.Sim: return PesoComponentes;
                case RespostaComponentes.Parcialmente: return PontosComponentesParcial;
                default: return 0;
            }
        }

        public static ClassificacaoDescarte Classificar(int pontuacao)
        {
            if (pontuacao >= LimiteReutilizavel) return ClassificacaoDescarte.Reutilizavel;
            if (pontuacao >= LimiteReciclavel) return ClassificacaoDescarte.Reciclavel;
            return ClassificacaoDescarte.DescarteEspecial;
        }

        public static string ObterRotulo(ClassificacaoDescarte classificacao)
        {
            switch (classificacao)
            {
                case ClassificacaoDescarte.Reutilizavel: return "REUTILIZÁVEL";
                case ClassificacaoDescarte.Reciclavel: return "RECICLÁVEL";
                default: return "DESCARTE ESPECIAL";
            }
        }

        public static string ObterMensagem(ClassificacaoDescarte classificacao)
        {
            switch (classificacao)
            {
                case ClassificacaoDescarte.Reutilizavel:
                    return "O equipamento apresenta boas condições para recuperação e reutilização.";
                case ClassificacaoDescarte.Reciclavel:
                    return "O equipamento possui componentes aproveitáveis, mas não apresenta condições adequadas para reutilização.";
                default:
                    return "O equipamento não apresenta condições viáveis de recuperação e deve ser encaminhado para descarte especializado.";
            }
        }
    }
}
