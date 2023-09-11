﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_System
{
    internal class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public User(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public override string ToString()
        {
            return $"Id: {Id}" +
                   $"\tName: {Name}";
        }
    }
}
