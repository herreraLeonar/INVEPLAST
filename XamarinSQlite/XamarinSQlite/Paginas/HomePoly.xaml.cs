using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinSQlite.Paginas;

namespace XamarinSQlite.Paginas
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class HomePoly : ContentPage
	{
		public HomePoly ()
		{
			InitializeComponent ();
            btnprinting.Clicked += Btnprinting_Clicked;
            btnslitting.Clicked += Btnslitting_Clicked;
        }

        private void Btnslitting_Clicked(object sender, EventArgs e)
        {
            ((NavigationPage)this.Parent).PushAsync(new Corte());
        }

        private void Btnprinting_Clicked(object sender, EventArgs e)
        {
            ((NavigationPage)this.Parent).PushAsync(new ListadoPoly());
        }
    }
}