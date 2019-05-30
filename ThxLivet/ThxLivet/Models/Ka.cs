using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Livet;

namespace ThxLivet.Models
{
    public class Ka : NotificationObject
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

        private string _KaName;

        public string KaName
        {
            get
            { return _KaName; }
            set
            { 
                if (_KaName == value)
                    return;
                _KaName = value;
                RaisePropertyChanged();
            }
        }

        #endregion

        #region

        private int _Busyo;

        public int Busyo
        {
            get
            { return _Busyo; }
            set
            { 
                if (_Busyo == value)
                    return;
                _Busyo = value;
                RaisePropertyChanged();
            }
        }

        #endregion
    }
}
