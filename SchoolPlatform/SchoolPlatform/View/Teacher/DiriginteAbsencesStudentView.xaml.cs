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
    
    public partial class DiriginteAbsencesStudentView : UserControl
    {
        SchoolContext SchoolContext;
        TeacherMainViewModel TeacherEdit;
        User currentUser;
        Teacher currentTeacher;
        public DiriginteAbsencesStudentView(User user)
        {
            InitializeComponent();
            SchoolContext = new SchoolContext();
            TeacherEdit = new TeacherMainViewModel(user);
            currentUser = user;
            currentTeacher = SchoolContext.Teachers.FirstOrDefault(t => t.User.Username == currentUser.Username);

        }

        private void btnCheck_Click(object sender, RoutedEventArgs e)
        {
            
            //Check if username is empty
            if (usernameBox.Text == null)
            {
                MessageBox.Show("Please select a student");
                return;
            }

            Student student = SchoolContext.Students.FirstOrDefault(s => s.User.Username == usernameBox.Text);
            //Check if the student exists
            if (student == null)
            {
                MessageBox.Show("Please select a valid student");
                return;
            }
            /*
            //Check if the student is in the class
            if (student.Class.Id!=currentTeacher.Class.Id)
            {
                MessageBox.Show("Please select a student from your class");
                return;
            }
            */
            DiriginteStundentAbsenceWindow diriginteStundentAbsenceWindow = new DiriginteStundentAbsenceWindow(student);
            diriginteStundentAbsenceWindow.Show();

        }

        private void btnRemove_Click(object sender, RoutedEventArgs e)
        {
            //Check if id is empty
            if (idRemoveBox.Text == null)
            {
                MessageBox.Show("Please select an absence");
                return;
            }
            //Check if the absence exists
            if (SchoolContext.Absences.FirstOrDefault(a => a.Id == int.Parse(idRemoveBox.Text)) == null)
            {
                MessageBox.Show("Please select a valid absence");
                return;
            }
            //Check if the absence is from the teacher's class
            if (SchoolContext.Absences.FirstOrDefault(a => a.Id == int.Parse(idRemoveBox.Text)).Student.Class.Id != currentTeacher.Class.Id)
            {
                MessageBox.Show("Please select an absence from your class");
                return;
            }
            
            TeacherEdit.RemoveAbsence(int.Parse(idRemoveBox.Text));

        }
    }
}
