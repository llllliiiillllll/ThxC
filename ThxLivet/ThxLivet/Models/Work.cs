﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Livet;

namespace ThxLivet.Models
{
    public class Work : NotificationObject
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

        private int _WorkRelation;

        public int WorkRelation
        {
            get
            { return _WorkRelation; }
            set
            { 
                if (_WorkRelation == value)
                    return;
                _WorkRelation = value;
                RaisePropertyChanged();
            }
        }

        #endregion

    }
}
