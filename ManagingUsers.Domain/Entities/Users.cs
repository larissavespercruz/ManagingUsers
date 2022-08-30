using System;

namespace ManagingUsers.Domain.Entities
{
    public class Users
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Email { get; set; }
        public string DataNascimento { get; set; }
        public EEscolaridade Escolaridade { get; set; }
    }
}
