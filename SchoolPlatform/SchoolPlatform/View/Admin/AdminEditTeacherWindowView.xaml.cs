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
    /// Interaction logic for AdminEditTeacherWindowView.xaml
    /// </summary>
    public partial class AdminEditTeacherWindowView : Window
    {
        SchoolContext SchoolContext;
        AdminEditViewModel AdminEdit;
        Teacher teacherToBeEdited;

        public AdminEditTeacherWindowView(Teacher TeacherToBeEdited)
        {
            InitializeComponent();
            SchoolContext = new SchoolContext();
            AdminEdit = new AdminEditViewModel();
            teacherToBeEdited = TeacherToBeEdited;

            //Setup the textboxes with the teacher's data
            firstNameBox.Text = teacherToBeEdited.LastName;
            lastNameBox.Text = teacherToBeEdited.FirstName;
            usernameBox.Text = teacherToBeEdited.User.Username;
            passwordBox.Text = teacherToBeEdited.User.Password;

        }

        private void btnDone_Click(object sender, RoutedEventArgs e)
        {
            AdminEdit.EditTeacher(firstNameBox.Text, lastNameBox.Text, usernameBox.Text, passwordBox.Text, teacherToBeEdited);
            MessageBox.Show("Teacher edited successfully!");
            Close();
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            Close();
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
