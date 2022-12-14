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
    public partial class UserControlView : UserControl
    {
        ctx context = new ctx();
        public UserControlView()
        {
            InitializeComponent();
            lista1();
            instructorBindingSource.DataSource = context.Instructors.ToList();
            dayBindingSource.DataSource=context.Days.ToList();
            timeBindingSource.DataSource=context.Times.ToList();
        }
        void lista1()
        {
            listBox1.DataSource = (from x in context.Courses
                                   where x.Name.Contains(textBox1.Text)
                                   select new kisosztaly
                                   {
                                       CourseSk=x.CourseSk,
                                       Name=x.Name
                                   }).ToList();
            listBox1.DisplayMember = "Name";
        }
        void lista2()
        {
            listBox2.DataSource = (from x in context.Rooms
                                   where x.Name.Contains(textBox2.Text)
                                   select x).ToList();
            listBox2.DisplayMember = "Name";
        }
        void dgv()
        {
            var kivc= ((kisosztaly)listBox1.SelectedItem).CourseSk;
            var kivr =((Room)listBox2.SelectedItem).RoomSk;
            var jelen = (from x in context.Lessons
                         where x.CourseFk == kivc && x.RoomFk == kivr
                         select new nagyosztaly
                         {
                             LessonSk=x.LessonSk,
                             InstruktorSk=x.InstructorFk,
                             DayFk=x.DayFk,
                             TimeFk=x.TimeFk
                         }).ToList();
            nagyosztalyBindingSource.DataSource = jelen;
            label1.Text = $"{jelen.Count()} darab óra";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            lista1();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            lista2();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            lista2();
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgv();
        }
    }
    public class kisosztaly
    {
        public int CourseSk { get; set; }
        public string Name { get; set; }
    }
    public class nagyosztaly
    {
        public int LessonSk { get; set; }
        public int? InstruktorSk { get; set; }
        public byte? DayFk { get; set; }
        public byte? TimeFk { get; set; }
    }
}
