using System;
using UIKit;
using xamarinunity.Interfaces;
using xamarinunity.iOS.implementations;

[assembly: Xamarin.Forms.Dependency(typeof(DeviceOrientationImplementation))]
namespace xamarinunity.iOS.implementations
{
    public class DeviceOrientationImplementation : IDeviceOrientation
    {
        public DeviceOrientation GetOrientation()
        {
            var currentOrientation = UIApplication.SharedApplication.StatusBarOrientation;

            bool isPortrait = currentOrientation == UIInterfaceOrientation.Portrait
                || currentOrientation == UIInterfaceOrientation.PortraitUpsideDown;

            return isPortrait ? DeviceOrientation.Portrait : DeviceOrientation.Landscape;
        }
    }
}
