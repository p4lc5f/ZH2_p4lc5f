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
    public partial class Formalap : System.Windows.Forms.Form
    {
        public Formalap()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            UserControlView ucv = new UserControlView();
            panel1.Controls.Add(ucv);
            ucv.Dock=DockStyle.Fill;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            UserControlAdd uca = new UserControlAdd();
            panel1.Controls.Add(uca);
            uca.Dock = DockStyle.Fill;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            UserControlDelete ucd = new UserControlDelete();
            panel1.Controls.Add(ucd);
            ucd.Dock = DockStyle.Fill;
        }

        private void Formalap_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult zaro = MessageBox.Show("Biztos be akarod zárni a programot?", "Bezárás", MessageBoxButtons.YesNo);
            if(zaro == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
