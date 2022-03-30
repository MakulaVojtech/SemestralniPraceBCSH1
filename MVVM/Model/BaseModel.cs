using Makula_semestralni_prace.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Makula_semestralni_prace.MVVM.Model
{
    public class BaseModel
    {
        public BaseModel()
        {
            using(var db = new DatabaseContext())
            {
                Console.WriteLine($"aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa{db.DbPath}");
            }
        }
    }
}
