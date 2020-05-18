using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rest
{
    class ClassOrder
    {
        public void Buton(Button button)
        {
            restEntities db = new restEntities();
            List<menu> mn;
            
            mn = (from m in db.menu
                  select m).ToList();
            var query = (from t in mn
                         where (t.active == false && t.name_item == button.Text)
                         select new { t.name_item }).ToList();

            if (query.Count == 1)
                button.Enabled = false;
        }//видимость кнопок для меню

        public void Test(int i,DataGridView dataGridView, int n)
        {
            restEntities db = new restEntities();
            List<order11> order1;
         
            order1 = (from or in db.order11Set
                      select or).ToList();

          
            order11 o1 = new order11 { id_position = 0, id_menu = i, data_order1 = DateTime.Now, table_n = n};
             db.order11Set.Add(o1);
            db.SaveChanges();

            var query = (from t in order1
                         join g in db.menu on t.id_menu equals g.id_menu
                         where t.table_n == n
                         select new {g.name_item }).ToList();
          
           
           dataGridView.DataSource = query;
           dataGridView.Columns[0].HeaderText = "Название";
            Update(n, dataGridView);
        }

        //public void Test(DataGridView dataGridView)
        //{
        //    restEntities db = new restEntities();
        //    List<order11> order1;

        //    order1 = (from or in db.order11Set
        //              select or).ToList();

        //    var query = (from t in order1
        //                 join g in db.menu on t.id_menu equals g.id_menu
        //                 select new { g.name_item }).ToList();
          
        //    dataGridView.DataSource = query;
        //    dataGridView.Columns[1].HeaderText = "Название";
        //}

        public void Drop(int n, DataGridView dataGridView)
        {
            restEntities db = new restEntities();
            List<order11> order1;
            order1 = (from or in db.order11Set
                      select or).ToList();

          
            db.order11Set.RemoveRange(db.order11Set.Where(w => w.table_n == n));
            db.SaveChanges();
            Update(n, dataGridView);
        }

        public void Update(int n, DataGridView dataGridView)
        {
            restEntities db = new restEntities();
            List<order11> order1;
            order1 = (from or in db.order11Set
                      select or).ToList();

            var query = (from t in order1
                         join g in db.menu on t.id_menu equals g.id_menu
                         where t.table_n == n
                         select new { g.name_item }).ToList();

            dataGridView.DataSource = query;
            dataGridView.Columns[0].HeaderText = "Название";
        } 
        public void UpdateMenu1(int men)
        {
            restEntities db = new restEntities();
            List<menu> mn;
            mn = (from m in db.menu
                 select m).ToList();
           
            var result = db.menu.SingleOrDefault(x => x.id_menu == men);
            if (result.active == false)
            {
                result.active = true;
                db.SaveChanges();
                MessageBox.Show("Продукт добавлен в меню");
            }
            else MessageBox.Show("Ошибка! Это блюдо уже в наличии");
        } //менять наличие еды для false

        public void UpdateMenu2(int men)
        {
            restEntities db = new restEntities();
            List<menu> mn;
            mn = (from m in db.menu
                  select m).ToList();

            var result = db.menu.SingleOrDefault(x => x.id_menu == men);
            if (result.active == true)
            {
                result.active = false;
                db.SaveChanges();
                MessageBox.Show("Продукт исключен из меню");
            }
            else MessageBox.Show("Ошибка! Этого блюда уже нет в наличии");
        } //менять наличие еды для true

        public void Report(int n, double SUM)
        {
            restEntities db = new restEntities();
            List<dishes> dish;
            dish = (from or in db.dishes
                    select or).ToList();

            dishes d1 = new dishes
            {
                id_dishes = 0,
                date_dish = DateTime.Now,
                count_dish = Convert.ToInt32(SUM),
                id_empl = 5,
            };

            db.dishes.Add(d1);
            db.SaveChanges();
        } //добавление заказа для отчета в dishes

        public void ShowOrdersK(DataGridView dataGridView)
        {
            restEntities db = new restEntities();
            var query = (from a in db.order11Set
                         join f in db.menu on a.id_menu equals f.id_menu
                         where f.bar_kitchen == "kitchen"
                         select new { f.name_item }).ToList();

            dataGridView.DataSource = query;
            dataGridView.Columns[0].HeaderText = "Название";
        }//вывод активных заказов для кухни

        public void ShowOrdersB(DataGridView dataGridView)
        {
            restEntities db = new restEntities();
            var query = (from a in db.order11Set
                         join f in db.menu on a.id_menu equals f.id_menu
                         where f.bar_kitchen == "bar"
                         select new { f.name_item }).ToList();

            dataGridView.DataSource = query;
            dataGridView.Columns[0].HeaderText = "Название";
        }//вывод активных заказов для бара
    }
}

