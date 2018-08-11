using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite.Net.Attributes;
using System.ComponentModel;

namespace XamarinSQlite.Models
{
    public class SlittingModel : INotifyPropertyChanged
    {
        private int idSlitting;
        private string material;
        private string size;
        private string noRolls;
        private string wgtRoll;
        private string totalWeight;
        private string slitting;
        private string scrap;
        private string finished1;
        private string finished2;
        private string finished3;
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
        public int IdSlitting
        {
            get
            {
                return idSlitting;
            }

            set
            {
                if (idSlitting != value)
                {
                    idSlitting = value;
                    OnPropertyChanged("idSlitting");
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
        public string Slitting
        {
            get
            {
                return slitting;
            }

            set
            {
                if (slitting != value)
                {
                    slitting = value;
                    OnPropertyChanged("slitting");
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
        public string Finished1
        {
            get
            {
                return finished1;
            }

            set
            {
                if (finished1 != value)
                {
                    finished1 = value;
                    OnPropertyChanged("finished1");
                }
            }
        }
        public string Finished2
        {
            get
            {
                return finished2;
            }

            set
            {
                if (finished2 != value)
                {
                    finished2 = value;
                    OnPropertyChanged("finished2");
                }
            }
        }
        public string Finished3
        {
            get
            {
                return finished3;
            }

            set
            {
                if (finished3 != value)
                {
                    finished3 = value;
                    OnPropertyChanged("finished3");
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
                if (print != value)
                {
                    print = value;
                    OnPropertyChanged("print");
                }
            }
        }
    }
}
