using System;
using System.Collections.Generic;

namespace SistemaDescarteEletronico
{
    // procura os pontos de coleta que aceitam o tipo do equipamento
    public static class SugestorDePontos
    {
        // palavras pra procurar nos resíduos de cada ponto
        private static readonly Dictionary<string, string[]> palavrasChave =
            new Dictionary<string, string[]>(StringComparer.OrdinalIgnoreCase)
        {
            { "Celular",        new string[] { "celular" } },
            { "Notebook",       new string[] { "notebook", "computador" } },
            { "Computador",     new string[] { "computador" } },
            { "Monitor",        new string[] { "monitor", "computador" } },
            { "Teclado",        new string[] { "teclado", "computador" } },
            { "Mouse",          new string[] { "mouse", "computador" } },
            { "Impressora",     new string[] { "impressora", "computador" } },
            { "Televisão",      new string[] { "televis", "tv" } },
            { "Fone de ouvido", new string[] { "fone", "celular" } }
        };

        public static List<PontoDeColeta> Sugerir(string tipoEquipamento)
        {
            List<PontoDeColeta> sugeridos = new List<PontoDeColeta>();
            if (string.IsNullOrWhiteSpace(tipoEquipamento)) return sugeridos;

            // se o tipo não estiver na lista procura pelo próprio nome
            string[] termos;
            if (!palavrasChave.TryGetValue(tipoEquipamento.Trim(), out termos))
            {
                termos = new string[] { tipoEquipamento.Trim() };
            }

            foreach (string termo in termos)
            {
                foreach (PontoDeColeta ponto in Repositorio.BuscarPontosPorResiduo(termo))
                {
                    // não repetir o mesmo ponto
                    if (!sugeridos.Contains(ponto)) sugeridos.Add(ponto);
                }
            }

            return sugeridos;
        }
    }
}
