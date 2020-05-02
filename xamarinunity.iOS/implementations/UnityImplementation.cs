using System;
using NativeLibrary;
using UIKit;
using xamarinunity.Interfaces;
using xamarinunity.iOS.implementations;

[assembly: Xamarin.Forms.Dependency(typeof(UnityImplementation))]
namespace xamarinunity.iOS.implementations
{
    public class UnityImplementation : IUnityLib
    {
        public void InitUnity()
        {
            //throw new NotImplementedException();

            UnityFramework ufw = UnityFramework.LoadUnity();
            ufw.RunEmbedded();
            ufw.ShowUnityWindow();

        }
    }
}
