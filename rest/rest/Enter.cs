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
    class Enter
    {
        public void Ent(string a, string b)
        {
            restEntities db = new restEntities();
            var query = (from q in db.users
                         where (q.login_user == a && q.pass_user == b)
                         select new { q.role_user }).ToList();
            var f = db.users.SingleOrDefault(p => p.login_user == a && p.pass_user == b);

            if (query.Count == 1)
            {

                if (f.role_user == "ofic")
                {
                    ofic of = new ofic();
                    of.Show();
                }
                else
                {
                    if (f.role_user == "cook")
                    {
                        cook c = new cook();
                        c.Show();
                    }
                    else
                    {
                        if (f.role_user == "bar")
                        {
                            bar c = new bar();
                            c.Show();

                        }
                        else
                        {
                            if (f.role_user == "admin")
                            {
                                admin ad = new admin();
                                ad.Show();
                            }
                            else
                            {
                                if (f.role_user == "manager")
                                {
                                    manager c = new manager();
                                    c.Show();
                                }
                            }
                        }
                    }
                }

            }
            else { MessageBox.Show("Неверный логин или пароль!");
                Form1 fofm = new Form1();
                fofm.Show();
            }

        }
    }
}
