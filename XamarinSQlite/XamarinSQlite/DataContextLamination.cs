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
    public class DataContextLamination : IDisposable
    {
        SQLiteConnection cnn;
        public DataContextLamination()
        {
            var configuracion = DependencyService.Get<IConfiguration>();
            cnn = new SQLiteConnection(configuracion.plataforma, Path.Combine(configuracion.directorio, "lamination.db3"));
            cnn.CreateTable<LaminationModel>();
        }

        public void Dispose()
        {
            cnn.Dispose();
        }

        public void Insertar(LaminationModel modelo)
        {
            cnn.Insert(modelo);
        }
        public void Actualizar(LaminationModel modelo)
        {
            cnn.Update(modelo);
        }
        public void Eliminar(LaminationModel modelo)
        {
            cnn.Delete(modelo);
        }
        public LaminationModel Consultar(int id)
        {
            return cnn.Table<LaminationModel>().FirstOrDefault(p => p.IdLamination == id);
        }
        public List<LaminationModel> Consultar()
        {
            return cnn.Table<LaminationModel>().ToList();
        }
    }
}
