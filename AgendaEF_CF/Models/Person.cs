using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace AgendaEF_CF.Models
{
    internal class Person
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }    
        public string Mail { get; set; }


        public override string ToString()
        {
            return $"Name: {this.Name}" +
                $"\nMail: {this.Mail}";
        }
    }
}
