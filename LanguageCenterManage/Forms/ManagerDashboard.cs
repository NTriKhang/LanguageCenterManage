using LanguageCenterManage.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LanguageCenterManage
{
    public partial class ManagerDashboard : Dashboard
    {
        public ManagerDashboard()
        {
            InitializeComponent();
        }
        public void showControl(Control control)
        {
            Content.Controls.Clear();

            control.Dock = DockStyle.Fill;
            control.BringToFront();
            control.Focus();
            Content.Controls.Add(control);
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void btnCourse_Click(object sender, EventArgs e)
        {
            CourseControl courseControl = new CourseControl();
            showControl(courseControl);
        }

        private void btnLanguage_Click(object sender, EventArgs e)
        {
            CouseTypeControl languageControl = new CouseTypeControl();
            showControl(languageControl);
        }

        private void btnClass_Click(object sender, EventArgs e)
        {
            ClassControl classControl = new ClassControl();
            showControl(classControl);
        }

        private void userBtn_Click(object sender, EventArgs e)
        {
            UsersControl usersControl = new UsersControl();
            showControl(usersControl);
        }

        private void btnSchedule_Click(object sender, EventArgs e)
        {
            ScheduleControl scheduleControl = new ScheduleControl();
            showControl(scheduleControl);
        }
    }
}
