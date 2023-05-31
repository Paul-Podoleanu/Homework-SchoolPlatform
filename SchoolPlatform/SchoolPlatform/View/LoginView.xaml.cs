using SchoolPlatform.Model;
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
    /// Interaction logic for LoginView.xaml
    /// </summary>
    public partial class LoginView : Window
    {
        public LoginView()
        {
            InitializeComponent();
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if(e.LeftButton==MouseButtonState.Pressed)
            {
                DragMove();
            }
        }

        private void ButtonMinimize_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void ButtonClose_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            string Username = txtUser.Text;
            string Password = new System.Net.NetworkCredential(string.Empty, txtPass.Password).Password;



            using (SchoolContext context = new SchoolContext())
            {
                User searchedUser=context.Users.FirstOrDefault(u => u.Username == Username && u.Password == Password);

                if (searchedUser!=null)
                {
                    //Check role and open the corresponding window
                    if (searchedUser.Role==0)
                    {
                        AdminMainView admin = new AdminMainView(searchedUser);
                        admin.Show();
                        Close();
                    }

                    if (searchedUser.Role==Role.profesor)
                    {
                        TeacherMainView teacher = new TeacherMainView(searchedUser);
                        teacher.Show();
                        Close();
                    } 
                   
                    else if (searchedUser.Role==Role.diriginte)
                    {
                        DiriginteMainView parent = new DiriginteMainView(searchedUser);
                        parent.Show();
                        Close();
                    } 
                    else if (searchedUser.Role==Role.elev)
                    {
                        StudentMainView student = new StudentMainView(searchedUser);
                        student.Show();
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Login failed!");
                    }
                    /**/
                    Close();
                }
                else
                {
                    //Tell them to fuck off
                    MessageBox.Show("Login failed!");
                }
            }
            //MessageBox.Show("I am very sussy");
        }
    }
}
