using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using xamarinunity.Interfaces;

namespace xamarinunity
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        private string _tickContract = "tick";

        public ObservableCollection<string> Events { get; set; } = new ObservableCollection<string>();

        public MainPage()
        {
            InitializeComponent();

            BindingContext = this;
        }
        private void ShowOri(object sender, System.EventArgs e)
        {
            //envia mensagem
            //MessagingCenter.Send(this, _tickContract, DateTime.Now);
            //MessagingCenter.Send(this, _ualContract);
            OrientationLabel.Text =
                DependencyService.Get<IDeviceOrientation>().GetOrientation().ToString();
        }
        private void InitUnity(object sender, System.EventArgs e)
        {
            //envia mensagem
            //MessagingCenter.Send(this, _tickContract, DateTime.Now);
            //MessagingCenter.Send(this, _ualContract);
            DependencyService.Get<IUnityLib>().InitUnity();
        }
        private void ShowUnity(object sender, System.EventArgs e)
        {
            //envia mensagem
            //MessagingCenter.Send(this, _tickContract, DateTime.Now);
            //MessagingCenter.Send(this, _ualContract, DateTime.Now);
        }
        private void HandleUnity(object sender, System.EventArgs e)
        {
            //envia mensagem
            MessagingCenter.Subscribe<MainPage, DateTime>(this, _tickContract, (s,a) => {
                Events.Add($"Received message at {a.ToString()}");            }); ;
        }
        void HandleUnity_clear(object sender, EventArgs args)        {            Events.Clear();        }

    }
}
