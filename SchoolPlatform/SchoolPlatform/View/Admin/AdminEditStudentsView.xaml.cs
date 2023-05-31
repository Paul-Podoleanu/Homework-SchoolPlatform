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
using SchoolPlatform.Model;
using SchoolPlatform.Repositories;

namespace SchoolPlatform.View
{
    
    public partial class AdminEditStudentsView : UserControl
    {
        SchoolContext SchoolContext;
        AdminEditViewModel AdminEdit;

        public AdminEditStudentsView()
        {
            InitializeComponent();
            SchoolContext = new SchoolContext();
            AdminEdit= new AdminEditViewModel();
       
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            //This also creates a brand new user for the added student

            //Check if the user already exists in the database (by username or password)
            User searchedUser=SchoolContext.Users.FirstOrDefault(u => u.Username == usernameBox.Text || u.Password == passwordBox.Text);

            if (searchedUser!=null)
            {
                MessageBox.Show("A user with this username or password already exists!");
                return;
            }
            else
            {
                AdminEdit.AddStudent(firstNameBox.Text, lastNameBox.Text, usernameBox.Text, passwordBox.Text);
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
                Student searchedStudent = SchoolContext.Students.FirstOrDefault(s => s.User.Username == username);
                if (searchedStudent == null)
                {
                    MessageBox.Show("A student with this username does not exist!");
                    return;
                }
                else
                {
                    AdminEdit.DeleteStudent(searchedStudent);
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
                Student searchedStudent = SchoolContext.Students.FirstOrDefault(s => s.User.Username == username);
                if (searchedStudent == null)
                {
                    MessageBox.Show("A student with this username does not exist!");
                    return;
                }
                else
                {

                    AdminEditStudentWindowView windowView = new AdminEditStudentWindowView(searchedStudent);
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
