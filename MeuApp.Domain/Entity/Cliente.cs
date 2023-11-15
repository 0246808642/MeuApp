using System;
using System.Collections.Generic;
using System.Linq;

using System.Threading.Channels;
using System.Threading.Tasks;

namespace MeuApp.Domain.Entity
{
    internal class Cliente
    {
        public int Id { get; set; }

        public string NomeCompleto { get; set; }

        public int NumeroDaCasa { get; set; }

        public int Idade { get; set; }

        public string Casado { get; set; }

        public Cliente(int id, string nomeCompleto, int numeroDaCasa, int idade, string casado)
        {
            Id = id;
            NomeCompleto = nomeCompleto;
            NumeroDaCasa = numeroDaCasa;
            Idade = idade;
            Casado = casado;
        }

        public void MaiorDeIdade(int idade)
        {
            int valor = 18;

            switch (idade)
            {
                case < 18:
                    Console.WriteLine("Vereficado!");
                    break;

                default:
                    Console.WriteLine("Idade minima não alcançada");
                    break;

            }

        }
        public override string ToString()
        {
            return Id + NomeCompleto + Idade + Casado + NumeroDaCasa;
        }

    }

}

