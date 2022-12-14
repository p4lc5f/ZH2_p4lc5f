using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZH2_p4lc5f.Models;

namespace ZH2_p4lc5f
{
    public partial class UserControlDelete : UserControl
    {
        ctx context = new ctx();
        public UserControlDelete()
        {
            InitializeComponent();
            lista();
            dgv();
        }
        void lista()
        {
            listBox1.DataSource=(from x in context.Instructors
                                 select x).ToList();
            listBox1.DisplayMember = "Name";
        }
        void dgv()
        {
            var kiv = (from x in context.Instructors
                       select x).ToList();
            instructorBindingSource.DataSource = kiv;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult torol = MessageBox.Show("Biztos ki akarod törölni őt?", "Törlő", MessageBoxButtons.YesNo);
            if(torol == DialogResult.Yes)
            {
                if (listBox1.SelectedItem == null) return;
                var chosenone = ((Instructor)listBox1.SelectedItem).InstructorSk;
                var dins = (from x in context.Instructors
                            where x.InstructorSk == chosenone
                            select x).FirstOrDefault();
                var dora = (from x in context.Lessons
                            where x.InstructorFk == chosenone
                            select x);
                while(dora.Count()>0)
                {
                    context.Lessons.Remove(dora.FirstOrDefault());
                    try
                    {
                        context.SaveChanges();
                    }
                    catch (Exception fail)
                    {
                        MessageBox.Show(fail.Message);
                    }
                }
                context.Instructors.Remove(dins);
                try
                {
                    context.SaveChanges();
                }
                catch (Exception fail)
                {
                    MessageBox.Show(fail.Message);
                }
                lista();
                dgv();
            }
            else
            {
                return;
            }
        }
    }
}
