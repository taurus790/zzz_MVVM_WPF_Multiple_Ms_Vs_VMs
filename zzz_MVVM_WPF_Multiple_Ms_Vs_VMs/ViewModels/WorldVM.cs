using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using zzz_MVVM_WPF_Multiple_Ms_Vs_VMs.ViewModels;
using zzz_MVVM_WPF_Multiple_Ms_Vs_VMs.ViewModels.BaseVMs;
using zzz_MVVM_WPF_Multiple_Ms_Vs_VMs.Models;
using zzz_MVVM_WPF_Multiple_Ms_Vs_VMs.Commands;
using System.Collections.ObjectModel;

namespace zzz_MVVM_WPF_Multiple_Ms_Vs_VMs.ViewModels
{
    class WorldVM : BaseViewModel
    {
        #region Private attributes and public properties.
        private WorldM _myWorld;
        private string _name;
        private StationM _selectedStation;
        private ObservableCollection<StationM> _stations;

        public WorldM MyWorld
        {
            get { return _myWorld; }
            set { _myWorld = value; OnPropertyChanged(nameof(MyWorld)); }
        }
        public string  Name
        {
            get { return _name; }
            set { _name = value; OnPropertyChanged(nameof(Name)); }
        }
        public StationM SelectedStation
        {
            get { return _selectedStation; }
            set { _selectedStation = value; OnPropertyChanged(nameof(SelectedStation)); }
        }
        public ObservableCollection<StationM> Stations
        {
            get { return _stations; }
            set { _stations = value; OnPropertyChanged(nameof(Stations)); }
        }
        #endregion

        #region Relay commands. 
        private RelayCommand _changeNameCommand;

        public RelayCommand ChangeNameCommand
        {
            get { return _changeNameCommand; }
        }
        #endregion

        #region Constructor. 
        /* public WorldVM()
        {
            MyWorld = new WorldM();

            LoadData();

            _changeNameCommand = new RelayCommand(ChangeName);
        }
        */
        public WorldVM(WorldM _world)
        {
            MyWorld = _world;

            LoadData();

            _changeNameCommand = new RelayCommand(ChangeName);
        }
        #endregion

        #region Methods. 
        public void LoadData()
        {
            Name = MyWorld.Name;
            SelectedStation = MyWorld.SelectedStation;
            Stations = new ObservableCollection<StationM>(MyWorld.Stations);
        }

        public void ChangeName()
        {
            MyWorld.ChangeName();
            LoadData();
        }
        #endregion
    }
}
