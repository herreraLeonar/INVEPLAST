using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XamarinSQlite.Models;

namespace XamarinSQlite.ViewModel
{
    public class ListadoLaminationViewModel : LaminationModel
    {
        private ObservableCollection<LaminationModel> ListadoLamination;

        public ListadoLaminationViewModel()
        {

        }
        public ObservableCollection<LaminationModel> ListadoLamination1
        {
            get
            {
                if (ListadoLamination == null)
                {
                    LlenarLamination();
                }

                return ListadoLamination;
            }

            set
            {
                ListadoLamination = value;
            }
        }

        public void LlenarLamination()
        {
            using (var contexto = new DataContextLamination())
            {
                ObservableCollection<LaminationModel> modelo = new ObservableCollection<LaminationModel>(contexto.Consultar());
                ListadoLamination = modelo;
            }
        }
    }
}

