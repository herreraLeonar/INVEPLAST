using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite.Net.Attributes;
using System.ComponentModel;

namespace XamarinSQlite.Models
{
    public class PrintingModel : INotifyPropertyChanged
    {
        private int idPrinting;
        private string material;
        private string gauge;
        private string size;
        private string noRolls;
        private string wgtRoll;
        private string totalWeight;
        private string printing;
        private string slitting;
        private string conversion;
        private string scrap;
        private string finished;

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propiedad)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propiedad));
            }
        }

        [PrimaryKey, AutoIncrement]
        public int IdPrinting
        {
            get
            {
                return idPrinting;
            }

            set
            {
                if (idPrinting != value)
                {
                    idPrinting = value;
                    OnPropertyChanged("idPrinting");
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

        public string Printing
        {
            get
            {
                return printing;
            }

            set
            {
                if (printing != value)
                {
                    printing = value;
                    OnPropertyChanged("printing");
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
        public string Finished
        {
            get
            {
                return finished;
            }

            set
            {
                if (finished != value)
                {
                    finished = value;
                    OnPropertyChanged("finished");
                }
            }
        }
    }
}
