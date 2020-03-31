using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telerik.XamarinForms.DataVisualization.Gauges;
using TelerikApp.Portable.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TelerikApp.Portable.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ExpensesByCategoriesBinding : ContentPage
    {
        public ExpensesByCategoriesBinding()
        {
            InitializeComponent();


            BindingContext = new ExpensesByCategoriesBindingViewModel();

             
        }
    }
}