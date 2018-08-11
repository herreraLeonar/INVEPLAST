using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite.Net.Attributes;
using System.ComponentModel;

namespace XamarinSQlite.Models
{
    public class PolyModel : INotifyPropertyChanged
    {
        private int idPoly;
        private string material;
        private string gauge;
        private string size;
        private string noRolls;
        private string wgtRoll;
        private string totalWeight;
        private string conversionPoly;
        private string scrap;
        private string finishedPrinting;
        private string print;

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propiedad)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propiedad));
            }
        }

        [PrimaryKey, AutoIncrement]
        public int IdPoly
        {
            get
            {
                return idPoly;
            }

            set
            {
                if (idPoly != value)
                {
                    idPoly = value;
                    OnPropertyChanged("idPoly");
                }

            }
        }

        public string Material
        {
            get
            {
                return material;
            }

            set
            {
                if (material != value)
                {
                    material = value;
                    OnPropertyChanged("material");
                }
            }
        }

        public string Gauge
        {
            get
            {
                return gauge;
            }

            set
            {
                if (gauge != value)
                {
                    gauge = value;
                    OnPropertyChanged("gauge");
                }
            }
        }

        public string Size
        {
            get
            {
                return size;
            }

            set
            {
                if (size != value)
                {
                    size = value;
                    OnPropertyChanged("size");
                }
            }
        }

        public string NoRolls
        {
            get
            {
                return noRolls;
            }

            set
            {
                if (noRolls != value)
                {
                    noRolls = value;
                    OnPropertyChanged("noRolls");
                }
            }
        }

        public string WgtRoll
        {
            get
            {
                return wgtRoll;
            }

            set
            {
                if (wgtRoll != value)
                {
                    wgtRoll = value;
                    OnPropertyChanged("wgtRoll");
                }
            }
        }

        public string TotalWeight
        {
            get
            {
                return totalWeight;
            }

            set
            {
                if (totalWeight != value)
                {
                    totalWeight = value;
                    OnPropertyChanged("totalWeight");
                }
            }
        }
        public string ConversionPoly
        {
            get
            {
                return conversionPoly;
            }

            set
            {
                if (conversionPoly != value)
                {
                    conversionPoly = value;
                    OnPropertyChanged("conversionPoly");
                }
            }
        }
        public string Scrap
        {
            get
            {
                return scrap;
            }

            set
            {
                if (scrap != value)
                {
                    scrap = value;
                    OnPropertyChanged("scrap");
                }
            }
        }
        public string FinishedPrinting
        {
            get
            {
                return finishedPrinting;
            }

            set
            {
                if (finishedPrinting != value)
                {
                    finishedPrinting = value;
                    OnPropertyChanged("finishedPrinting");
                }
            }
        }
        public string Print
        {
            get
            {
                return print;
            }
            set
            {
                if(print!=value)
                {
                    print = value;
                    OnPropertyChanged("print");
                }
            }
        }
    }
}
