using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using TelerikApp.ViewModels;
using Xamarin.Forms;

namespace TelerikApp.Portable.ViewModels
{
    public class CalendarViewModel : BaseViewModel
    {
        private bool _isOn;
        public bool IsOn
        {
            get
            {
                return _isOn;
            }
            set
            {
                SetProperty(ref _isOn, value);
            }
        }

        public ICommand ToggleButtonStateCommand {private set;get;}
        public CalendarViewModel()
        {
            this.ToggleButtonStateCommand = new Command(() => { switchValue(); });
        }


        private void switchValue() 
        {
            IsOn = !IsOn;
        }

       
    }
}
