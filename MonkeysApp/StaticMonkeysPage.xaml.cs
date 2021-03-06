using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PageNavigationMonkeys;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MonkeysApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StaticMonkeysPage : ContentPage
    {
       public Monkey M1 { get; set; }
        public Monkey M2 { get; set; }
        public Monkey M3 { get; set; }
        public StaticMonkeysPage()
        {

            Monkeys monkeys = new Monkeys();
            M1 = monkeys.MonkeyList[0];
            M2 = monkeys.MonkeyList[1];
            M3 = monkeys.MonkeyList[2];
            InitializeComponent();
            Img1.BindingContext = M1;
            Img2.BindingContext = M2;
            Img3.BindingContext = M3;
            
        }

    

        private async void Img_Clicked(object sender, EventArgs e)
        {
            if(sender is ImageButton)
            {

                MonkeyDetailsPage p = new MonkeyDetailsPage();
                p.BindingContext = ((ImageButton)sender).BindingContext;
                await Navigation.PushAsync(p);
            }
        }
    }
}