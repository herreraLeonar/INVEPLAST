using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinSQlite.Paginas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Home : ContentPage
    {
        public Home()
        {
            InitializeComponent();
            btnprinting.Clicked += Btnprinting_Clicked;
            btnslitting.Clicked += Btnslitting_Clicked;
            btnlamination.Clicked += Btnlamination_Clicked;
            btnconversion.Clicked += Btnconversion_Clicked;
            btnshrink.Clicked += Btnshrink_Clicked;
            btnpoly.Clicked += Btnpoly_Clicked;

        }

        private void Btnpoly_Clicked(object sender, EventArgs e)
        {
            ((NavigationPage)this.Parent).PushAsync(new HomePoly());
        }

        private void Btnshrink_Clicked(object sender, EventArgs e)
        {
            ((NavigationPage)this.Parent).PushAsync(new HomeShrink());
        }

        private void Btnconversion_Clicked(object sender, EventArgs e)
        {
            ((NavigationPage)this.Parent).PushAsync(new HomeConversion());
        }

        private void Btnlamination_Clicked(object sender, EventArgs e)
        {
            ((NavigationPage)this.Parent).PushAsync(new HomeLamination());
        }

        private void Btnslitting_Clicked(object sender, EventArgs e)
        {
            ((NavigationPage)this.Parent).PushAsync(new HomeSlitting());
        }

        private void Btnprinting_Clicked(object sender, EventArgs e)
        {
            ((NavigationPage)this.Parent).PushAsync(new HomePrinting());
        }

    }
}