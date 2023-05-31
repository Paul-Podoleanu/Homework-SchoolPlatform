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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SchoolPlatform.View
{
    public partial class AdminEditTeachersView : UserControl
    {
        SchoolContext SchoolContext;
        AdminEditViewModel AdminEdit;

        public AdminEditTeachersView()
        {
            InitializeComponent();
            SchoolContext = new();
            AdminEdit = new();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            //This also creates a brand new user for the added teacher

            //Check if the user already exists in the database (by username or password)

            User searchedUser = SchoolContext.Users.FirstOrDefault(u => u.Username == usernameBox.Text || u.Password == passwordBox.Text);

            if (searchedUser != null)
            {
                MessageBox.Show("A user with this username or password already exists!");
                return;
            }
            else
            {
                AdminEdit.AddTeacher(firstNameBox.Text, lastNameBox.Text, usernameBox.Text, passwordBox.Text);
            }
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            string username = usernameDltBox.Text;

            //Check if the user exists in the database (by username)
            User searchedUser = SchoolContext.Users.FirstOrDefault(u => u.Username == username);
            if (searchedUser != null)
            {
                //Check if the user is a student
                Teacher searchedTeacher = SchoolContext.Teachers.FirstOrDefault(s => s.User.Username == username);
                if (searchedTeacher == null)
                {
                    MessageBox.Show("A student with this username does not exist!");
                    return;
                }
                else
                {
                    AdminEdit.DeleteTeacher(searchedTeacher);
                }
            }
            else
            {
                MessageBox.Show("A user with this username does not exist!");
                return;
            }
        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            string username = usernameEdtBox.Text;

            //Check if the user exists in the database (by username)
            User searchedUser = SchoolContext.Users.FirstOrDefault(u => u.Username == username);
            if (searchedUser != null)
            {
                //Check if the user is a student
                Teacher searchedTeacher = SchoolContext.Teachers.FirstOrDefault(s => s.User.Username == username);
                if (searchedTeacher == null)
                {
                    MessageBox.Show("A student with this username does not exist!");
                    return;
                }
                else
                {

                    AdminEditTeacherWindowView windowView = new AdminEditTeacherWindowView(searchedTeacher);
                    windowView.Show();
                }
            }
            else
            {
                MessageBox.Show("A user with this username does not exist!");
                return;
            }
        }
    }
}
