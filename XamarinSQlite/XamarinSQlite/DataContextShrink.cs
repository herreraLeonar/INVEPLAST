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
    public class DataContextShrink : IDisposable
    {
        SQLiteConnection cnn;
        public DataContextShrink()
        {
            var configuracion = DependencyService.Get<IConfiguration>();
            cnn = new SQLiteConnection(configuracion.plataforma, Path.Combine(configuracion.directorio, "shrink.db3"));
            cnn.CreateTable<ShrinkModel>();
        }

        public void Dispose()
        {
            cnn.Dispose();
        }

        public void Insertar(ShrinkModel modelo)
        {
            cnn.Insert(modelo);
        }
        public void Actualizar(ShrinkModel modelo)
        {
            cnn.Update(modelo);
        }
        public void Eliminar(ShrinkModel modelo)
        {
            cnn.Delete(modelo);
        }
        public ShrinkModel Consultar(int id)
        {
            return cnn.Table<ShrinkModel>().FirstOrDefault(p => p.IdShrink == id);
        }
        public List<ShrinkModel> Consultar()
        {
            return cnn.Table<ShrinkModel>().ToList();
        }
    }
}