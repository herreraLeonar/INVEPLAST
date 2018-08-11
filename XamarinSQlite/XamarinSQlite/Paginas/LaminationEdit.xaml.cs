using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinSQlite.Models;
using XamarinSQlite.ViewModel;

namespace XamarinSQlite.Paginas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LaminationEdit : ContentPage
    {
        public ICommand Modificar1 { get; private set; }
        public ICommand Eliminar1 { get; private set; }
        public LaminationModel lamination;
        public string ma1;
        public string ma2;
        public string ga1;
        public string ga2;
        public string si1;
        public string si2;
        public string re1;
        public string re2;
        public string scr;
        public string fin;
        public LaminationEdit(LaminationModel lam)
        {
            InitializeComponent();
            lamination = lam;
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
            BindingContext = lam;
            btnver.Clicked += Btnver_Clicked;
            btnmodificar.Clicked += Btnmodificar_Clicked;
            btneliminar.Clicked += Btneliminar_Clicked;
        }
        private void Btneliminar_Clicked(object sender, EventArgs e)
        {
            using (var contexto = new DataContextLamination())
            {
                contexto.Eliminar(lamination);
            }

            DisplayAlert("Delete", "your material has been delete", "ok");
            Navigation.PushAsync(new ListadoLamination());
        }

        private void Btnmodificar_Clicked(object sender, EventArgs e)
        {
            ma1 = Convert.ToString(txtmaterial1.SelectedItem);
            ma2 = Convert.ToString(txtmaterial2.SelectedItem);
            ga1 = txtGauge1.Text;
            ga2 = txtGauge2.Text;
            si1 = txtsize1.Text;
            si2 = txtsize2.Text;
            re1 = txtreturned1.Text;
            re2 = txtreturned2.Text;
            scr = txtscrap.Text;
            fin = txtfinished.Text;
            LaminationModel mod = new LaminationModel()
            {
                Material1 = ma1,
                Material2=ma2,
                Gauge1=ga1,
                Gauge2=ga2,
                Size1=si1,
                Size2=si2,
                Returned1=re1,
                Returned2=re2,
                Scrap=scr,
                Finished=fin,
                IdLamination = lamination.IdLamination
            };
            using (var contexto = new DataContextLamination())
            {
                contexto.Actualizar(mod);
            }
            DisplayAlert("Update", "your Material Lamination has been update", "ok");
            Navigation.PushAsync(new ListadoLamination());
        }

        private void Btnver_Clicked(object sender, EventArgs e)
        {
            ((NavigationPage)this.Parent).PushAsync(new ListadoLamination());
        }
    }
}