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
    /// <summary>
    /// Interaction logic for AdminEditSubjectsView.xaml
    /// </summary>
    public partial class AdminEditSubjectsView : UserControl
    {
        SchoolContext SchoolContext;
        AdminEditViewModel AdminEdit;

        public AdminEditSubjectsView()
        {
            InitializeComponent();
            SchoolContext = new SchoolContext();
            AdminEdit = new AdminEditViewModel();
        }

        private void btnAddSubject_Click(object sender, RoutedEventArgs e)
        {
            //To subjects cannot have the same name
            if (subjectNameBox.Text != "")
            {
                using (SchoolContext context = new SchoolContext())
                {
                    Subject searchedSubject = context.Subjects.FirstOrDefault(s => s.Name == subjectNameBox.Text);
                    if (searchedSubject == null)
                    {
                        AdminEdit.AddSubject(subjectNameBox.Text);
                        MessageBox.Show("Subject added successfully!");
                    }
                    else
                    {
                        MessageBox.Show("Subject already exists!");
                    }
                }
            }
            else
            {
                MessageBox.Show("Please enter a name for the subject!");
            }
        }

        private void btnDeleteSubject_Click(object sender, RoutedEventArgs e)
        {
            //Check if the subject exists
            if (subjectNameBox.Text != null)
            {
                using (SchoolContext context = new SchoolContext())
                {
                    Subject searchedSubject = context.Subjects.FirstOrDefault(s => s.Name == subjectDeleteNameBox.Text);
                    if (searchedSubject != null)
                    {
                        AdminEdit.DeleteSubject(searchedSubject);
                        MessageBox.Show("Subject deleted successfully!");
                    }
                    else
                    {
                        MessageBox.Show("Subject does not exist!");
                    }
                }
            }
            else
            {
                MessageBox.Show("Please enter a name for the subject!");
            }
        }

        private void btnAddCourse_Click(object sender, RoutedEventArgs e)
        {
            //Check if the subject exists
            if (courseSubjectNameBox != null)
            {
                using (SchoolContext context = new SchoolContext())
                {
                    Subject searchedSubject = context.Subjects.FirstOrDefault(s => s.Name == courseSubjectNameBox.Text);
                    if (searchedSubject != null)
                    {
                        //Check if the course already exists
                        Course searchedCourse = context.Courses.FirstOrDefault(c => c.Name == courseNameBox.Text);
                        if (searchedCourse == null)
                        {
                            AdminEdit.AddCourse(searchedSubject, courseNameBox.Text);
                            MessageBox.Show("Course added successfully!");
                        }
                        else
                        {
                            MessageBox.Show("Course already exists!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Subject does not exist!");
                    }
                }
            }
            else
            {
                MessageBox.Show("Please enter a name for the course!");
            }
        }

        private void btnDeleteCourse_Click(object sender, RoutedEventArgs e)
        {
            //Check if course exists
            if (courseNameBox != null)
            {
                using (SchoolContext context = new SchoolContext())
                {
                    Course searchedCourse = context.Courses.FirstOrDefault(c => c.Name == courseDeleteNameBox.Text);
                    if (searchedCourse != null)
                    {
                        AdminEdit.DeleteCourse(searchedCourse);
                        MessageBox.Show("Course deleted successfully!");
                    }
                    else
                    {
                        MessageBox.Show("Course does not exist!");
                    }
                }
            }
            else
            {
                MessageBox.Show("Please enter a name for the course!");
            }
        }
    }
}
