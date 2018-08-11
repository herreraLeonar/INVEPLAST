using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XamarinSQlite.Models;

namespace XamarinSQlite.ViewModel
{
    public class ListadoSlittingViewModel : SlittingModel
    {
        private ObservableCollection<SlittingModel> ListadoSlitting;

        public ListadoSlittingViewModel()
        {

        }
        public ObservableCollection<SlittingModel> ListadoSlitting1
        {
            get
            {
                if (ListadoSlitting == null)
                {
                    LlenarSlitting();
                }

                return ListadoSlitting;
            }

            set
            {
                ListadoSlitting = value;
            }
        }

        public void LlenarSlitting()
        {
            using (var contexto = new DataContextSlitting())
            {
                ObservableCollection<SlittingModel> modelo = new ObservableCollection<SlittingModel>(contexto.Consultar());
                ListadoSlitting = modelo;
            }
        }
    }
}
