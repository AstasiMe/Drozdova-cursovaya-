using System;
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
    public partial class EditMenu : Form
    {
        public EditMenu()
        {
            InitializeComponent();
        }

        public void EOrd(int a)
        {
            switch (a)
            {
                case 1:
                    ClassOrder s1 = new ClassOrder();
                    s1.UpdateMenu1(11); break;
                case 2:
                    ClassOrder s2 = new ClassOrder();
                    s2.UpdateMenu1(12); break;
                case 3:
                    ClassOrder s3 = new ClassOrder();
                    s3.UpdateMenu1(13); break;
                case 4:
                    ClassOrder s4 = new ClassOrder();
                    s4.UpdateMenu1(14); break;
                case 5:
                    ClassOrder s5 = new ClassOrder();
                    s5.UpdateMenu1(15); break;
                case 6:
                    ClassOrder s6 = new ClassOrder();
                    s6.UpdateMenu1(16); break;
                case 7:
                    ClassOrder s7 = new ClassOrder();
                    s7.UpdateMenu1(17); break;
                case 8:
                    ClassOrder s8 = new ClassOrder();
                    s8.UpdateMenu1(18); break;
                case 9:
                    ClassOrder s9 = new ClassOrder();
                    s9.UpdateMenu1(19); break;
                case 10:
                    ClassOrder s10 = new ClassOrder();
                    s10.UpdateMenu1(20); break;
            }

        } //редактировать меню для возврата в меню
        public void EOrd1(int a)
        {
            switch (a)
            {
                case 1:
                    ClassOrder s1 = new ClassOrder();
                    s1.UpdateMenu2(11); break;
                case 2:
                    ClassOrder s2 = new ClassOrder();
                    s2.UpdateMenu2(12); break;
                case 3:
                    ClassOrder s3 = new ClassOrder();
                    s3.UpdateMenu2(13); break;
                case 4:
                    ClassOrder s4 = new ClassOrder();
                    s4.UpdateMenu2(14); break;
                case 5:
                    ClassOrder s5 = new ClassOrder();
                    s5.UpdateMenu2(15); break;
                case 6:
                    ClassOrder s6 = new ClassOrder();
                    s6.UpdateMenu2(16); break;
                case 7:
                    ClassOrder s7 = new ClassOrder();
                    s7.UpdateMenu2(17); break;
                case 8:
                    ClassOrder s8 = new ClassOrder();
                    s8.UpdateMenu2(18); break;
                case 9:
                    ClassOrder s9 = new ClassOrder();
                    s9.UpdateMenu2(19); break;
                case 10:
                    ClassOrder s10 = new ClassOrder();
                    s10.UpdateMenu2(20); break;
            }

        } //редактировать меню для приостановки

        private void button1_Click(object sender, EventArgs e)
        {
            int a = comboBox1.SelectedIndex + 1;
            EOrd(a);
           
        } 

        private void button2_Click(object sender, EventArgs e)
        {
            int a = comboBox1.SelectedIndex + 1;
            EOrd1(a);
            
        }
    }
}
