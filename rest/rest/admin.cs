using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rest
{
    public partial class admin : Form
    {  
        public admin()
        {
            InitializeComponent();
        }
        public void Up(int a)
        {

            switch (a)
            {
                case 1:
                    ClassOrder s1 = new ClassOrder();
                    s1.Update(a, dataGridView7); break;
                case 2:
                    ClassOrder s2 = new ClassOrder();
                    s2.Update(a, dataGridView2); break;
                case 3:
                    ClassOrder s3 = new ClassOrder();
                    s3.Update(a, dataGridView3); break;
                case 4:
                    ClassOrder s4 = new ClassOrder();
                    s4.Update(a, dataGridView4); break;
                case 5:
                    ClassOrder s5 = new ClassOrder();
                    s5.Update(a, dataGridView5); break;
                case 6:
                    ClassOrder s6 = new ClassOrder();
                    s6.Update(a, dataGridView6); break;
            }

        } //обновление по столам
      
        private void admin_Load(object sender, EventArgs e)
        {

        }
        //public void Drop(int a)
        //{

        //    switch (a)
        //    {
        //        case 1:
        //            ClassOrder s1 = new ClassOrder();
        //            s1.Drop(a, dataGridView1); break;
        //        case 2:
        //            ClassOrder s2 = new ClassOrder();
        //            s2.Drop(a, dataGridView2); break;
        //        case 3:
        //            ClassOrder s3 = new ClassOrder();
        //            s3.Drop(a, dataGridView3); break;
        //        case 4:
        //            ClassOrder s4 = new ClassOrder();
        //            s4.Drop(a, dataGridView4); break;
        //        case 5:
        //            ClassOrder s5 = new ClassOrder();
        //            s5.Drop(a, dataGridView5); break;
        //        case 6:
        //            ClassOrder s6 = new ClassOrder();
        //            s6.Drop(a, dataGridView6); break;
        //    }

        //} //удаление по столам
        //public void Dish(int a)
        //{

        //    switch (a)
        //    {
        //        case 1:
        //            ClassOrder s1 = new ClassOrder();
        //            ClassSUM sum1 = new ClassSUM();
        //            s1.Report(a, Convert.ToDouble(sum1.Itog(a))); break;
        //        case 2:
        //            ClassOrder s2 = new ClassOrder();
        //            ClassSUM sum2 = new ClassSUM();
        //            s2.Report(a, Convert.ToDouble(sum2.Itog(a))); break;
        //        case 3:
        //            ClassOrder s3 = new ClassOrder();
        //            ClassSUM sum3 = new ClassSUM();
        //            s3.Report(a, Convert.ToDouble(sum3.Itog(a))); break;
        //        case 4:
        //            ClassOrder s4 = new ClassOrder();
        //            ClassSUM sum4 = new ClassSUM();
        //            s4.Report(a, Convert.ToDouble(sum4.Itog(a))); break;
        //        case 5:
        //            ClassOrder s5 = new ClassOrder();
        //            ClassSUM sum5 = new ClassSUM();
        //            s5.Report(a, Convert.ToDouble(sum5.Itog(a))); break;
        //        case 6:
        //            ClassOrder s6 = new ClassOrder();
        //            ClassSUM sum6 = new ClassSUM();
        //            s6.Report(a, Convert.ToDouble(sum6.Itog(a))); break;
        //    }

        //} //выгрузка в dishes заказа


        private void button4_Click_1(object sender, EventArgs e)
        {
            int n = comboBox1.SelectedIndex + 1;
            Up(n);
        } //обновить

        private void button9_Click(object sender, EventArgs e)
        {
            int a = comboBox1.SelectedIndex + 1;
            DopInfo s1 = new DopInfo();
            s1.InfOrd(dataGridView1, a);
        } //Доп информация по заказам 

        private void button3_Click(object sender, EventArgs e)
        {
            SUMorder a = new SUMorder();
            a.Show();
        } //кнопка счет

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
            this.Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            ClassReports repost = new ClassReports();
            repost.AdminRep();
        } //кнопка закрыть смену

        private void button1_Click(object sender, EventArgs e)
        {
            ClassOrder s = new ClassOrder();
            s.Update(1, dataGridView7);
            s.Update(2, dataGridView2);
            s.Update(3, dataGridView3);
            s.Update(4, dataGridView4);
            s.Update(5, dataGridView5);
            s.Update(6, dataGridView6);
        } //обновить все
    }
}
