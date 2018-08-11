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
    public partial class ListadoSlitting : ContentPage
    {
        public ListadoSlitting()
        {
            InitializeComponent();
            this.BindingContext = new ListadoSlittingViewModel();
            btnhome.Clicked += Btncreate_Clicked;
            lista.ItemSelected += (sender, e) =>
            {
                if (e.SelectedItem != null)
                {
                    Navigation.PushAsync(new SlittingEdit(e.SelectedItem as SlittingModel));
                }
            };
        }


        private void Btncreate_Clicked(object sender, EventArgs e)
        {
            ((NavigationPage)this.Parent).PushAsync(new Slitting());
        }
    }
}