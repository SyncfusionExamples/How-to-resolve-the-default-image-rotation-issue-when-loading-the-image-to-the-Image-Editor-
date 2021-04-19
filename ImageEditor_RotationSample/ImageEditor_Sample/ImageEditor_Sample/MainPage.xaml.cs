using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ImageEditor_Sample
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            if (Device.RuntimePlatform == "Android")
                editor.Source = ImageSource.FromFile("test.jpg");
            else
                editor.Source = ImageSource.FromResource("ImageEditor_Sample.test.jpg");
        }
    }
}
