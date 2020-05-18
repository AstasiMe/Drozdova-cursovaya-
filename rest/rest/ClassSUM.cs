using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rest
{
    class ClassSUM
    {
        public string Itog(int m)
        {
            restEntities db = new restEntities();
            List<order11> summ;

            summ = (from s in db.order11Set
                    select s).ToList();

            var query = (from g in summ
                         join l in db.menu on g.id_menu equals l.id_menu
                         where g.table_n == m
                         select new { l.price }).ToList();
            return query.Sum(n => n.price).ToString();
        }

        public string SUM(double a, double b, double c)
        {

            if (b >= a && c == 0)
            {
               // a = a / 100 * (100 - c);
                return (b - a).ToString();
            }
            else
            { if (c > 0)
                {
                    a = a / 100 * (100 - c);
                    return (b - a).ToString();
                }
                else return "ошибка";
            }
            
        }
    }
}
