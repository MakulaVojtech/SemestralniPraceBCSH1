using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace Makula_semestralni_prace.Data.Models
{
    public class Competitor
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public double Points { get; set; } = 0;
        public string Apelido { get; set; }
        public string Corda { get; set; }
        public string City { get; set; }
        public Category Category { get; set; }
    }
}
