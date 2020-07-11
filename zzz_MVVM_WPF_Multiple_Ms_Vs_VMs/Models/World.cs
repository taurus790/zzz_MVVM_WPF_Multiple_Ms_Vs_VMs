using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using zzz_MVVM_WPF_Multiple_Ms_Vs_VMs.Models.BaseMs;

namespace zzz_MVVM_WPF_Multiple_Ms_Vs_VMs.Models
{
    class World:BaseModel
    {
        private string _name;
        private Station _selectedStation;
        private List<Station> _stations;

        public string Name
        {
            get { return _name; }
            set { _name = value; OnPropertyChanged(nameof(Name)); }
        }
        public Station SelectedStation
        {
            get { return _selectedStation; }
            set { _selectedStation = value; OnPropertyChanged(nameof(SelectedStation)); }
        }
        public List<Station> Stations
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
