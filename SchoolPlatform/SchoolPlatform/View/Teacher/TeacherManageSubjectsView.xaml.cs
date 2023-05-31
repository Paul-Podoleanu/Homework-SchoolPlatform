using SchoolPlatform.Model;
using SchoolPlatform.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SchoolPlatform.View
{
    /// <summary>
    /// Interaction logic for TeacherManageSubjectsView.xaml
    /// </summary>
    public partial class TeacherManageSubjectsView : UserControl
    {
        SchoolContext SchoolContext;
        TeacherMainViewModel TeacherEdit;
        User currentUser;
        public TeacherManageSubjectsView(User user)
        {
            InitializeComponent();
            SchoolContext = new SchoolContext();
            TeacherEdit = new TeacherMainViewModel(user);
            currentUser = user;
        }

        private void btnAddCourse_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void btnDeleteCourse_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnEditCourse_Click(object sender, RoutedEventArgs e)
        {
            //Check if the course is selected
            if (courseNameEditBox.Text == null)
            {
                MessageBox.Show("Please select a course");
                return;
            }
            //Check if the course exists
            if (SchoolContext.Courses.FirstOrDefault(c => c.Name == courseNameEditBox.Text) == null)
            {
                MessageBox.Show("Please select a valid course");
                return;
            }
            //Check if the subject exists
            if (SchoolContext.Subjects.FirstOrDefault(s => s.Name == courseSubjectEditNameBox.Text) == null)
            {
                MessageBox.Show("Please select a valid subject");
                return;
            }

            Course course = SchoolContext.Courses.FirstOrDefault(c => c.Name == courseNameEditBox.Text);

            TeacherEditCourseWindow teacherEditCourseWindow = new TeacherEditCourseWindow(currentUser,course);
            teacherEditCourseWindow.Show();
        }


    }
}
