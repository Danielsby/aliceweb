﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DatabaseTables.Models
{
    /// <summary>
    /// Represent the data stored in the databas for users. 
    /// It's used by Entity Framework Core to map relational data from the
    /// database into .NET objects for data management and CRUD operations. 
    /// </summary>
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public string Token { get; set;  }
    }
}