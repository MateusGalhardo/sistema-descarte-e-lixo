using System;
using System.Collections.Generic;

namespace SistemaDescarteEletronico
{
    public class PontoDeColeta
    {
        public int Id { get; set; }
        public string NomeEstabelecimento { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }
        public string HorarioFuncionamento { get; set; }
        public List<string> ResiduosAceitos { get; set; }

        public PontoDeColeta(int id, string nome, string endereco, string telefone, string horario, List<string> residuos)
        {
            Id = id;
            NomeEstabelecimento = nome;
            Endereco = endereco;
            Telefone = telefone;
            HorarioFuncionamento = horario;
            ResiduosAceitos = residuos;
        }
    }

    // a ordem dos enums tem que ser igual a ordem das opções do questionário
    public enum RespostaSimNao { Sim, Nao }
    public enum RespostaTela { Sim, Nao, NaoSeAplica }
    public enum RespostaBateria { Sim, Degradada, Nao, NaoSeAplica }
    public enum NivelDano { Nenhum, Leves, Graves }
    public enum RespostaComponentes { Sim, Parcialmente, Nao, NaoSeAplica }

    public enum ClassificacaoDescarte { Reutilizavel, Reciclavel, DescarteEspecial }

    // respostas das cinco perguntas da triagem
    public class Triagem
    {
        public RespostaSimNao Liga { get; set; }
        public RespostaTela Tela { get; set; }
        public RespostaBateria Bateria { get; set; }
        public NivelDano Danos { get; set; }
        public RespostaComponentes Componentes { get; set; }
    }

    // resultado da triagem: pontuação e classificação
    public class ResultadoTriagem
    {
        public int Pontuacao { get; private set; }
        public ClassificacaoDescarte Classificacao { get; private set; }

        public ResultadoTriagem(int pontuacao, ClassificacaoDescarte classificacao)
        {
            Pontuacao = pontuacao;
            Classificacao = classificacao;
        }
    }

    // equipamento descartado
    public class Descarte
    {
        public int Id { get; set; }
        public string TipoEquipamento { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public DateTime DataDescarte { get; set; }
        public Triagem Triagem { get; set; }
        public ResultadoTriagem Resultado { get; set; }

        public Descarte(int id, string tipo, string marca, string modelo, DateTime data, Triagem triagem, ResultadoTriagem resultado)
        {
            Id = id;
            TipoEquipamento = tipo;
            Marca = marca;
            Modelo = modelo;
            DataDescarte = data;
            Triagem = triagem;
            Resultado = resultado;
        }

        // nome que aparece nas listas
        public string NomeCompleto
        {
            get { return TipoEquipamento + " — " + Marca + " " + Modelo; }
        }
    }
}
