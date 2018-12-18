
using Projeto.Domain.Interfaces;

namespace Projeto.Domain.Models
{
    public class Users: IEntity
    {
        public int id { get; set; }
        public string Name { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
    }

}