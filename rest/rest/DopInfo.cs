using Microsoft.EntityFrameworkCore.Query.Internal;
using Microsoft.ReportingServices.Diagnostics.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rest
{
    class DopInfo
    {
        public void Inf(DataGridView dataGridView)
        {
            restEntities db = new restEntities();
            List<menu> menulist;
            menulist = (from men in db.menu
                        select men).ToList();

            var query = (from men in menulist
                         select new { men.name_item, men.active, men.calories, men.composition, men.gm, men.price }).ToList();
            dataGridView.DataSource = query;
            dataGridView.Columns[0].HeaderText = "Название";
            dataGridView.Columns[1].HeaderText = "Наличие";
            dataGridView.Columns[2].HeaderText = "Калории";
            dataGridView.Columns[3].HeaderText = "Состав";
            dataGridView.Columns[4].HeaderText = "Вес";
            dataGridView.Columns[5].HeaderText = "Цена";
        }

        public void InfOrd(DataGridView dataGridView, int n)
        {
            restEntities db = new restEntities();
            List<menu> menulist;
            menulist = (from men in db.menu
                        select men).ToList();

            //var query = (from t in order1
            //             join g in db.menu on t.id_menu equals g.id_menu
            //             where t.table_n == n
            //             select new { g.name_item, g.calories }).ToList();
            //dataGridView.DataSource = query;
            //dataGridView.Columns[0].HeaderText = "Название";

            var query = (from g in menulist
                         join men in db.order11Set on g.id_menu equals men.id_menu
                         where men.table_n == n
                         select new { g.name_item, g.active, g.calories, g.composition, g.gm, g.price }).ToList();
            dataGridView.DataSource = query;
            dataGridView.Columns[0].HeaderText = "Название";
            dataGridView.Columns[1].HeaderText = "Наличие";
            dataGridView.Columns[2].HeaderText = "Калории";
            dataGridView.Columns[3].HeaderText = "Состав";
            dataGridView.Columns[4].HeaderText = "Вес";
            dataGridView.Columns[5].HeaderText = "Цена";
        }
    }
}
