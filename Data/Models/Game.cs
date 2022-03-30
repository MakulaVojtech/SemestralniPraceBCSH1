using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace Makula_semestralni_prace.Data.Models
{
    public class Game
    {
        [Key]
        public int Id { get; set; }
        public Competitor Competitor1 { get; set; }
        public Competitor Competitor2 { get; set; }
    }
}
