using MeuApp.Domain.Entity.Base;

namespace MeuApp.Domain.Entity
{
    public class Cliente : EntityBase
    {
        // NomeDoCliente
        public string  NameClient { get; set; }
        // Endereço
        public string  Address { get; set; }
        // Numero do endereço
        public string  AddressNumber { get; set; }
        // Cep 
        public string  ZipCode { get; set; }
        // Bairro
        public string  neighborhood { get; set; }



    }
}
