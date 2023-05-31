using SchoolPlatform.Model;
using SchoolPlatform.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
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
    public partial class AdminMainView : Window
    {
        //Declarations
        User userData;
        UserRepository userRepository = new UserRepository(new SchoolContext());
        UserControl _currentContent;

        UserControl CurrentContent
        {
            get { return _currentContent; }
            set
            {
                _currentContent = value;
                contentZone.Content = _currentContent;
            }
        }

        public AdminMainView(User user)
        {
            userData = user;
            InitializeComponent();
            captionTxt.Text =userData.FirstName + " " + userData.LastName;
        }

        //Incercat, dar nu merge sa schimbe forma
        /*
        [DllImport("user32.dll")]
        public static extern IntPtr SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);
         */
        private void ControlBar_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }
        
        private void ButtonClose_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void showEditStudents(object sender, RoutedEventArgs e)
        {
            contentZone.Content = new AdminEditStudentsView();
        }

        private void showEditProfesors(object sender, RoutedEventArgs e)
        {
            contentZone.Content = new AdminEditTeachersView();
        }

        private void showEditSubject(object sender, RoutedEventArgs e)
        {
            contentZone.Content = new AdminEditSubjectsView();
        }

        private void showManageClasses(object sender, RoutedEventArgs e)
        {
            contentZone.Content = new AdminManageClassesView();
        }

        private void contentZone_Scroll(object sender, System.Windows.Controls.Primitives.ScrollEventArgs e)
        {
            
        }
    }
}
