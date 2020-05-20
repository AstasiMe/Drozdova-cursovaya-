using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using NPOI.XSSF.UserModel;


namespace rest
{
    class ClassReports
    {
        public static string NameNew(string name)
        {
            string new_name = name[0].ToString().ToUpper() + name.Remove(0, 1).ToLower();
            return new_name;
        }
        public void AdminRep()
        {
            restEntities db = new restEntities();
           
            int count = db.order11Set.Count();
            if (count < 1)
            {
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
            }
            else MessageBox.Show("Имеются активные заказы");
        }
    }
}
