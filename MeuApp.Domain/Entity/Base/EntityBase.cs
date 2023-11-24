using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace MeuApp.Domain.Entity.Base
{
    public class EntityBase
    {
        public int Id { get; set; }
        public int Situation { get; set; }
        // DateTime? = pode ser null
        public DateTime? MyProperty { get; set; }
        public DateTime DateRegister { get; set; } = DateTime.Now;
        public string Obersvation  { get; set; }
    }
}
