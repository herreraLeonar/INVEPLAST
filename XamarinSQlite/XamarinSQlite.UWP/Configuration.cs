using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite.Net.Interop;
using Windows.Storage;
using Xamarin.Forms;
using XamarinSQlite.UWP;
[assembly: Dependency(typeof(XamarinSQlite.UWP.Configuration))]
namespace XamarinSQlite.UWP
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
                    Directorio = ApplicationData.Current.LocalFolder.Path;
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
                    Plataforma = new SQLite.Net.Platform.WinRT.SQLitePlatformWinRT();
                }
                return Plataforma;
            }
        }
    }
}
