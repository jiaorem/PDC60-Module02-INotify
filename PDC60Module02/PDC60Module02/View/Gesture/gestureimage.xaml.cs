using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PDC60Module02.View.Gesture
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class gestureimage : ContentPage
    {
        public gestureimage()
        {
            InitializeComponent();
        }

        private async void OnCorrectDrop(object sender, DropEventArgs e)
        {
            await DisplayAlert("Correct", "That's right yeah", "ok pi");
        }

        private void OnIncorrectDragOver(object sender, DragEventArgs e)
        {
            e.AcceptedOperation = DataPackageOperation.None;
        }
    }
}