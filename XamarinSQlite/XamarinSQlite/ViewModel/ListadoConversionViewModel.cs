using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XamarinSQlite.Models;

namespace XamarinSQlite.ViewModel
{
    public class ListadoConversionViewModel : ConversionModel
    {
        private ObservableCollection<ConversionModel> ListadoConversion;
        public ListadoConversionViewModel()
        {

        }
        public ObservableCollection<ConversionModel> ListadoConversion1
        {
            get
            {
                if (ListadoConversion == null)
                {
                    LlenarConversion();
                }

                return ListadoConversion;
            }

            set
            {
                ListadoConversion = value;
            }
        }

        public void LlenarConversion()
        {
            using (var contexto = new DataContextConversion())
            {
                ObservableCollection<ConversionModel> modelo = new 
                    ObservableCollection<ConversionModel>(contexto.Consultar());
                ListadoConversion = modelo;
            }
        }
    }
}
