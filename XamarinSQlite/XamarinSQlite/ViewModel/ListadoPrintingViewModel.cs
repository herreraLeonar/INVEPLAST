using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XamarinSQlite.Models;

namespace XamarinSQlite.ViewModel
{
    public class ListadoPrintingViewModel : PrintingModel
    {
        private ObservableCollection<PrintingModel> ListadoPrinting;

        public ListadoPrintingViewModel()
        {

        }


        public ObservableCollection<PrintingModel> ListadoPrinting1
        {
            get
            {
                if (ListadoPrinting == null)
                {
                    LlenarPersonas();
                }

                return ListadoPrinting;
            }

            set
            {
                ListadoPrinting = value;
            }
        }

        public void LlenarPersonas()
        {
            using (var contexto = new DataContextPrinting())
            {
                ObservableCollection<PrintingModel> modelo = new ObservableCollection<PrintingModel>(contexto.Consultar());
                ListadoPrinting = modelo;
            }



        }
    }
}
