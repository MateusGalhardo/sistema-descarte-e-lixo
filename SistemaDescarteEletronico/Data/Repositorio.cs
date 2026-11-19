using System;
using System.Collections.Generic;
using System.Linq;

namespace SistemaDescarteEletronico
{
    // guarda os pontos de coleta e os descartes (na memória e no arquivo)
    public static class Repositorio
    {
        private static readonly List<PontoDeColeta> pontos = new List<PontoDeColeta>();
        private static readonly List<Descarte> descartes = new List<Descarte>();
        private static int proximoIdPonto = 1;
        private static int proximoIdDescarte = 1;

        // só começa a salvar depois que terminar de carregar
        private static bool salvamentoLigado;

        static Repositorio()
        {
            // tenta carregar os dados salvos, se não tiver usa os de exemplo
            DadosCarregados salvos = ArmazenamentoJson.Carregar();
            if (salvos != null)
            {
                pontos.AddRange(salvos.Pontos);
                descartes.AddRange(salvos.Descartes);
                proximoIdPonto = salvos.ProximoIdPonto;
                proximoIdDescarte = salvos.ProximoIdDescarte;
            }
            else
            {
                CarregarDadosExemplo();
            }

            salvamentoLigado = true;
            Salvar();
        }

        // grava tudo no arquivo
        public static void Salvar()
        {
            if (!salvamentoLigado) return;
            ArmazenamentoJson.Salvar(pontos, descartes, proximoIdPonto, proximoIdDescarte);
        }

        public static IReadOnlyList<PontoDeColeta> Pontos
        {
            get { return pontos; }
        }

        public static IReadOnlyList<Descarte> Descartes
        {
            get { return descartes; }
        }

        // pontos de coleta

        public static PontoDeColeta CadastrarPonto(string nome, string endereco, string telefone, string horario, List<string> residuos)
        {
            PontoDeColeta novo = new PontoDeColeta(proximoIdPonto++, nome, endereco, telefone, horario, residuos);
            pontos.Add(novo);
            Salvar();
            return novo;
        }

        public static void ExcluirPonto(PontoDeColeta ponto)
        {
            pontos.Remove(ponto);
            Salvar();
        }

        // busca os pontos que aceitam o resíduo digitado
        public static List<PontoDeColeta> BuscarPontosPorResiduo(string termo)
        {
            return pontos
                .Where(p => p.ResiduosAceitos.Any(r => r.IndexOf(termo, StringComparison.OrdinalIgnoreCase) >= 0))
                .ToList();
        }

        // descartes

        public static Descarte RegistrarDescarte(string tipo, string marca, string modelo, Triagem triagem, ResultadoTriagem resultado)
        {
            Descarte descarte = new Descarte(proximoIdDescarte++, tipo, marca, modelo, DateTime.Now, triagem, resultado);
            descartes.Add(descarte);
            Salvar();
            return descarte;
        }

        // mais recentes primeiro
        public static List<Descarte> DescartesMaisRecentesPrimeiro()
        {
            return descartes.OrderByDescending(d => d.DataDescarte).ThenByDescending(d => d.Id).ToList();
        }

        // dados de exemplo

        private static void CarregarDadosExemplo()
        {
            CadastrarPonto(
                "Ecoponto Central - Green Eletron",
                "Rua das Flores, 123 - Centro",
                "(14) 3210-9999",
                "Seg-Sex 08h às 17h",
                new List<string> { "Celulares", "Computadores", "Pilhas/Baterias", "Cabos" });

            CadastrarPonto(
                "ReciclaTech - Coleta de Eletros",
                "Av. Brasil, 4560 - Jardim Paulista",
                "(14) 99887-1122",
                "Seg-Sáb 09h às 18h",
                new List<string> { "TVs", "Eletrodomésticos", "Computadores" });
        }
    }
}
