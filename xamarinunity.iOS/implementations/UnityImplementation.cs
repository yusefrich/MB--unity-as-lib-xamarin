using System;
using System.Runtime.InteropServices;
using NativeLibrary;
using UIKit;
using xamarinunity.Interfaces;
using xamarinunity.iOS.implementations;

//[DllImport("UnityBinding")]
[assembly: Xamarin.Forms.Dependency(typeof(UnityImplementation))]
namespace xamarinunity.iOS.implementations
{
    public class UnityImplementation : IUnityLib
    {
        public void InitUnity()
        {
            //throw new NotImplementedException();
            Console.WriteLine("funcao foi chamada");
            //UnityFramework ufw = UnityFramework.LoadUnity();
            //ufw.RunEmbedded();
            //ufw.ShowUnityWindow();

        }
    }
}
