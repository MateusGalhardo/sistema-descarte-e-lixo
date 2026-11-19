using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Xml;

namespace SistemaDescarteEletronico
{
    // dados lidos do arquivo
    public class DadosCarregados
    {
        public List<PontoDeColeta> Pontos { get; set; }
        public List<Descarte> Descartes { get; set; }
        public int ProximoIdPonto { get; set; }
        public int ProximoIdDescarte { get; set; }
    }

    // salva e carrega os dados no arquivo dados.json
    public static class ArmazenamentoJson
    {
        // o arquivo fica na pasta AppData porque em Arquivos de Programas não dá pra gravar
        public static readonly string PastaDados = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "SistemaDescarteEletronico");

        public static readonly string CaminhoArquivo = Path.Combine(PastaDados, "dados.json");

        private const string FormatoData = "yyyy-MM-dd HH:mm:ss";

        // classes usadas só pra gravar e ler o json

        [DataContract]
        public class ArquivoDados
        {
            [DataMember(Order = 1)] public int ProximoIdPonto { get; set; }
            [DataMember(Order = 2)] public int ProximoIdDescarte { get; set; }
            [DataMember(Order = 3)] public List<PontoArquivo> Pontos { get; set; }
            [DataMember(Order = 4)] public List<DescarteArquivo> Descartes { get; set; }
        }

        [DataContract]
        public class PontoArquivo
        {
            [DataMember(Order = 1)] public int Id { get; set; }
            [DataMember(Order = 2)] public string Nome { get; set; }
            [DataMember(Order = 3)] public string Endereco { get; set; }
            [DataMember(Order = 4)] public string Telefone { get; set; }
            [DataMember(Order = 5)] public string Horario { get; set; }
            [DataMember(Order = 6)] public List<string> Residuos { get; set; }
        }

        [DataContract]
        public class DescarteArquivo
        {
            [DataMember(Order = 1)] public int Id { get; set; }
            [DataMember(Order = 2)] public string Tipo { get; set; }
            [DataMember(Order = 3)] public string Marca { get; set; }
            [DataMember(Order = 4)] public string Modelo { get; set; }
            [DataMember(Order = 5)] public string Data { get; set; }
            [DataMember(Order = 6)] public string Liga { get; set; }
            [DataMember(Order = 7)] public string Tela { get; set; }
            [DataMember(Order = 8)] public string Bateria { get; set; }
            [DataMember(Order = 9)] public string Danos { get; set; }
            [DataMember(Order = 10)] public string Componentes { get; set; }
            [DataMember(Order = 11)] public int Pontuacao { get; set; }
            [DataMember(Order = 12)] public string Classificacao { get; set; }
        }

        // salvar
        public static bool Salvar(IEnumerable<PontoDeColeta> pontos, IEnumerable<Descarte> descartes, int proximoIdPonto, int proximoIdDescarte)
        {
            try
            {
                ArquivoDados arquivo = new ArquivoDados();
                arquivo.ProximoIdPonto = proximoIdPonto;
                arquivo.ProximoIdDescarte = proximoIdDescarte;
                arquivo.Pontos = new List<PontoArquivo>();
                arquivo.Descartes = new List<DescarteArquivo>();

                foreach (PontoDeColeta p in pontos)
                {
                    PontoArquivo ponto = new PontoArquivo();
                    ponto.Id = p.Id;
                    ponto.Nome = p.NomeEstabelecimento;
                    ponto.Endereco = p.Endereco;
                    ponto.Telefone = p.Telefone;
                    ponto.Horario = p.HorarioFuncionamento;
                    ponto.Residuos = new List<string>(p.ResiduosAceitos);
                    arquivo.Pontos.Add(ponto);
                }

                foreach (Descarte d in descartes)
                {
                    DescarteArquivo descarte = new DescarteArquivo();
                    descarte.Id = d.Id;
                    descarte.Tipo = d.TipoEquipamento;
                    descarte.Marca = d.Marca;
                    descarte.Modelo = d.Modelo;
                    descarte.Data = d.DataDescarte.ToString(FormatoData, CultureInfo.InvariantCulture);
                    descarte.Liga = d.Triagem.Liga.ToString();
                    descarte.Tela = d.Triagem.Tela.ToString();
                    descarte.Bateria = d.Triagem.Bateria.ToString();
                    descarte.Danos = d.Triagem.Danos.ToString();
                    descarte.Componentes = d.Triagem.Componentes.ToString();
                    descarte.Pontuacao = d.Resultado.Pontuacao;
                    descarte.Classificacao = d.Resultado.Classificacao.ToString();
                    arquivo.Descartes.Add(descarte);
                }

                Directory.CreateDirectory(PastaDados);

                // grava num arquivo temporário primeiro pra não estragar o antigo se der erro
                string temporario = CaminhoArquivo + ".tmp";
                DataContractJsonSerializer serializador = new DataContractJsonSerializer(typeof(ArquivoDados));

                using (FileStream saida = File.Create(temporario))
                using (XmlDictionaryWriter escritor = JsonReaderWriterFactory.CreateJsonWriter(saida, Encoding.UTF8, false, true))
                {
                    // true = json com quebra de linha
                    serializador.WriteObject(escritor, arquivo);
                }

                File.Copy(temporario, CaminhoArquivo, true);
                File.Delete(temporario);
                return true;
            }
            catch (IOException)
            {
                return false;
            }
            catch (UnauthorizedAccessException)
            {
                return false;
            }
        }

        // carregar (devolve null se não tiver arquivo)
        public static DadosCarregados Carregar()
        {
            if (!File.Exists(CaminhoArquivo)) return null;

            try
            {
                ArquivoDados arquivo;
                DataContractJsonSerializer serializador = new DataContractJsonSerializer(typeof(ArquivoDados));
                using (FileStream entrada = File.OpenRead(CaminhoArquivo))
                {
                    arquivo = (ArquivoDados)serializador.ReadObject(entrada);
                }
                if (arquivo == null) throw new SerializationException("arquivo vazio");

                DadosCarregados dados = new DadosCarregados();
                dados.Pontos = new List<PontoDeColeta>();
                dados.Descartes = new List<Descarte>();

                int maiorIdPonto = 0;
                int maiorIdDescarte = 0;

                if (arquivo.Pontos != null)
                {
                    foreach (PontoArquivo p in arquivo.Pontos)
                    {
                        List<string> residuos = p.Residuos != null ? new List<string>(p.Residuos) : new List<string>();
                        dados.Pontos.Add(new PontoDeColeta(p.Id, p.Nome, p.Endereco, p.Telefone, p.Horario, residuos));
                        if (p.Id > maiorIdPonto) maiorIdPonto = p.Id;
                    }
                }

                if (arquivo.Descartes != null)
                {
                    foreach (DescarteArquivo d in arquivo.Descartes)
                    {
                        // transforma o texto de volta no enum
                        Triagem triagem = new Triagem();
                        triagem.Liga = (RespostaSimNao)Enum.Parse(typeof(RespostaSimNao), d.Liga);
                        triagem.Tela = (RespostaTela)Enum.Parse(typeof(RespostaTela), d.Tela);
                        triagem.Bateria = (RespostaBateria)Enum.Parse(typeof(RespostaBateria), d.Bateria);
                        triagem.Danos = (NivelDano)Enum.Parse(typeof(NivelDano), d.Danos);
                        triagem.Componentes = (RespostaComponentes)Enum.Parse(typeof(RespostaComponentes), d.Componentes);

                        ClassificacaoDescarte classificacao = (ClassificacaoDescarte)Enum.Parse(typeof(ClassificacaoDescarte), d.Classificacao);
                        ResultadoTriagem resultado = new ResultadoTriagem(d.Pontuacao, classificacao);

                        DateTime data = DateTime.ParseExact(d.Data, FormatoData, CultureInfo.InvariantCulture);

                        dados.Descartes.Add(new Descarte(d.Id, d.Tipo, d.Marca, d.Modelo, data, triagem, resultado));
                        if (d.Id > maiorIdDescarte) maiorIdDescarte = d.Id;
                    }
                }

                // evita repetir id
                dados.ProximoIdPonto = Math.Max(arquivo.ProximoIdPonto, maiorIdPonto + 1);
                dados.ProximoIdDescarte = Math.Max(arquivo.ProximoIdDescarte, maiorIdDescarte + 1);
                return dados;
            }
            catch (Exception ex)
            {
                // se o arquivo estiver com defeito guarda uma cópia e começa do zero
                if (ex is SerializationException || ex is IOException || ex is UnauthorizedAccessException ||
                    ex is ArgumentException || ex is FormatException || ex is XmlException)
                {
                    GuardarArquivoComDefeito();
                    return null;
                }
                throw;
            }
        }

        private static void GuardarArquivoComDefeito()
        {
            try
            {
                File.Copy(CaminhoArquivo, CaminhoArquivo + ".erro", true);
                File.Delete(CaminhoArquivo);
            }
            catch (IOException)
            {
            }
            catch (UnauthorizedAccessException)
            {
            }
        }
    }
}
