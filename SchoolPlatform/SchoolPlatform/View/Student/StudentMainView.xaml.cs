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
    
    public partial class StudentMainView : Window
    {
        User currentUser;
        SchoolContext schoolContext = new SchoolContext();

        public StudentMainView(User user)
        {
            InitializeComponent();
            currentUser = user;
            DataContext = new StudentMainViewModel(user);
            captionTxt.Text = user.FirstName + " " + user.LastName;
        }
        private void ButtonClose_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void showGrades_Click(object sender, RoutedEventArgs e)
        {
            contentZone.Content = new StudentGradesView(currentUser);
        }

        private void showAbsences_Click(object sender, RoutedEventArgs e)
        {
            contentZone.Content = new StudentAbsencesView(currentUser);
        }

        private void showCourses_Click(object sender, RoutedEventArgs e)
        {
            contentZone.Content = new StudentCoursesView(currentUser);
        }
    }
}
