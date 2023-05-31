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
    /// Interaction logic for TeacherManageAbsenceView.xaml
    /// </summary>
    public partial class TeacherManageAbsenceView : UserControl
    {
        SchoolContext SchoolContext;
        TeacherMainViewModel TeacherEdit;
        public TeacherManageAbsenceView(User user)
        {
            InitializeComponent();
            SchoolContext = new SchoolContext();
            TeacherEdit = new TeacherMainViewModel(user);
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            
            //Check if the student is selected
            if (StudentUsername.Text == null)
            {
                MessageBox.Show("Please select a student");
                return;
            }
            //Check if the student exists
            if (SchoolContext.Students.FirstOrDefault(s => s.User.Username == StudentUsername.Text) == null)
            {
                MessageBox.Show("Please select a valid student");
                return;
            }

            //Check if the subject is selected
            if (SubjectAddBox.Text == null)
            {
                MessageBox.Show("Please select a subject");
                return;
            }
            //Check if the subject exists
            if (SchoolContext.Subjects.FirstOrDefault(s => s.Name == SubjectAddBox.Text) == null)
            {
                MessageBox.Show("Please select a valid subject");
                return;
            }

            //Add the grade
            Student student = SchoolContext.Students.FirstOrDefault(s => s.User.Username == StudentUsername.Text);
            Subject subject = SchoolContext.Subjects.FirstOrDefault(s => s.Name == SubjectAddBox.Text);
            TeacherEdit.AddAbsence(student, subject);
            MessageBox.Show("Absence added successfully");
        }

        private void btnRemove_Click(object sender, RoutedEventArgs e)
        {
            //Check if id is valid
            if (IdRemoveBox.Text == "")
            {
                MessageBox.Show("Please enter an id");
                return;
            }
            if (Int32.Parse(IdRemoveBox.Text) < 1)
            {
                MessageBox.Show("Please enter a valid id");
                return;
            }
            Absence absence = SchoolContext.Absences.FirstOrDefault(a => a.Id == Int32.Parse(IdRemoveBox.Text));
            if (absence == null)
            {
                MessageBox.Show("Please enter a valid id");
                return;
            }

            TeacherEdit.RemoveAbsence(Int32.Parse(IdRemoveBox.Text));
            MessageBox.Show("Absence removed successfully");
        }
    }
}
