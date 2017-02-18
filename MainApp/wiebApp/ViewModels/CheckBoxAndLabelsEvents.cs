﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wiebApp.ViewModels
{
    class CheckBoxAndLabelsEvents : NotifyPropertyChanged
    {
        private bool _dropGlowIsChecked;
        public bool DropGlowIsChecked
        {
            get { return _dropGlowIsChecked;}
            set
            {
                _dropGlowIsChecked = value;
                OnPropertyChanged();
            }
        }

        public void DropGlowLabel_OnDoubleClick()
        {
            _dropGlowIsChecked = true;
        }
    }
}