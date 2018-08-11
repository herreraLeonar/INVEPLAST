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
    public class PolyViewModel : PolyModel
    {
        public ICommand Guardar { get; private set; }
        public ICommand Modificar { get; private set; }
        public ICommand Eliminar { get; private set; }
        public ICommand Nuevo { get; private set; }

        public PolyViewModel()
        {
            Nuevo = new Command(() => {

                Material = "";
                Gauge = string.Empty;
                Size = string.Empty;
                NoRolls = string.Empty;
                WgtRoll = string.Empty;
                TotalWeight = string.Empty;
                ConversionPoly = string.Empty;
                Scrap = string.Empty;
                FinishedPrinting = string.Empty;
                Print = string.Empty;

            }
          );
            Guardar = new Command(() => {
                PolyModel modelo = new PolyModel()
                {
                    Material = Material,
                    Gauge = Gauge,
                    Size = Size,
                    NoRolls = NoRolls,
                    WgtRoll = WgtRoll,
                    TotalWeight = TotalWeight,
                    ConversionPoly = ConversionPoly,
                    Scrap = Scrap,
                    FinishedPrinting = FinishedPrinting,
                    Print = Print
                };

                using (var contexto = new DataContextPoly())
                {
                    contexto.Insertar(modelo);
                }

            }
             );
            Modificar = new Command(() => {
                PolyModel modelo = new PolyModel()
                {
                    Material = Material,
                    Gauge = Gauge,
                    Size = Size,
                    NoRolls = NoRolls,
                    WgtRoll = WgtRoll,
                    TotalWeight = TotalWeight,
                    ConversionPoly = ConversionPoly,
                    Scrap = Scrap,
                    FinishedPrinting = FinishedPrinting,
                    Print = Print,
                    IdPoly = IdPoly
                };

                using (var contexto = new DataContextPoly())
                {
                    contexto.Actualizar(modelo);
                }
            }
            );

            Eliminar = new Command(() => {
                PolyModel modelo = new PolyModel()
                {
                    Material = Material,
                    Gauge = Gauge,
                    Size = Size,
                    NoRolls = NoRolls,
                    WgtRoll = WgtRoll,
                    TotalWeight = TotalWeight,
                    ConversionPoly = ConversionPoly,
                    Scrap = Scrap,
                    FinishedPrinting = FinishedPrinting,
                    Print = Print,
                    IdPoly = IdPoly
                };

                using (var contexto = new DataContextPoly())
                {
                    contexto.Eliminar(modelo);
                }
            });


        }
    }
}
