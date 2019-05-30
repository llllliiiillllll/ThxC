using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

using Livet;
using Livet.Commands;
using Livet.Messaging;
using Livet.Messaging.IO;
using Livet.EventListeners;
using Livet.Messaging.Windows;

using ThxLivet.Models;

namespace ThxLivet.ViewModels
{
    public class LoginViewModel : ViewModel
    {
        
        #region UserProperty
        private Employee _User;

        public Employee Employee
        {
            get
            { return _User; }
            set
            {
                if (_User == value)
                    return;
                _User = value;
                RaisePropertyChanged();
            }
        }
        #endregion
        public void Initialize()
        {

            this.Employee = new Employee();
        }
        #region LogonCommand
        private ViewModelCommand _LogonCommand;

        public ViewModelCommand LogonCommand
        {
            get
            {
                if (_LogonCommand == null)
                {
                    _LogonCommand = new ViewModelCommand(Logon);
                }
                return _LogonCommand;
            }
        }

        public async void Logon()
        {
            Employee authorizedUser = await this.Employee.LogonAsync();

            if (authorizedUser != null) // Logon 成功
            {
                Messenger.Raise(new WindowActionMessage(WindowAction.Close, "Authorized"));
            }
            else // Logon 失敗
            {
                System.Diagnostics.Debug.WriteLine("ログオンに失敗しました。");
            }

        }
        #endregion
    }
}
