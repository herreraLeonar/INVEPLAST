﻿using System;
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
    public partial class PrintingEdit : ContentPage
    {

        public ICommand Modificar1 { get; private set; }
        public ICommand Eliminar1 { get; private set; }
        public PrintingModel printing;
        public string mat;
        public string gau;
        public string siz;
        public string nor;
        public string wgt;
        public string tot;
        public string pri;
        public string scr;
        public string fin;
        public PrintingEdit(PrintingModel pri)
        {
            InitializeComponent();
            printing = pri;
            txtmaterial.Items.Add("Coex 65");
            txtmaterial.Items.Add("Coex 70");
            txtmaterial.Items.Add("Coex 94");
            txtmaterial.Items.Add("Coex 120");
            txtmaterial.Items.Add("Coex 160");
            txtmaterial.Items.Add("MPET 12");
            txtmaterial.Items.Add("SPET 12");
            txtmaterial.Items.Add("CPET 12");
            txtmaterial.Items.Add("Nylon 15");
            txtmaterial.Items.Add("BOPP 20");
            txtmaterial.Items.Add("BOPP 25");
            txtmaterial.Items.Add("BOPP 30");
            txtmaterial.Items.Add("BOPP 40");
            txtmaterial.Items.Add("PE 100");
            txtmaterial.Items.Add("PE 125");
            txtmaterial.Items.Add("PE 150");
            txtmaterial.Items.Add("PE 170");
            txtmaterial.Items.Add("PE 180");
            txtmaterial.Items.Add("PE 200");
            txtmaterial.Items.Add("PE 225");
            txtmaterial.Items.Add("PE 250");
            txtmaterial.Items.Add("PE 280");
            txtmaterial.Items.Add("PE 300");
            txtmaterial.Items.Add("PE 325");
            txtmaterial.Items.Add("PE 350");
            txtmaterial.Items.Add("PE 400");
            txtmaterial.Items.Add("PE 425");
            txtmaterial.Items.Add("PE 450");
            txtmaterial.Items.Add("PE 500");
            txtmaterial.Items.Add("PE 525");
            txtmaterial.Items.Add("PE 550");
            BindingContext = pri;
            btnver.Clicked += Btnver_Clicked;
            btnmodificar.Clicked += Btnmodificar_Clicked;
            btneliminar.Clicked += Btneliminar_Clicked;
        }

        private void Btneliminar_Clicked(object sender, EventArgs e)
        {
                using (var contexto = new DataContextPrinting())
                {
                    contexto.Eliminar(printing);
                }

            DisplayAlert("Delete", "your material Printing has been delete", "ok");
            Navigation.PushAsync(new ListadoPrinting());
        }

        private void Btnmodificar_Clicked(object sender, EventArgs e)
        {
            mat = Convert.ToString(txtmaterial.SelectedItem);
            gau = txtgauge.Text;
            siz = txtsize.Text;
            nor = txtnorolls.Text;
            wgt = txtwgtroll.Text;
            tot = txttotalweight.Text;
            pri = txtprinting.Text;
            fin = txtfinished.Text;
            scr = txtscrap.Text;
            PrintingModel mod = new PrintingModel()
            {
                Material = mat,
                Gauge = gau,
                Size = siz,
                NoRolls = nor,
                WgtRoll = wgt,
                TotalWeight = tot,
                Printing = pri,
                Scrap = scr,
                Finished = fin,
                IdPrinting = printing.IdPrinting
            };
            using (var contexto = new DataContextPrinting())
                {
                    contexto.Actualizar(mod);
                }
            DisplayAlert("Update", "your material Printing has been update", "ok");
            Navigation.PushAsync(new ListadoPrinting());
        }

        private void Btnver_Clicked(object sender, EventArgs e)
        {
            ((NavigationPage)this.Parent).PushAsync(new ListadoPrinting());
        }
    }
}