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
    public class DataContextConversion : IDisposable
    {
        SQLiteConnection cnn;
        public DataContextConversion()
        {
            var configuracion = DependencyService.Get<IConfiguration>();
            cnn = new SQLiteConnection(configuracion.plataforma, Path.Combine(configuracion.directorio, "conversion.db3"));
            cnn.CreateTable<ConversionModel>();
        }

        public void Dispose()
        {
            cnn.Dispose();
        }

        public void Insertar(ConversionModel modelo)
        {
            cnn.Insert(modelo);
        }
        public void Actualizar(ConversionModel modelo)
        {
            cnn.Update(modelo);
        }
        public void Eliminar(ConversionModel modelo)
        {
            cnn.Delete(modelo);
        }
        public ConversionModel Consultar(int id)
        {
            return cnn.Table<ConversionModel>().FirstOrDefault(p => p.IdConversion == id);
        }
        public List<ConversionModel> Consultar()
        {
            return cnn.Table<ConversionModel>().ToList();
        }
    }
}