using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MonkeysApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            if (sender is Button)
            {
                Button b = (Button)sender;
                if (b.Id == BtnStatic.Id)
                    await Navigation.PushAsync(new StaticMonkeysPage());
                if (b.Id == BtnDynamic.Id)
                    await Navigation.PushAsync(new DynamicMonkeysPage());
            }

            

            
        }
    }
}
