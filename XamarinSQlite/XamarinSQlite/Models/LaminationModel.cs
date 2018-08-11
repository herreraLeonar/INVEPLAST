using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite.Net.Attributes;
using System.ComponentModel;

namespace XamarinSQlite.Models
{
    public class LaminationModel : INotifyPropertyChanged
    {
        private int idLamination;
        private string material1;
        private string material2;
        private string gauge1;
        private string gauge2;
        private string size1;
        private string size2;
        private string returned1;
        private string returned2;
        private string scrap;
        private string finishedLamination;
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
        public int IdLamination
        {
            get
            {
                return idLamination;
            }

            set
            {
                if (idLamination != value)
                {
                    idLamination = value;
                    OnPropertyChanged("idLamination");
                }

            }
        }

        public string Material1
        {
            get
            {
                return material1;
            }

            set
            {
                if (material1 != value)
                {
                    material1 = value;
                    OnPropertyChanged("material1");
                }
            }
        }

        public string Material2
        {
            get
            {
                return material2;
            }

            set
            {
                if (material2 != value)
                {
                    material2 = value;
                    OnPropertyChanged("material2");
                }
            }
        }

        public string Gauge1
        {
            get
            {
                return gauge1;
            }

            set
            {
                if (gauge1 != value)
                {
                    gauge1 = value;
                    OnPropertyChanged("gauge1");
                }
            }
        }

        public string Gauge2
        {
            get
            {
                return gauge2;
            }

            set
            {
                if (gauge2 != value)
                {
                    gauge2 = value;
                    OnPropertyChanged("gauge2");
                }
            }
        }

        public string Size1
        {
            get
            {
                return size1;
            }

            set
            {
                if (size1 != value)
                {
                    size1 = value;
                    OnPropertyChanged("size1");
                }
            }
        }

        public string Size2
        {
            get
            {
                return size2;
            }

            set
            {
                if (size2 != value)
                {
                    size2 = value;
                    OnPropertyChanged("size2");
                }
            }
        }

        public string Returned1
        {
            get
            {
                return returned1;
            }

            set
            {
                if (returned1 != value)
                {
                    returned1 = value;
                    OnPropertyChanged("returned1");
                }
            }
        }

        public string Returned2
        {
            get
            {
                return returned2;
            }

            set
            {
                if (returned2 != value)
                {
                    returned2 = value;
                    OnPropertyChanged("returned2");
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
        public string FinishedLamination
        {
            get
            {
                return finishedLamination;
            }

            set
            {
                if (finishedLamination != value)
                {
                    finishedLamination = value;
                    OnPropertyChanged("finishedLamination");
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
