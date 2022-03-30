using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace Makula_semestralni_prace.Data.Models
{
    public class Competition
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Competitor> Competitors { get; set; }
        public List<Round> Rounds { get; set; }

    }
}
