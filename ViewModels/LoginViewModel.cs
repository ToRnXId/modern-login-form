﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace modern_login_form.ViewModels
{
    public class LoginViewModel : ViewModelBase
    {
        //Fields
        private string _userName;
        private SecureString _password;
        private string _errorMessage;
        private bool _isVisible = true;

        //Property
        public string UserName 
        { 
            get => _userName; 
            set { _userName = value; OnPropertyChanged(nameof(UserName)); } 
        }

        public SecureString Password 
        { 
            get => _password; 
            set { _password = value; OnPropertyChanged(nameof(Password)); } 
        }

        public string ErrorMessage 
        { 
            get => _errorMessage; 
            set { _errorMessage = value; OnPropertyChanged(nameof(ErrorMessage)); } 
        }

        public bool IsVisible 
        { 
            get => _isVisible; 
            set { _isVisible = value; OnPropertyChanged(nameof(IsVisible)); } 
        }

        //-> Commands
        public ICommand LoginCommand { get; }
        public ICommand RecoverPasswordCommand { get; }
        public ICommand ShowPasswordCommand { get; }
        public ICommand RememberPasswordCommand { get; }

        //Constructor
        public LoginViewModel()
        {
            LoginCommand = new ViewModelCommand(ExecuteLoginCommand, CanExecuteLoginCommand);
            RecoverPasswordCommand = new ViewModelCommand(p => ExecuteRecoverPasswordCommand("",""));
        }

        private bool CanExecuteLoginCommand(object obj)
        {
            bool validData;
            if (string.IsNullOrWhiteSpace(UserName) || UserName.Length < 3 ||
                Password == null || Password.Length < 3)
                validData = false;
            else 
                validData = true;

            return validData;
        }

        private void ExecuteLoginCommand(object obj)
        {
            throw new NotImplementedException();
        }

        private void ExecuteRecoverPasswordCommand(string username, string email)
        {
            throw new NotImplementedException();
        }
    }
}
