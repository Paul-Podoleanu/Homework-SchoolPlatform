using SchoolPlatform.Model;
using SchoolPlatform.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    public partial class StudentGradesView : UserControl
    {
        User currentUser;
        public StudentGradesView(User user)
        {
            InitializeComponent();
            DataContext = new StudentMainViewModel(user);
            currentUser = user;
        }
    }
}
