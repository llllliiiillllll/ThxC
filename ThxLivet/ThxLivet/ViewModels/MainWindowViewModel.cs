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
using ThxLivet.ViewModels;

namespace misakitry.ViewModels
{
    public class MainWindowViewModel : ViewModel
    {
        

        public void Initialize()
        {
            var message = new TransitionMessage(typeof(ThxLivet.Views.Login), new LoginViewModel(), TransitionMode.Modal, "ShowLogon");
            
            Messenger.Raise(message);
            
        }
    }
}
