﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnicomTICManagementSystem.Models
{
    internal class User
    {
        public int Id { get; set; }
        public string UserName {  get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public string Gmail { get; set; }
        public string Role { get; set; }
    }
}
