﻿using AgendaEF_CF.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaEF_CF.Context
{
    internal class PersonContext: DbContext
    {
        public PersonContext() : base("Telephone_Book") { }

        public DbSet<Person> Persons { get; set; }
        public DbSet<Telephone> Phones { get; set; }

    }
}
