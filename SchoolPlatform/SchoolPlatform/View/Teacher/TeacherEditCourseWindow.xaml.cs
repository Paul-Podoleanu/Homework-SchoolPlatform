using Microsoft.VisualBasic.ApplicationServices;
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
   
    public partial class TeacherEditCourseWindow : Window
    {
        SchoolContext SchoolContext;
        TeacherMainViewModel TeacherEdit;
        Course courseToBeEdited;

        public TeacherEditCourseWindow(Model.User user, Course course)
        {
            InitializeComponent();
            SchoolContext = new SchoolContext();
            TeacherEdit = new TeacherMainViewModel(user);
            courseToBeEdited = course;

            //Setup the textboxes with the course's data
            NameBox.Text = course.Name;

            if(course.Description != null)
            {
                DescriptionBox.Text = course.Description;
            }
            else
            {
                  DescriptionBox.Text = "";
            }
        }

        private void btnDone_Click(object sender, RoutedEventArgs e)
        {
            TeacherEdit.EditCourse(courseToBeEdited, NameBox.Text, DescriptionBox.Text);
            MessageBox.Show("Course edited successfully!");
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
