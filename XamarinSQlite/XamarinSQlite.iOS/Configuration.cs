using System;
using System.Collections.Generic;
using System.Text;
using SQLite.Net.Interop;
using Xamarin.Forms;
using System.IO;

namespace XamarinSQlite.iOS
{
    public class Configuration : IConfiguration
    {
        private string Directorio;
        private ISQLitePlatform Plataforma;

        public string directorio
        {
            get
            {
                if (string.IsNullOrEmpty(Directorio))
                {
                    var dir = System.Environment.GetFolderPath(Environment.SpecialFolder.Personal);
                    Directorio = Path.Combine(dir, "..", "Library");
                }
                return Directorio;
            }
        }

        public ISQLitePlatform plataforma
        {
            get
            {
                if (Plataforma == null)
                {
                    Plataforma = new SQLite.Net.Platform.XamarinIOS.SQLitePlatformIOS();
                }
                return Plataforma;
            }
        }
    }
}
