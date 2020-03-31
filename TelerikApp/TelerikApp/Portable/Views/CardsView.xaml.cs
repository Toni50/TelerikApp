using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelerikApp.Portable.Commands;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TelerikApp.Portable.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CardsView : ContentPage
    {
        public CardsView()
        {
            InitializeComponent();

            this.slideView.Commands.Add(new CustomSlideViewCommand());
        }
    }
}