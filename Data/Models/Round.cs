using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace Makula_semestralni_prace.Data.Models
{
    public class Round
    {
        [Key]
        public int Id { get; set; }
        public int RoundNo { get; set; }
        public List<Game> Games { get; set; }
    }
}
