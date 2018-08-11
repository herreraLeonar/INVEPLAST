using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using XamarinSQlite.Models;
using XamarinSQlite.ViewModel;

namespace XamarinSQlite.Paginas
{
    public partial class ListadoConversion : ContentPage
    {
        public ListadoConversion()
        {
            InitializeComponent();
            this.BindingContext = new ListadoConversionViewModel();
            btnhome.Clicked += Btncreate_Clicked;
            lista.ItemSelected += (sender, e) =>
            {
                if (e.SelectedItem != null)
                {
                    Navigation.PushAsync(new ConversionEdit(e.SelectedItem as ConversionModel));
                }
            };
        }


        private void Btncreate_Clicked(object sender, EventArgs e)
        {
            ((NavigationPage)this.Parent).PushAsync(new Conversion());
        }
    }
}