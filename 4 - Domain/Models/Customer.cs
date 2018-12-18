using Projeto.Domain.Interfaces;

namespace Projeto.Domain.Models
{
    public class Customer: IEntity
    {
        public int id { get; private set; }
        public string Name { get; private set; }
        //public string Document { get; set; }
        //public int TypeDocument { get; set; }
        //public string Address { get; set; }
    
    }
}