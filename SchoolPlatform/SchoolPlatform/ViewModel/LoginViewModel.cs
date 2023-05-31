using SchoolPlatform.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Net;
using System.Threading;
using System.Security.Principal;
using System.Windows;

namespace SchoolPlatform.ViewModel
{
    internal class LoginViewModel : ViewModelBase
    {
        //FIELDS
        private string _username;
        private string _password;
        private string _errorMessage;
        private bool _isViewVisible=true;

        //private IUserRepository userRepository;

        //PROPERTIES
        public string Username
        {
            get { return _username; }
            set
            {
                _username = value;
                OnPropertyChanged(nameof(Username));
            }
        }

        public string Password
        {
            get { return _password; }
            set
            {
                _password = value;
                OnPropertyChanged(nameof(Password));
            }
        }

        public string ErrorMessage
        {
            get { return _errorMessage; }
            set
            {
                _errorMessage = value;
                OnPropertyChanged(nameof(ErrorMessage));
            }
        }

        public bool IsViewVisible
        {
            get { return _isViewVisible; }
            set
            {
                _isViewVisible = value;
                OnPropertyChanged(nameof(IsViewVisible));
            }
        }



        //COMMANDS
        public ICommand LoginCommand { get; }


        //CONSTRUCTOR
        public LoginViewModel()
        {
            //userRepository= new UserRepository();
            LoginCommand = new ViewModelCommand(ExecuteLoginCommand, CanExecuteLoginCommand);
        }

        private bool CanExecuteLoginCommand(object obj)
        {
            bool validData;
            if (string.IsNullOrWhiteSpace(Username) || string.IsNullOrWhiteSpace(Password) || Username.Length < 3 || Password.Length < 3)
            {
                validData = false;
            }
            else
            {
                validData = true;
            }

            return validData;
        }

        public void ExecuteLoginCommand(object obj)
        {
            string Username = this.Username;
            string Password = this.Password;

            using (SchoolContext context = new SchoolContext())
            {
                bool userExists = context.Users.Any(u => u.Username == Username && u.Password == Password);

                if (userExists)
                {
                    MessageBox.Show("Login successful!");
                }
                else
                {
                    MessageBox.Show("Login failed!");
                }
            }
        }
    }
}
