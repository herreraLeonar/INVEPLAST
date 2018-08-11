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
    public class DataContextPoly : IDisposable
    {
        SQLiteConnection cnn;
        public DataContextPoly()
        {
            var configuracion = DependencyService.Get<IConfiguration>();
            cnn = new SQLiteConnection(configuracion.plataforma, Path.Combine(configuracion.directorio, "poly.db3"));
            cnn.CreateTable<PolyModel>();
        }

        public void Dispose()
        {
            cnn.Dispose();
        }

        public void Insertar(PolyModel modelo)
        {
            cnn.Insert(modelo);
        }
        public void Actualizar(PolyModel modelo)
        {
            cnn.Update(modelo);
        }
        public void Eliminar(PolyModel modelo)
        {
            cnn.Delete(modelo);
        }
        public PolyModel Consultar(int id)
        {
            return cnn.Table<PolyModel>().FirstOrDefault(p => p.IdPoly == id);
        }
        public List<PolyModel> Consultar()
        {
            return cnn.Table<PolyModel>().ToList();
        }
    }
}
