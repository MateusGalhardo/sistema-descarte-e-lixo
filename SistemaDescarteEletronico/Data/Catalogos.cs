using System.Collections.Generic;

namespace SistemaDescarteEletronico
{
    // tipos de eletrônico do formulário de descarte
    public static class Catalogos
    {
        public const string TipoOutros = "Outros";

        public static readonly List<string> TiposEletronicos = new List<string>
        {
            "Celular", "Notebook", "Computador", "Monitor", "Teclado",
            "Mouse", "Impressora", "Televisão", "Fone de ouvido", TipoOutros
        };
    }
}
