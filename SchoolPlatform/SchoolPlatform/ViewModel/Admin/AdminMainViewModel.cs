using SchoolPlatform.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolPlatform.Repositories;
using System.Windows.Input;
using SchoolPlatform.View;
using System.Windows.Controls;
using GalaSoft.MvvmLight.Command;

namespace SchoolPlatform.ViewModel
{
    public class AdminMainViewModel : ViewModelBase
    {
        public UserRepository userRepository { get; set; }
        public UserControl CurrentChildView { get; set; }


        public AdminMainViewModel()
        {
            userRepository = new UserRepository(new SchoolContext());
            CurrentChildView = new AdminEditStudentsView();
        }
    }
}
