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
    public class ConversionViewModel : ConversionModel
    {
        public ICommand Guardar { get; private set; }
        public ICommand Modificar { get; private set; }
        public ICommand Eliminar { get; private set; }
        public ICommand Nuevo { get; private set; }

        public ConversionViewModel()
        {
            Nuevo = new Command(() => {

                Material = "";
                Gauge = string.Empty;
                Size = string.Empty;
                NoRolls = string.Empty;
                WgtRoll = string.Empty;
                TotalWeight = string.Empty;
                Conversion = string.Empty;
                Scrap = string.Empty;
                Finished = string.Empty;
                Print = string.Empty;
            }
          );
            Guardar = new Command(() => {
                ConversionModel modelo = new ConversionModel()
                {
                    Material = Material,
                    Gauge = Gauge,
                    Size = Size,
                    NoRolls = NoRolls,
                    WgtRoll = WgtRoll,
                    TotalWeight = TotalWeight,
                    Conversion = Conversion,
                    Scrap = Scrap,
                    Finished = Finished,
                    Print = Print
                };

                using (var contexto = new DataContextConversion())
                {
                    contexto.Insertar(modelo);
                }

            }
             );
            Modificar = new Command(() => {
                ConversionModel modelo = new ConversionModel()
                {
                    Material = Material,
                    Gauge = Gauge,
                    Size = Size,
                    NoRolls = NoRolls,
                    WgtRoll = WgtRoll,
                    TotalWeight = TotalWeight,
                    Conversion = Conversion,
                    Scrap = Scrap,
                    Finished = Finished,
                    Print = Print,
                    IdConversion = IdConversion
                };

                using (var contexto = new DataContextConversion())
                {
                    contexto.Actualizar(modelo);
                }
            }
            );

            Eliminar = new Command(() => {
                ConversionModel modelo = new ConversionModel()
                {
                    Material = Material,
                    Gauge = Gauge,
                    Size = Size,
                    NoRolls = NoRolls,
                    WgtRoll = WgtRoll,
                    TotalWeight = TotalWeight,
                    Conversion = Conversion,
                    Scrap = Scrap,
                    Finished = Finished,
                    Print = Print,
                    IdConversion = IdConversion
                };

                using (var contexto = new DataContextConversion())
                {
                    contexto.Eliminar(modelo);
                }
            });


        }
    }
}
