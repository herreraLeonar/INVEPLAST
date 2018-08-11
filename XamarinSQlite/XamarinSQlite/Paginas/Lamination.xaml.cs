using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using XamarinSQlite.ViewModel;

namespace XamarinSQlite.Paginas
{
    public partial class Lamination : ContentPage
    {
        public Lamination()
        {
            InitializeComponent();
            this.BindingContext = new LaminationViewModel();
            txtmaterial1.Items.Add("Coex 65");
            txtmaterial1.Items.Add("Coex 70");
            txtmaterial1.Items.Add("Coex 94");
            txtmaterial1.Items.Add("Coex 120");
            txtmaterial1.Items.Add("Coex 160");
            txtmaterial1.Items.Add("MPET 12");
            txtmaterial1.Items.Add("SPET 12");
            txtmaterial1.Items.Add("CPET 12");
            txtmaterial1.Items.Add("Nylon 15");
            txtmaterial1.Items.Add("BOPP 20");
            txtmaterial1.Items.Add("BOPP 25");
            txtmaterial1.Items.Add("BOPP 30");
            txtmaterial1.Items.Add("BOPP 40");
            txtmaterial1.Items.Add("PE 100");
            txtmaterial1.Items.Add("PE 125");
            txtmaterial1.Items.Add("PE 150");
            txtmaterial1.Items.Add("PE 170");
            txtmaterial1.Items.Add("PE 180");
            txtmaterial1.Items.Add("PE 200");
            txtmaterial1.Items.Add("PE 225");
            txtmaterial1.Items.Add("PE 250");
            txtmaterial1.Items.Add("PE 280");
            txtmaterial1.Items.Add("PE 300");
            txtmaterial1.Items.Add("PE 325");
            txtmaterial1.Items.Add("PE 350");
            txtmaterial1.Items.Add("PE 400");
            txtmaterial1.Items.Add("PE 425");
            txtmaterial1.Items.Add("PE 450");
            txtmaterial1.Items.Add("PE 500");
            txtmaterial1.Items.Add("PE 525");
            txtmaterial1.Items.Add("PE 550");

            txtmaterial2.Items.Add("Coex 65");
            txtmaterial2.Items.Add("Coex 70");
            txtmaterial2.Items.Add("Coex 94");
            txtmaterial2.Items.Add("Coex 120");
            txtmaterial2.Items.Add("Coex 160");
            txtmaterial2.Items.Add("MPET 12");
            txtmaterial2.Items.Add("SPET 12");
            txtmaterial2.Items.Add("CPET 12");
            txtmaterial2.Items.Add("Nylon 15");
            txtmaterial2.Items.Add("BOPP 20");
            txtmaterial2.Items.Add("BOPP 25");
            txtmaterial2.Items.Add("BOPP 30");
            txtmaterial2.Items.Add("BOPP 40");
            txtmaterial2.Items.Add("PE 100");
            txtmaterial2.Items.Add("PE 125");
            txtmaterial2.Items.Add("PE 150");
            txtmaterial2.Items.Add("PE 170");
            txtmaterial2.Items.Add("PE 180");
            txtmaterial2.Items.Add("PE 200");
            txtmaterial2.Items.Add("PE 225");
            txtmaterial2.Items.Add("PE 250");
            txtmaterial2.Items.Add("PE 280");
            txtmaterial2.Items.Add("PE 300");
            txtmaterial2.Items.Add("PE 325");
            txtmaterial2.Items.Add("PE 350");
            txtmaterial2.Items.Add("PE 400");
            txtmaterial2.Items.Add("PE 425");
            txtmaterial2.Items.Add("PE 450");
            txtmaterial2.Items.Add("PE 500");
            txtmaterial2.Items.Add("PE 525");
            txtmaterial2.Items.Add("PE 550");
            
            btnGuardar.Clicked += Btnguardar_Clicked;
            btnver.Clicked += Btnver_Clicked;
        }

        private void Btnguardar_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Save", "your Lamination has been saved", "ok");
            Navigation.PushAsync(new ListadoLamination());
        }

        private void Btnver_Clicked(object sender, EventArgs e)
        {
            ((NavigationPage)this.Parent).PushAsync(new ListadoLamination());
        }

    }
}
