using MeuApp.Domain.Entity.Base;

namespace MeuApp.Domain.Entity
{
    public class Client : EntityBase
    {
         // <summary>
        // NomeDoCliente
        // </summary>
        public string  NameClient { get; set; } 

        // <summary>
        // Endereço
        // </summary>  
        public string  Address { get; set; }

        // <summary>
        // Numero do endereço
        // </summary>
        public string  AddressNumber { get; set; }

        // <summary>
        // Cep 
        // </sumarry>
        public string  ZipCode { get; set; }

        // <summary>
        // Bairro
        //</summary>
        public string  neighborhood { get; set; }
    }
}
