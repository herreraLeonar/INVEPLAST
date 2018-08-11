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
    public class DataContextSlitting : IDisposable
    {
        SQLiteConnection cnn;
        public DataContextSlitting()
        {
            var configuracion = DependencyService.Get<IConfiguration>();
            cnn = new SQLiteConnection(configuracion.plataforma, Path.Combine(configuracion.directorio, "slitting.db3"));
            cnn.CreateTable<SlittingModel>();
        }

        public void Dispose()
        {
            cnn.Dispose();
        }

        public void Insertar(SlittingModel modelo)
        {
            cnn.Insert(modelo);
        }
        public void Actualizar(SlittingModel modelo)
        {
            cnn.Update(modelo);
        }
        public void Eliminar(SlittingModel modelo)
        {
            cnn.Delete(modelo);
        }
        public SlittingModel Consultar(int id)
        {
            return cnn.Table<SlittingModel>().FirstOrDefault(p => p.IdSlitting == id);
        }
        public List<SlittingModel> Consultar()
        {
            return cnn.Table<SlittingModel>().ToList();
        }
    }
}