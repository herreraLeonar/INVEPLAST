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
    public partial class ListadoPoly : ContentPage
    {
        public ListadoPoly()
        {
            InitializeComponent();
            this.BindingContext = new ListadoPolyViewModel();
            btnhome.Clicked += Btncreate_Clicked;
            lista.ItemSelected += (sender, e) =>
            {
                if (e.SelectedItem != null)
                {
                    Navigation.PushAsync(new PolyEdit(e.SelectedItem as PolyModel));
                }
            };
        }


        private void Btncreate_Clicked(object sender, EventArgs e)
        {
            ((NavigationPage)this.Parent).PushAsync(new Poly());
        }
    }
}

