using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Livet;

namespace ThxLivet.Models
{
    public class TNKCD : NotificationObject
    {
        /*
         * NotificationObjectはプロパティ変更通知の仕組みを実装したオブジェクトです。
         */

        #region

        private int _Id;

        public int Id
        {
            get
            { return _Id; }
            set
            { 
                if (_Id == value)
                    return;
                _Id = value;
                RaisePropertyChanged();
            }
        }

        #endregion

        #region

        private int _CD;

        public int CD
        {
            get
            { return _CD; }
            set
            { 
                if (_CD == value)
                    return;
                _CD = value;
                RaisePropertyChanged();
            }
        }

        #endregion

        #region

        private DateTime _DateSend;

        public DateTime DateSend
        {
            get
            { return _DateSend; }
            set
            { 
                if (_DateSend == value)
                    return;
                _DateSend = value;
                RaisePropertyChanged();
            }
        }

        #endregion

        #region

        private DateTime _DateHelp;

        public DateTime DateHelp
        {
            get
            { return _DateHelp; }
            set
            { 
                if (_DateHelp == value)
                    return;
                _DateHelp = value;
                RaisePropertyChanged();
            }
        }

        #endregion

        #region

        private int _EmployeeTo;

        public int EmployeeTo
        {
            get
            { return _EmployeeTo; }
            set
            { 
                if (_EmployeeTo == value)
                    return;
                _EmployeeTo = value;
                RaisePropertyChanged();
            }
        }

        #endregion

        #region

        private int _EmployeeFrom;


        public int EmployeeFrom
        {
            get
            { return _EmployeeFrom; }
            set
            { 
                if (_EmployeeFrom == value)
                    return;
                _EmployeeFrom = value;
                RaisePropertyChanged();
            }
        }

        #endregion

        #region

        private string _Title;

        public string Title
        {
            get
            { return _Title; }
            set
            { 
                if (_Title == value)
                    return;
                _Title = value;
                RaisePropertyChanged();
            }
        }

        #endregion

        #region

        private string _Body;

        public string Body
        {
            get
            { return _Body; }
            set
            { 
                if (_Body == value)
                    return;
                _Body = value;
                RaisePropertyChanged();
            }
        }

        #endregion

        #region

        private int _Work;

        public int Work
        {
            get
            { return _Work; }
            set
            { 
                if (_Work == value)
                    return;
                _Work = value;
                RaisePropertyChanged();
            }
        }

        #endregion

        #region

        private bool _Look;

        public bool Look
        {
            get
            { return _Look; }
            set
            { 
                if (_Look == value)
                    return;
                _Look = value;
                RaisePropertyChanged();
            }
        }

        #endregion


    }
}
