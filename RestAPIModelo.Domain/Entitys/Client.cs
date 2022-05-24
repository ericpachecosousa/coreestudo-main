using System;


namespace RestAPIModelo.Domain.Entitys
{
    public class Client : Base
    {
        public string Name { get; set; }
        public string SurName { get; set; }
        public string Email { get; set; }
        public DateTime DateRegistration { get; set; }
        public bool IsAtivo { get; set; }

    }
}
