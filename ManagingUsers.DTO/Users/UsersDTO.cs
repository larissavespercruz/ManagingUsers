﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagingUsers.DTO.Users
{
    public class UsersDTO
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Email { get; set; }
        public string DataNascimento { get; set; }
        public int Escolaridade { get; set; }
    }
}
