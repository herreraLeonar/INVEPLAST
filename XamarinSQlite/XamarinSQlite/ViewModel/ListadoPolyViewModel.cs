using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XamarinSQlite.Models;

namespace XamarinSQlite.ViewModel
{
    public class ListadoPolyViewModel : PolyModel
    {
        private ObservableCollection<PolyModel> ListadoPoly;

        public ListadoPolyViewModel()
        {

        }
        public ObservableCollection<PolyModel> ListadoPoly1
        {
            get
            {
                if (ListadoPoly == null)
                {
                    LlenarPoly();
                }

                return ListadoPoly;
            }

            set
            {
                ListadoPoly = value;
            }
        }

        public void LlenarPoly()
        {
            using (var contexto = new DataContextPoly())
            {
                ObservableCollection<PolyModel> modelo = new ObservableCollection<PolyModel>(contexto.Consultar());
                ListadoPoly = modelo;
            }
        }
    }
}
