using MeuApp.Domain.Enum;

namespace MeuApp.Domain.Entity.Base
{
    public class EntityBase
    {
        public long Id { get; set; }
        // DateTime? = pode ser null
        public DateTime DateRegister { get; set; } = DateTime.Now;
        public DateTime? ChangeDate { get; set; }
        public Situations Situations { get; set; } = Situations.Active;
        public string Obersvation  { get; set; }
    }
}
