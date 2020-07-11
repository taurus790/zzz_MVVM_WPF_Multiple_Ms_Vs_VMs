using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using zzz_MVVM_WPF_Multiple_Ms_Vs_VMs.Models.BaseMs;

namespace zzz_MVVM_WPF_Multiple_Ms_Vs_VMs.Models
{
    class WorldM:BaseModel
    {
        private string _name;
        private StationM _selectedStation;
        private List<StationM> _stations;

        public string Name
        {
            get { return _name; }
            set { _name = value; OnPropertyChanged(nameof(Name)); }
        }
        public StationM SelectedStation
        {
            get { return _selectedStation; }
            set { _selectedStation = value; OnPropertyChanged(nameof(SelectedStation)); }
        }
        public List<StationM> Stations
        {
            get { return _stations; }
            set { _stations = value; OnPropertyChanged(nameof(Stations)); }
        }

        public bool ChangeName()
        {
            Name = Name + "1";
            return true;
        }
    }
}
