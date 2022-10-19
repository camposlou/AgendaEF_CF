using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaEF_CF.Models
{
    internal class Telephone
    {
        [Key]
        public int Id { get; set; }
        public string HomePhone { get; set; }
        public string Mobile { get; set; }
        [ForeignKey("Person")]
        public String PersonId { get; set; }

        public virtual Person Person { get; set; }

        public override string ToString()
        {
            return $"Id: {this.Id}\nPersonId: {this.PersonId}\nHomePhone: {this.HomePhone}\nMobile: {this.Mobile}";
        }

    }
}
