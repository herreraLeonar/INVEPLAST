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
    public class SlittingViewModel : SlittingModel
    {
        public ICommand Guardar { get; private set; }
        public ICommand Modificar { get; private set; }
        public ICommand Eliminar { get; private set; }
        public ICommand Nuevo { get; private set; }

        public SlittingViewModel()
        {
            Nuevo = new Command(() => {

                Material = "";
                Size = string.Empty;
                NoRolls = string.Empty;
                WgtRoll = string.Empty;
                TotalWeight = string.Empty;
                Slitting = string.Empty;
                Scrap = string.Empty;
                Finished1 = string.Empty;
                Finished2 = string.Empty;
                Finished3 = string.Empty;
                Print = string.Empty;
            }
          );
            Guardar = new Command(() => {
                SlittingModel modelo = new SlittingModel()
                {
                    Material = Material,
                    Size = Size,
                    NoRolls = NoRolls,
                    WgtRoll = WgtRoll,
                    TotalWeight = TotalWeight,
                    Slitting = Slitting,
                    Scrap = Scrap,
                    Finished1 = Finished1,
                    Finished2 = Finished2,
                    Finished3 = Finished3,
                    Print = Print
                };

                using (var contexto = new DataContextSlitting())
                {
                    contexto.Insertar(modelo);
                }

            }
             );
            Modificar = new Command(() => {
                SlittingModel modelo = new SlittingModel()
                {
                    Material = Material,
                    Size = Size,
                    NoRolls = NoRolls,
                    WgtRoll = WgtRoll,
                    TotalWeight = TotalWeight,
                    Slitting = Slitting,
                    Scrap = Scrap,
                    Finished1 = Finished1,
                    Finished2 = Finished2,
                    Finished3 = Finished3,
                    Print = Print,
                    IdSlitting = IdSlitting
                };

                using (var contexto = new DataContextSlitting())
                {
                    contexto.Actualizar(modelo);
                }
            }
            );

            Eliminar = new Command(() => {
                SlittingModel modelo = new SlittingModel()
                {
                    Material = Material,
                    Size = Size,
                    NoRolls = NoRolls,
                    WgtRoll = WgtRoll,
                    TotalWeight = TotalWeight,
                    Slitting = Slitting,
                    Scrap = Scrap,
                    Finished1 = Finished1,
                    Finished2 = Finished2,
                    Finished3 = Finished3,
                    Print = Print,
                    IdSlitting = IdSlitting
                };

                using (var contexto = new DataContextSlitting())
                {
                    contexto.Eliminar(modelo);
                }
            });


        }
    }
}
