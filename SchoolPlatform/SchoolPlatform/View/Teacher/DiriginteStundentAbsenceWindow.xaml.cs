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
    /// Interaction logic for DiriginteStundentAbsenceWindow.xaml
    /// </summary>
    public partial class DiriginteStundentAbsenceWindow : Window
    {
        SchoolContext SchoolContext;
        TeacherMainViewModel TeacherEdit;
        Student studentToBeViewd;

        public DiriginteStundentAbsenceWindow(Student student)
        {
            InitializeComponent();
            SchoolContext = new SchoolContext();

            User user = SchoolContext.Users.FirstOrDefault(u => u.Id == student.User.Id);
            TeacherEdit = new TeacherMainViewModel(user);
            studentToBeViewd = student;

            TeacherEdit.setupStudentAbsences(student);
            StudentText.Text = studentToBeViewd.Prenume + " " + studentToBeViewd.Nume + " Absences";
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }
    }
}
