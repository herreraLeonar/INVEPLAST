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
	public partial class HomeLamination : ContentPage
	{
		public HomeLamination ()
		{
			InitializeComponent ();
            btnList.Clicked += BtnList_Clicked;
            btnCreate.Clicked += BtnCreate_Clicked;
        }

        private void BtnCreate_Clicked(object sender, EventArgs e)
        {
            ((NavigationPage)this.Parent).PushAsync(new Lamination());
        }

        private void BtnList_Clicked(object sender, EventArgs e)
        {
            ((NavigationPage)this.Parent).PushAsync(new ListadoLamination());
        }
    }
}
