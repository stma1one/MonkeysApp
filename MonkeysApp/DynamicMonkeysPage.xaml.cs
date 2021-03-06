using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using PageNavigationMonkeys;
namespace MonkeysApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DynamicMonkeysPage : ContentPage
    {
        Monkeys monkeys;
        
            
        public DynamicMonkeysPage()
        {
            monkeys = new Monkeys();
            InitializeComponent();
            InitializeLayout();
            
        }

        private void InitializeLayout()
        {
            this.Content = new StackLayout
            {
                BackgroundColor = Color.DarkBlue


            };
            foreach (Monkey m in monkeys.MonkeyList)
            {
                ImageButton btn = new ImageButton { Source = m.ImageUrl, Aspect = Aspect.AspectFit };
                btn.Clicked += Btn_Clicked;
                btn.BindingContext = m;
                
                ((StackLayout)Content).Children.Add(
                    new StackLayout
                    {
                        Children = {
                            new Label
                            {
                                Text = m.Name,
                                HorizontalTextAlignment=TextAlignment.Center,
                                FontSize=15,
                                TextColor=Color.White


                            },
                            btn






                        }
                    }
                    );
            }
        }

        private async void Btn_Clicked(object sender, EventArgs e)
        {
            if (sender is ImageButton)
            {
                ImageButton b = (ImageButton)sender;
                Page p = new MonkeyDetailsPage();
                p.BindingContext = b.BindingContext;
                await Navigation.PushAsync(p);
            }
                
        }
    }
}