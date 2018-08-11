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
    public partial class ListadoShrink : ContentPage
    {
        public ListadoShrink()
        {
            InitializeComponent();
            this.BindingContext = new ListadoShrinkViewModel();
            btnhome.Clicked += Btncreate_Clicked;
            lista.ItemSelected += (sender, e) =>
            {
                if (e.SelectedItem != null)
                {
                    Navigation.PushAsync(new ShrinkEdit(e.SelectedItem as ShrinkModel));
                }
            };
        }


        private void Btncreate_Clicked(object sender, EventArgs e)
        {
            ((NavigationPage)this.Parent).PushAsync(new Shrink());
        }
    }
}

