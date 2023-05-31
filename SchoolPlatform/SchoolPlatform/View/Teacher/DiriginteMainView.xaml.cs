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
using System.Windows.Shapes;

namespace SchoolPlatform.View
{
    /// <summary>
    /// Interaction logic for DiriginteMainView.xaml
    /// </summary>
    public partial class DiriginteMainView : Window
    {
        User currentUser;
        Class currentClass;
        SchoolContext schoolContext = new SchoolContext();
        public DiriginteMainView(User user)
        {
            InitializeComponent();
            currentUser = user;
            DataContext = new TeacherMainViewModel(user);
            captionTxt.Text = user.FirstName + " " + user.LastName;

            //Get the teacher object associeted with the user
            Teacher classTeacher= schoolContext.Teachers.FirstOrDefault(t => t.User.Username == user.Username);

            //Get the class object associated with the teacher
            currentClass = schoolContext.Classes.FirstOrDefault(c => c.Id_teacher == classTeacher.Id);
            
            
        }

        private void ButtonClose_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void showManageGrades(object sender, RoutedEventArgs e)
        {
            contentZone.Content = new TeacherManageGradesView(currentUser);
        }

        private void showManageAbsence(object sender, RoutedEventArgs e)
        {
            contentZone.Content = new TeacherManageAbsenceView(currentUser);
        }

        private void showManageSubjects(object sender, RoutedEventArgs e)
        {
            contentZone.Content = new TeacherManageSubjectsView(currentUser);
        }

        private void showAbsencesStudent(object sender, RoutedEventArgs e)
        {
            contentZone.Content = new DiriginteAbsencesStudentView(currentUser);
        }

        private void showGradeAverages(object sender, RoutedEventArgs e)
        {
            contentZone.Content = new DiriginteGradeAverageView(currentUser);
        }
    }
}
