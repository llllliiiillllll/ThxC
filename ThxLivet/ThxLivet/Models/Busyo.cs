using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Livet;

namespace ThxLivet.Models
{
    public class Busyo : NotificationObject
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
        private string _BusyoName;

        public string BusyoName
        {
            get
            { return _BusyoName; }
            set
            { 
                if (_BusyoName == value)
                    return;
                _BusyoName = value;
                RaisePropertyChanged();
            }
        }


        #endregion

        #region

        private bool _Power;

        public bool Power
        {
            get
            { return _Power; }
            set
            { 
                if (_Power == value)
                    return;
                _Power = value;
                RaisePropertyChanged();
            }
        }

        #endregion
    }
}
