using SchoolPlatform.Model;
using SchoolPlatform.Repositories;
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
    /// Interaction logic for AdminEditStudentWindowView.xaml
    /// </summary>
    public partial class AdminEditStudentWindowView : Window
    {
        SchoolContext SchoolContext;
        AdminEditViewModel AdminEdit;
        Student studentToBeEdited;

        public AdminEditStudentWindowView(Student StudentToBeEdited)
        {
            InitializeComponent();
            SchoolContext = new SchoolContext();;
            AdminEdit = new AdminEditViewModel();
            studentToBeEdited = StudentToBeEdited;

            //Setup the textboxes with the student's data
            firstNameBox.Text = studentToBeEdited.Nume;
            lastNameBox.Text = studentToBeEdited.Prenume;
            usernameBox.Text = studentToBeEdited.User.Username;
            passwordBox.Text = studentToBeEdited.User.Password;
        }

        private void btnDone_Click(object sender, RoutedEventArgs e)
        {
            //The string that are sent are the new values for the student, not the old ones
            //The student object is sent in order to identify the student that needs to be edited
            AdminEdit.EditStudent(firstNameBox.Text, lastNameBox.Text, usernameBox.Text, passwordBox.Text, studentToBeEdited);
            MessageBox.Show("Student edited successfully!");
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
