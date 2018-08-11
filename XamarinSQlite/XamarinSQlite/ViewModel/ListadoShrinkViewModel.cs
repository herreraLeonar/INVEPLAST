using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XamarinSQlite.Models;

namespace XamarinSQlite.ViewModel
{
    public class ListadoShrinkViewModel : ShrinkModel
    {
        private ObservableCollection<ShrinkModel> ListadoShrink;

        public ListadoShrinkViewModel()
        {

        }
        public ObservableCollection<ShrinkModel> ListadoShrink1
        {
            get
            {
                if (ListadoShrink == null)
                {
                    LlenarShrink();
                }

                return ListadoShrink;
            }

            set
            {
                ListadoShrink = value;
            }
        }

        public void LlenarShrink()
        {
            using (var contexto = new DataContextShrink())
            {
                ObservableCollection<ShrinkModel> modelo = new ObservableCollection<ShrinkModel>(contexto.Consultar());
                ListadoShrink = modelo;
            }
        }
    }
}
