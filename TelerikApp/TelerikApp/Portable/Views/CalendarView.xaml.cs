using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelerikApp.Portable.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TelerikApp.Portable.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CalendarView : ContentPage
    {
        public CalendarView()
        {
            InitializeComponent();

            this.BindingContext = new CalendarViewModel();
        }

        private void calendar_SelectionChanged(object sender, Telerik.XamarinForms.Input.Calendar.CalendarSelectionChangedEventArgs<object> e)
        {
            int a = 1;
        }
    }
}