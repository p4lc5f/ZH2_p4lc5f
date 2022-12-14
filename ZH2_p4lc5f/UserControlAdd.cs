using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZH2_p4lc5f
{
    public partial class UserControlAdd : UserControl
    {
        public UserControlAdd()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormIns fl = new FormIns();
            fl.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormLes létrehoz = new FormLes();
            létrehoz.ShowDialog();
        }
    }
}
