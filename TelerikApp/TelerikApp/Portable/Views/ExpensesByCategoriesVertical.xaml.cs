using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TelerikApp.Portable.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ExpensesByCategoriesVertical : ContentPage
    {
        public ExpensesByCategoriesVertical()
        {
            InitializeComponent();
        }
    }
}