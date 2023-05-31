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
    /// Interaction logic for AdminManageClassesView.xaml
    /// </summary>
    public partial class AdminManageClassesView : UserControl
    {
        SchoolContext SchoolContext;
        AdminEditViewModel AdminEdit;

        public AdminManageClassesView()
        {
            InitializeComponent();
            SchoolContext = new();
            AdminEdit = new();
        }

        private void btnAddClass_Click(object sender, RoutedEventArgs e)
        {
            //Check if the class already exists
            //It check so the name and the year of study are the same
            //If it exists, it will not be added

            Class searchedClass = SchoolContext.Classes.FirstOrDefault(c => c.Name == ClassAddNameBox.Text && c.YearOfStudy == int.Parse(ClassAddYearBox.Text));

            if (searchedClass != null)
            {
                MessageBox.Show("A class with this name and year of study already exists!");
                return;
            }
            else
            {
                AdminEdit.AddClass(ClassAddNameBox.Text, int.Parse(ClassAddYearBox.Text));
                MessageBox.Show("Class added successfully!");
            }
        }

        private void btnDeleteClass_Click(object sender, RoutedEventArgs e)
        {
            //Check if the class exists
            //It check so the name and the year of study are the same

            Class searchedClass = SchoolContext.Classes.FirstOrDefault(c => c.Name == ClassDeleteNameBox.Text && c.YearOfStudy == int.Parse(ClassDeleteYearBox.Text));

            if (searchedClass == null)
            {
                MessageBox.Show("A class with this name and year of study does not exist!");
                return;
            }
            else
            {
                AdminEdit.DeleteClass(searchedClass);
                MessageBox.Show("Class deleted successfully!");
            }
        }

        private void btnAddStudentToClass_Click(object sender, RoutedEventArgs e)
        {
            //Check if the class exists
            //It check so the name and the year of study are the same

            Class searchedClass = SchoolContext.Classes.FirstOrDefault(c => c.Name == ClassAddStudentClassNameBox.Text && c.YearOfStudy == int.Parse(ClassAddStudentYearBox.Text));

            if (searchedClass == null)
            {
                MessageBox.Show("A class with this name and year of study does not exist!");
                return;
            }
            else
            {
                //Check if the student exists
                //It check so the username exists

                Student searchedStudent = SchoolContext.Students.FirstOrDefault(s => s.User.Username == ClassAddStudentClassUsernameBox.Text);

                if (searchedStudent == null)
                {
                    MessageBox.Show("A student with this name and surname does not exist!");
                    return;
                }
                else
                {
                    //Check if the student is already in a class
                    //If it is, it will not be added

                    if (searchedStudent.Class != null)
                    {
                        MessageBox.Show("This student is already in a class!");
                        return;
                    }
                    AdminEdit.AddStudentToClass(searchedStudent, searchedClass);
                    MessageBox.Show("Student added to class successfully!");
                }
            }
        }

        private void btnRemoveStudentToClass_Click(object sender, RoutedEventArgs e)
        {
            //Check if the class exists
            //It check so the name and the year of study are the same

            Class searchedClass = SchoolContext.Classes.FirstOrDefault(c => c.Name == ClassRemoveStudentClassNameBox.Text && c.YearOfStudy == int.Parse(ClassRemoveStudentYearBox.Text));

            if (searchedClass == null)
            {
                MessageBox.Show("A class with this name and year of study does not exist!");
                return;
            }

            //Check if the student exists
            //It check so the username exists

            Student searchedStudent = SchoolContext.Students.FirstOrDefault(s => s.User.Username == ClassRemoveStudentClassUsernameBox.Text);

            if (searchedStudent == null)
            {
                MessageBox.Show("A student with this username does not exist!");
                return;
            }
            else
            {
                //Check if the student is not in a the class
                //If it is not, it will not be removed

                if (searchedStudent.Class != searchedClass)
                {
                    MessageBox.Show("This student is not in a class!");
                    return;
                }


                AdminEdit.RemoveStudentToClass(searchedStudent, searchedClass);
                MessageBox.Show("Student removed from class successfully!");
            }

        }

        private void btnAssignTeacherToClass_Click(object sender, RoutedEventArgs e)
        {
            //Check if the class exists
            //It check so the name and the year of study are the same

            Class searchedClass = SchoolContext.Classes.FirstOrDefault(c => c.Name == ClassAssignTeacherClassNameBox.Text && c.YearOfStudy == int.Parse(ClassAssignTeacherYearBox.Text));

            if (searchedClass == null)
            {
                MessageBox.Show("A class with this name and year of study does not exist!");
                return;
            }


            //Check if the teacher exists

            Teacher searchedTeacher = SchoolContext.Teachers.FirstOrDefault(t => t.User.Username == ClassAssignTeacherClassUsernameBox.Text);
            
            if (searchedTeacher == null)
            {
                MessageBox.Show("A teacher with this username does not exist!");
                return;
            }

            //Check if teacher is already assigned to the class
            if (searchedTeacher.Classes != null)
            {
                foreach (Class cls in searchedTeacher.Classes)
                {
                    if (cls == searchedClass)
                    {
                        MessageBox.Show("The teacher is already assigned to the class");
                        return;
                    }
                }
            }
            
            AdminEdit.AssignTeacherToClass(searchedTeacher, searchedClass);
            MessageBox.Show("The teacher has been added to the class");
        }

        private void btnRemoveTeacherFromClass_Click(object sender, RoutedEventArgs e)
        {
            //Check if the class exists
            //It check so the name and the year of study are the same

            Class searchedClass = SchoolContext.Classes.FirstOrDefault(c => c.Name == ClassRemoveTeacherClassNameBox.Text && c.YearOfStudy == int.Parse(ClassRemoveTeacherYearBox.Text));

            if (searchedClass == null)
            {
                MessageBox.Show("A class with this name and year of study does not exist!");
                return;
            }


            //Check if the teacher exists

            Teacher searchedTeacher = SchoolContext.Teachers.FirstOrDefault(t => t.User.Username == ClassRemoveTeacherClassUsernameBox.Text);

            if (searchedTeacher == null)
            {
                MessageBox.Show("A teacher with this username does not exist!");
                return;
            }

            //Check if teacher is assigned to the class

            foreach (Class cls in searchedTeacher.Classes)
            {
                if (cls == searchedClass)
                {
                    AdminEdit.RemoveTeacherFromClass(searchedTeacher, searchedClass);
                    MessageBox.Show("The teacher has been removed from the class");
                    return;
                }
            }

            MessageBox.Show("The teacher is not assigned to the class");
            return;
        }

        private void btnAssignClassTeacher_Click(object sender, RoutedEventArgs e)
        {
            //Check if the class exists
            //It check so the name and the year of study are the same

            Class searchedClass = SchoolContext.Classes.FirstOrDefault(c => c.Name == AssignClassTeacherClassNameBox.Text && c.YearOfStudy == int.Parse(AssignClassTeacherYearBox.Text));

            if (searchedClass == null)
            {
                MessageBox.Show("A class with this name and year of study does not exist!");
                return;
            }


            //Check if the teacher exists

            Teacher searchedTeacher = SchoolContext.Teachers.FirstOrDefault(t => t.User.Username == AssignClassTeacherUsernameBox.Text);

            if (searchedTeacher == null)
            {
                MessageBox.Show("A teacher with this username does not exist!");
                return;
            }

            //Check if teacher is already assigned to the class
            if (searchedTeacher.Class ==  searchedClass)
            {
                MessageBox.Show("The teacher is already assined to the class");
                return;
            }

            //Check if teacher is already assigned to a diffrent class
            if (searchedTeacher.Class != searchedClass && searchedTeacher.Class != null)
            {
                MessageBox.Show("The teacher is already assined to another class");
                return;
            }

            AdminEdit.AssignClassTeacher(searchedTeacher, searchedClass);
            MessageBox.Show("The teacher has been assigned to the class");
        }

        private void btnRemoveClassTeacher_Click(object sender, RoutedEventArgs e)
        {
            //Check if the class exists
            //It check so the name and the year of study are the same

            Class searchedClass = SchoolContext.Classes.FirstOrDefault(c => c.Name == RemoveClassTeacherClassNameBox.Text && c.YearOfStudy == int.Parse(RemoveClassTeacherYearBox.Text));

            if (searchedClass == null)
            {
                MessageBox.Show("A class with this name and year of study does not exist!");
                return;
            }


            //Check if the teacher exists

            Teacher searchedTeacher = SchoolContext.Teachers.FirstOrDefault(t => t.User.Username == RemoveClassTeacherUsernameBox.Text);

            if (searchedTeacher == null)
            {
                MessageBox.Show("A teacher with this username does not exist!");
                return;
            }

            //Check if teacher is assigned to the class
            if (searchedTeacher.Class == searchedClass)
            {
                AdminEdit.RemoveClassTeacher(searchedTeacher, searchedClass);
                MessageBox.Show("The teacher has been removed as class teacher");
            }
        }
    }
}
