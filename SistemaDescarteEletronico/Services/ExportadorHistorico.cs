using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SistemaDescarteEletronico
{
    // exporta o histórico de descartes pra um arquivo csv (abre no excel)
    public static class ExportadorHistorico
    {
        private const string Separador = ";";

        public static void Exportar(List<Descarte> descartes, string caminho)
        {
            StringBuilder texto = new StringBuilder();

            // cabeçalho
            texto.AppendLine(MontarLinha(new string[]
            {
                "Nº", "Data", "Tipo", "Marca", "Modelo",
                "Liga", "Tela", "Bateria", "Danos", "Componentes",
                "Pontuação", "Destino"
            }));

            foreach (Descarte descarte in descartes)
            {
                string[] respostas = Questionario.DescreverRespostas(descarte.Triagem);

                texto.AppendLine(MontarLinha(new string[]
                {
                    descarte.Id.ToString(),
                    descarte.DataDescarte.ToString("dd/MM/yyyy HH:mm"),
                    descarte.TipoEquipamento,
                    descarte.Marca,
                    descarte.Modelo,
                    respostas[0], respostas[1], respostas[2], respostas[3], respostas[4],
                    descarte.Resultado.Pontuacao.ToString(),
                    AvaliadorTriagem.ObterRotulo(descarte.Resultado.Classificacao)
                }));
            }

            // utf8 com bom pro excel não trocar os acentos
            File.WriteAllText(caminho, texto.ToString(), new UTF8Encoding(true));
        }

        private static string MontarLinha(string[] campos)
        {
            string[] prontos = new string[campos.Length];
            for (int i = 0; i < campos.Length; i++)
            {
                prontos[i] = Proteger(campos[i]);
            }
            return string.Join(Separador, prontos);
        }

        // coloca aspas se o texto tiver ponto e vírgula ou aspas
        private static string Proteger(string campo)
        {
            if (campo == null) return "";

            bool precisaDeAspas = campo.Contains(Separador) || campo.Contains("\"") || campo.Contains("\n") || campo.Contains("\r");
            if (!precisaDeAspas) return campo;

            return "\"" + campo.Replace("\"", "\"\"") + "\"";
        }
    }
}
