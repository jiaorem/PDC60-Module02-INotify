using PDC60Module02.View;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using Xamarin.Essentials;
using Compass = Xamarin.Essentials.Compass;

namespace PDC60Module02.ViewModel
{
    public class MyCompassViewModel : MvvmHelpers.BaseViewModel
    {
        
        public MyCompassViewModel() 
        {
            StopCommand = new Command(stop);
            StartCommand = new Command(start);
        }

        public 

        string headingDisplay;
        public string HeadingDisplay
        {
            get => headingDisplay; 
            set => SetProperty(ref headingDisplay, value);
        }

        double heading = 0;
        public double Heading
        {
            get => heading; 
            set => SetProperty(ref heading, value);
        }

        public Command StopCommand { get; }
        void stop()
        {
            if (!Compass.IsMonitoring)
                return;
            Compass.ReadingChanged -= Compass_ReadingChanged;
        }
        public Command StartCommand { get; }
        void start()
        {
            if (Compass.IsMonitoring)
                return;
            Compass.ReadingChanged += Compass_ReadingChanged;
            Compass.Start(SensorSpeed.UI, true);
        }

        void Compass_ReadingChanged(object sender, CompassChangedEventArgs e)
        {
            Heading = e.Reading.HeadingMagneticNorth;
            HeadingDisplay = $"Heading: {Heading.ToString()}";
        }
    }
}
