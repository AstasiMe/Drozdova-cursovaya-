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
    public partial class DInfo : Form
    {
        public DInfo()
        {
            InitializeComponent();
            DopInfo a = new DopInfo();
            a.Inf(dataGridView1);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DInfo_Load(object sender, EventArgs e)
        {

        }
    }
}
