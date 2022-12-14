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
    public partial class FormLes : System.Windows.Forms.Form
    {
        ctx context = new ctx();
        public FormLes()
        {
            InitializeComponent();
            listBox1.DataSource = (from x in context.Courses
                                   select x).ToList();
            listBox1.DisplayMember = "Name";
            listBox2.DataSource = (from x in context.Instructors
                                   select x).ToList();
            listBox2.DisplayMember = "Name";
            listBox3.DataSource = (from x in context.Days
                                   select x).ToList();
            listBox3.DisplayMember = "Name";
            listBox4.DataSource = (from x in context.Times
                                   select x).ToList();
            listBox4.DisplayMember = "Name";
            listBox5.DataSource = (from x in context.Rooms
                                   select x).ToList();
            listBox5.DisplayMember = "Name";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Lesson ora = new Lesson();
            ora.CourseFk = ((Course)listBox1.SelectedItem).CourseSk;
            ora.InstructorFk = ((Instructor)listBox2.SelectedItem).InstructorSk;
            ora.DayFk = ((Models.Day)listBox3.SelectedItem).DayId;
            ora.TimeFk = ((Time)listBox4.SelectedItem).TimeId;
            ora.RoomFk = ((Room)listBox5.SelectedItem).RoomSk;
            context.Add(ora);
            try
            {
                context.SaveChanges();
            }
            catch (Exception fail)
            {
                MessageBox.Show(fail.Message);
            }
            MessageBox.Show("Hozzáadva");
            this.DialogResult=DialogResult.OK;
        }
    }
}
