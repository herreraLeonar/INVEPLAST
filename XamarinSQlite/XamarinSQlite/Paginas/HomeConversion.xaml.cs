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
	public partial class HomeConversion : ContentPage
	{
		public HomeConversion ()
		{
			InitializeComponent ();
            btnlist.Clicked += Btnlist_Clicked;
            btncreate.Clicked += Btncreate_Clicked;
		}

        private void Btncreate_Clicked(object sender, EventArgs e)
        {
            ((NavigationPage)this.Parent).PushAsync(new Conversion());
        }

        private void Btnlist_Clicked(object sender, EventArgs e)
        {
            
            ((NavigationPage)this.Parent).PushAsync(new ListadoConversion());
        }
    }
}