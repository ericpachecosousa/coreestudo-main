﻿using System;
using System.Collections.Generic;
using System.Text;

namespace RestAPIModelo.Application.Dtos
{
    public class ClientDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public string Email { get; set; }
    }
}
