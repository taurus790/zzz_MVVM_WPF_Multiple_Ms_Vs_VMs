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
        private StationVM _selectedStation;
        private ObservableCollection<StationVM> _stations;

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
        public StationVM SelectedStation
        {
            get { return _selectedStation; }
            set { _selectedStation = value; OnPropertyChanged(nameof(SelectedStation)); }
        }
        public ObservableCollection<StationVM> Stations
        {
            get { return _stations; }
            set { _stations = value; OnPropertyChanged(nameof(Stations)); }
        }
        #endregion

        #region Relay commands. 
        private RelayCommand _changeNameCommand;
        private RelayCommand _addStationCommand;

        public RelayCommand ChangeNameCommand
        {
            get { return _changeNameCommand; }
        }
        public RelayCommand AddStationCommand
        {
            get { return _addStationCommand; }
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
            _addStationCommand = new RelayCommand(AddStation);
        }
        #endregion

        #region Methods. 
        public void LoadData()
        {
            Name = MyWorld.Name;
            SelectedStation = new StationVM(MyWorld.SelectedStation);
            Stations = new ObservableCollection<StationVM>();

            for (int i = 0; i < MyWorld.Stations.Count; i++)
            {
                Stations.Add(new StationVM(MyWorld.Stations[i]));
            }
        }

        public void ChangeName()
        {
            MyWorld.ChangeName();
            LoadData();
        }

        public void AddStation()
        {
            MyWorld.AddStation();
            LoadData();
        }
        #endregion
    }
}
