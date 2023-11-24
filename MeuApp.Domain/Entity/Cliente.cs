using MeuApp.Domain.Entity.Base;

namespace MeuApp.Domain.Entity
{
    public class Cliente : EntityBase
    {
        public string NomeCompleto { get; set; }
        public int NumeroDaCasa { get; set; }
        public int Idade { get; set; }
        public string Casado { get; set; }

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
