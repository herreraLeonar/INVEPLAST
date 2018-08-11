using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using XamarinSQlite.Models;

namespace XamarinSQlite.ViewModel
{
    public class LaminationViewModel : LaminationModel
    {
        public ICommand Guardar { get; private set; }
        public ICommand Modificar { get; private set; }
        public ICommand Eliminar { get; private set; }
        public ICommand Nuevo { get; private set; }

        public LaminationViewModel()
        {
            Nuevo = new Command(() => {

                Material1 = "";
                Material2 = "";
                Gauge1 = string.Empty;
                Gauge2 = string.Empty;
                Size1 = string.Empty;
                Size2 = string.Empty;
                Returned1 = string.Empty;
                Returned2 = string.Empty;
                Scrap = string.Empty;
                FinishedLamination = string.Empty;
                Finished = string.Empty;

            }
          );
            Guardar = new Command(() => {
                LaminationModel modelo = new LaminationModel()
                {
                    Material1 = Material1,
                    Material2 = Material2,
                    Size1 = Size1,
                    Size2 = Size2,
                    Returned1 = Returned1,
                    Returned2 = Returned2,
                    Scrap = Scrap,
                    FinishedLamination = FinishedLamination,
                    Finished = Finished
                };

                using (var contexto = new DataContextLamination())
                {
                    contexto.Insertar(modelo);
                }

            }
             );
            Modificar = new Command(() => {
                LaminationModel modelo = new LaminationModel()
                {
                    Material1 = Material1,
                    Material2 = Material2,
                    Size1 = Size1,
                    Size2 = Size2,
                    Returned1 = Returned1,
                    Returned2 = Returned2,
                    Scrap = Scrap,
                    FinishedLamination = FinishedLamination,
                    Finished = Finished,
                    IdLamination = IdLamination
                };

                using (var contexto = new DataContextLamination())
                {
                    contexto.Actualizar(modelo);
                }
            }
            );

            Eliminar = new Command(() => {
                LaminationModel modelo = new LaminationModel()
                {
                    Material1 = Material1,
                    Material2 = Material2,
                    Size1 = Size1,
                    Size2 = Size2,
                    Returned1 = Returned1,
                    Returned2 = Returned2,
                    Scrap = Scrap,
                    FinishedLamination = FinishedLamination,
                    Finished = Finished,
                    IdLamination = IdLamination
                };

                using (var contexto = new DataContextLamination())
                {
                    contexto.Eliminar(modelo);
                }
            });


        }
    }
}
