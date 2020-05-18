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
using System.IO;
using NPOI.XSSF.UserModel;

namespace rest
{
    class ClassManager
    {
        public void Conc(DataGridView dataGridView)
        {
            restEntities db = new restEntities();

            var query = (from e in db.employee
                         join p in db.position on e.id_post equals p.id_post
                         join u in db.users on e.id_user equals u.id_user
                         select new
                         {
                             e.surname_emp,
                             e.name_emp,
                             e.lastname_emp,
                             e.date_emp,
                             p.name_post,
                             p.salary,
                             u.login_user,
                             u.pass_user
                         }).ToList();

            dataGridView.DataSource = query;
            dataGridView.Columns[0].HeaderText = "Фамилия";
            dataGridView.Columns[1].HeaderText = "Имя";
            dataGridView.Columns[2].HeaderText = "Отчество";
            dataGridView.Columns[3].HeaderText = "Дата рождения";
            dataGridView.Columns[4].HeaderText = "Должность";
            dataGridView.Columns[5].HeaderText = "Оклад";
            dataGridView.Columns[6].HeaderText = "Логин";
            dataGridView.Columns[7].HeaderText = "Пароль";
        }//вывод списка сотрудников

        public void Drop(string s, string n, string l)
        {
            restEntities db = new restEntities();

            var query = (from a in db.employee
                         where a.surname_emp == s && a.name_emp == n && a.lastname_emp == l
                         select a).ToList();

            if (query.Count == 1)
            {
                db.employee.RemoveRange(db.employee.Where(w => w.surname_emp == s && w.name_emp == n && w.lastname_emp == l));
                db.SaveChanges();
                MessageBox.Show("Сотрудник удален");
            }
            else MessageBox.Show("Такого сотрудника нет в базе");
        }//удалить сотрудника

        public void AddJ(string f, string n, string l, DateTime date, int i, string log, string pass)
        {
            restEntities db = new restEntities();

            var query = (from e in db.employee
                         join p in db.position on e.id_post equals p.id_post
                         join u in db.users on e.id_user equals u.id_user
                         select new
                         {
                             e.surname_emp,
                             e.name_emp,
                             e.lastname_emp,
                             e.date_emp,
                             p.name_post,
                             p.salary,
                             u.login_user,
                             u.pass_user
                         }).ToList();
            int user = db.users.Max(us => us.id_user);



            employee e1 = new employee
            {
                surname_emp = f,
                name_emp = n,
                lastname_emp = l,
                date_emp = date,
                id_user = user + 1,
                id_post = i + 1
            };

            string role = "";

            if (i == 0)
                role = "manager";
            else if (i == 1)
                role = "admin";
            else if (i == 2)
                role = "ofic";
            else if (i == 3)
                role = "cook";
            else if (i == 4)
                role = "bar";

            users u1 = new users
            {
                id_user = user + 1,
                role_user = role,
                login_user = log,
                pass_user = pass
            };

            db.employee.Add(e1);
            db.users.Add(u1);
            db.SaveChanges();
            MessageBox.Show("Сотрудник добавлен");
        }//добавить нового сотрудника

        public void Edit(employee emp, ComboBox comboBox, TextBox t1, TextBox t2, TextBox t3, MaskedTextBox m, TextBox t4, TextBox t5)
        {
            restEntities db = new restEntities();

            var posit_list = (from i in db.position
                              select i.name_post).Distinct();

            var query = (from i in db.position
                         where i.id_post == emp.id_post
                         select i.name_post).ToList();

            var log = db.users.SingleOrDefault(r => r.id_user == emp.id_user);
           

            //foreach (string it in posit_list)
            //{
            //    comboBox.Items.Add(it);
            //}
            comboBox.SelectedItem = query[0];
            t1.Text = emp.surname_emp.ToString();
            t2.Text = emp.name_emp.ToString();
            t3.Text = emp.lastname_emp.ToString();
            m.Text = emp.date_emp.ToString();
            t4.Text = log.login_user.ToString();
            t5.Text = log.pass_user.ToString();
        }//заполнение формы для редачки

        public void EditFinal(employee emp, ComboBox comboBox, TextBox t1, TextBox t2, TextBox t3, MaskedTextBox m, TextBox t4, TextBox t5)
        {
            restEntities db = new restEntities();
            var query = (from i in db.position
                         where i.id_post == comboBox.SelectedIndex + 1
                         select i.id_post).ToList();

            var log = db.users.SingleOrDefault(r => r.id_user == emp.id_user);
            var result = db.employee.SingleOrDefault(n => n.id_empl == emp.id_empl);

            result.surname_emp = t1.Text.ToString();
            result.name_emp = t2.Text.ToString();
            result.lastname_emp = t3.Text.ToString();
            result.id_post = Convert.ToInt32(query[0]);
            result.date_emp= Convert.ToDateTime(m.Text);
            log.login_user = t4.Text.ToString();
            log.pass_user = t5.Text.ToString();

            db.SaveChanges();
        }//сохранение обновленных значений

        public void Stock(string t1, int t2, DateTime m, string c, double t3)
        {
            restEntities db = new restEntities();
            stock st = new stock
            {
                product = t1,
                quantity = t2,
                unit = c,
                summ = t3,
                date_sup = m,
                id_empl = 2
            };

            db.stock.Add(st);
            db.SaveChanges();
        } //пополнение склада

        public void StockEnter(DataGridView dataGridView)
        {
            restEntities db = new restEntities();

            var query = (from e in db.stock
                         select new  {e.product, e.quantity, e.unit, e.summ, e.date_sup}).ToList();

            dataGridView.DataSource = query;
            dataGridView.Columns[0].HeaderText = "Товар";
            dataGridView.Columns[1].HeaderText = "Количество";
            dataGridView.Columns[2].HeaderText = "Еденица измерения";
            dataGridView.Columns[3].HeaderText = "Итоговая сумма";
            dataGridView.Columns[4].HeaderText = "Дата";
           
        }//вывод отчета со склада

        public void Sort1(DataGridView dataGridView, DateTime a, DateTime b)
        {
           
            restEntities db = new restEntities();

            var query = (from e in db.stock
                         where e.date_sup >= a && e.date_sup <= b
                         select new { e.product, e.quantity, e.unit, e.summ, e.date_sup }).ToList();
            
            dataGridView.DataSource = query;
            dataGridView.Columns[0].HeaderText = "Товар";
            dataGridView.Columns[1].HeaderText = "Количество";
            dataGridView.Columns[2].HeaderText = "Еденица измерения";
            dataGridView.Columns[3].HeaderText = "Итоговая сумма";
            dataGridView.Columns[4].HeaderText = "Дата";
        }//сортировка отчета на складе

        public void DownloadST()
        {
            restEntities db = new restEntities();
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            dialog.DefaultExt = ".xls";

            dialog.Filter = "Таблицы Excel (*.xls)|*.xls|Все файлы (*.*)|*.*";
            dialog.FilterIndex = 1;
            dialog.FileName = "Отчет по закупкам";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var file = new FileStream(dialog.FileName, FileMode.Create, FileAccess.ReadWrite);

                var query = (from d in db.stock
                             orderby d.date_sup
                             select new { d.product, d.quantity, d.unit, d.summ, d.date_sup }).ToList();

                var stosk = new MemoryStream(Properties.Resources.stock, true);
                var workbook = new XSSFWorkbook(stosk);
                var sheet1 = workbook.GetSheet("Лист1");
                int row = 2;

                foreach (var item in query.OrderBy(o => o.date_sup))
                {
                    var rowInsert = sheet1.CreateRow(row);
                    rowInsert.CreateCell(0).SetCellValue(Convert.ToString(item.product));
                    rowInsert.CreateCell(1).SetCellValue(Convert.ToDouble(item.quantity));
                    rowInsert.CreateCell(2).SetCellValue(Convert.ToString(item.unit));
                    rowInsert.CreateCell(3).SetCellValue(Convert.ToDouble(item.summ));
                    rowInsert.CreateCell(4).SetCellValue(Convert.ToString(item.date_sup));
                    row++;
                }
                workbook.Write(file);
            }

        }//скачать отчет склада

        public void DownloadMO()
        {
            restEntities db = new restEntities();
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            dialog.DefaultExt = ".xls";

            dialog.Filter = "Таблицы Excel (*.xls)|*.xls|Все файлы (*.*)|*.*";
            dialog.FilterIndex = 1;
            dialog.FileName = "Отчет по выручке";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var file = new FileStream(dialog.FileName, FileMode.Create, FileAccess.ReadWrite);

                var query = (from d in db.dishes
                             orderby d.date_dish
                             select new { d.date_dish, d.count_dish }).ToList();

                var temp = new MemoryStream(Properties.Resources.temp1, true);
                var workbook = new XSSFWorkbook(temp);
                var sheet1 = workbook.GetSheet("Лист1");
                int row = 2;

                foreach (var item in query.OrderBy(o => o.date_dish))
                {
                    var rowInsert = sheet1.CreateRow(row);
                    rowInsert.CreateCell(1).SetCellValue(Convert.ToString(item.date_dish));
                    rowInsert.CreateCell(2).SetCellValue(Convert.ToDouble(item.count_dish));
                    row++;
                }
                workbook.Write(file);
            }
        }//скачать отчет по выручке

        public void MoneyEnter(DataGridView dataGridView)
        {
            restEntities db = new restEntities();

            var query = (from e in db.dishes
                         select new { e.count_dish, e.date_dish }).ToList();

            dataGridView.DataSource = query;
            dataGridView.Columns[0].HeaderText = "Суммма выручки";
            dataGridView.Columns[1].HeaderText = "Дата";
            

        }//вывод отчета по выручке

        public void Sort2(DataGridView dataGridView, DateTime a, DateTime b)
        {

            restEntities db = new restEntities();

            var query = (from e in db.dishes
                         where e.date_dish >= a && e.date_dish <= b
                         select new { e.count_dish, e.date_dish }).ToList();

            dataGridView.DataSource = query;
            dataGridView.Columns[0].HeaderText = "Сумма выручки";
            dataGridView.Columns[1].HeaderText = "Дата";
           
        }//сортировка отчета по выручке

    }
}
