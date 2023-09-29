using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using PDC60Module02.ViewModel;

namespace PDC60Module02.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Compass : ContentPage
    {
        public Compass()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            if (!DesignMode.IsDesignModeEnabled)
                ((MyCompassViewModel)BindingContext).StartCommand.Execute(null);
        }

        protected override void OnDisappearing() 
        { 
            base.OnDisappearing(); 
            if(!DesignMode.IsDesignModeEnabled)
                ((MyCompassViewModel)BindingContext).StopCommand.Execute(null); 
        }
    }
}