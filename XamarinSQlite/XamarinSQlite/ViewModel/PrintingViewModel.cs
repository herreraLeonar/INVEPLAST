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
    public class PrintingViewModel : PrintingModel
    {
        public ICommand Guardar { get; private set; }
        public ICommand Modificar { get; private set; }
        public ICommand Eliminar { get; private set; }
        public ICommand Nuevo { get; private set; }

        public PrintingViewModel()
        {
            Nuevo = new Command(() => {

                Material = "";
                Gauge = string.Empty;
                Size = string.Empty;
                NoRolls = string.Empty;
                WgtRoll = string.Empty;
                TotalWeight = string.Empty;
                Printing = string.Empty;
                Scrap = string.Empty;
                Finished = string.Empty;

            }
          );
            Guardar = new Command(() => {
                PrintingModel modelo = new PrintingModel()
                {
                    Material = Material,
                    Gauge = Gauge,
                    Size = Size,
                    NoRolls = NoRolls,
                    WgtRoll = WgtRoll,
                    TotalWeight = TotalWeight,
                    Printing = Printing,
                    Scrap = Scrap,
                    Finished = Finished
                };

                using (var contexto = new DataContextPrinting())
                {
                    contexto.Insertar(modelo);
                }

            }
             );
            Modificar = new Command(() => {
                PrintingModel modelo = new PrintingModel()
                {
                    Material = Material,
                    Gauge = Gauge,
                    Size = Size,
                    NoRolls = NoRolls,
                    WgtRoll = WgtRoll,
                    TotalWeight = TotalWeight,
                    Printing = Printing,
                    Scrap = Scrap,
                    Finished = Finished,
                    IdPrinting = IdPrinting
                };

                using (var contexto = new DataContextPrinting())
                {
                    contexto.Actualizar(modelo);
                }
            }
            );

            Eliminar = new Command(() => {
                PrintingModel modelo = new PrintingModel()
                {
                    Material = Material,
                    Gauge = Gauge,
                    Size = Size,
                    NoRolls = NoRolls,
                    WgtRoll = WgtRoll,
                    TotalWeight = TotalWeight,
                    Printing = Printing,
                    Scrap = Scrap,
                    Finished = Finished,
                    IdPrinting = IdPrinting
                };

                using (var contexto = new DataContextPrinting())
                {
                    contexto.Eliminar(modelo);
                }
            });


        }
    }
}
