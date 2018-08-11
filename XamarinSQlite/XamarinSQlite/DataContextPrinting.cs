using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite.Net;
using Xamarin.Forms;

using XamarinSQlite.Models;
using System.IO;

namespace XamarinSQlite
{
    public class DataContextPrinting : IDisposable
    {
        SQLiteConnection cnn;
        public DataContextPrinting()
        {
            var configuracion = DependencyService.Get<IConfiguration>();
            cnn = new SQLiteConnection(configuracion.plataforma, Path.Combine(configuracion.directorio, "printing.db3"));
            cnn.CreateTable<PrintingModel>();
        }

        public void Dispose()
        {
            cnn.Dispose();
        }

        public void Insertar(PrintingModel modelo)
        {
            cnn.Insert(modelo);
        }
        public void Actualizar(PrintingModel modelo)
        {
            cnn.Update(modelo);
        }
        public void Eliminar(PrintingModel modelo)
        {
            cnn.Delete(modelo);
        }
        public PrintingModel Consultar(int id)
        {
            return cnn.Table<PrintingModel>().FirstOrDefault(p => p.IdPrinting == id);
        }
        public List<PrintingModel> Consultar()
        {
            return cnn.Table<PrintingModel>().ToList();
        }
    }
}
