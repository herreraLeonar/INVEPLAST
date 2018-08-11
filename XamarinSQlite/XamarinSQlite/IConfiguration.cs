using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite.Net.Interop;

namespace XamarinSQlite
{
    public interface IConfiguration
    {
        string directorio { get; }
        ISQLitePlatform plataforma { get; }


    }
}
