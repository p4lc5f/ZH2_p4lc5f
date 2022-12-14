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
using System.Text.RegularExpressions;

namespace ZH2_p4lc5f
{
    public partial class FormIns : Form
    {
        ctx context = new ctx();
        public FormIns()
        {
            InitializeComponent();
            lista1();
            lista2();
            instructorBindingSource.DataSource = context.Instructors.ToList();
        }
        void lista1()
        {
            listBox1.DataSource = (from x in context.Statuses
                                   select x).ToList();
            listBox1.DisplayMember = "Name";
        }
        void lista2()
        {
            listBox2.DataSource=(from x in context.Employements
                                 select x).ToList();
            listBox2.DisplayMember = "Name";
        }
        private bool check(string név)
        {
            Regex r = new Regex("^[a-zA-Z.]+$");
            return r.IsMatch(név);
        }

        private void textBox1_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(textBox1, "");
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            if(!string.IsNullOrEmpty(textBox1.Text)&&!check(textBox1.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(textBox1, "Nem jó a titulus!");
            }
        }

        private void textBox2_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(textBox2, "");
        }

        private void textBox2_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrEmpty(textBox2.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(textBox2, "Írj ide valamit!");
            }
            else if(!check(textBox2.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(textBox2, "Nem jó a név!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(this.ValidateChildren())
            {
                Instructor ujjonc = new Instructor();
                ujjonc.Salutation = textBox1.Text;
                ujjonc.Name = textBox2.Text;
                ujjonc.StatusFk = ((Status)listBox1.SelectedItem).StatusId;
                ujjonc.EmployementFk = ((Employement)listBox2.SelectedItem).EmployementId;
                context.Add(ujjonc);
                try
                {
                    context.SaveChanges();
                }
                catch (Exception fail)
                {
                    MessageBox.Show(fail.Message);
                }
                MessageBox.Show("Hozzáadva");
                instructorBindingSource.DataSource = context.Instructors.ToList();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
