using System;

namespace SistemaCadastro
{
    internal class Eletrodomestico
    {
        string nome;
        double potencia;
        double tempoMedioAtivo;
        int dono;

        public string Nome { get => nome; set => nome = value; }
        public double Potencia { get => potencia; set => potencia = value; }
        public double TempoMedioAtivo { get => tempoMedioAtivo; set => tempoMedioAtivo = value; }
        public int Dono { get => dono; set => dono = value; }
    }
}
