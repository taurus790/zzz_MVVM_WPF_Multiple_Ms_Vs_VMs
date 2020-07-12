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
    class StationVM :BaseViewModel
    {
        #region Private attributes and public properties.
        private StationM _myStation;
        private string _name;

        public StationM MyStation
        {
            get { return _myStation; }
            set { _myStation = value; OnPropertyChanged(nameof(Name)); }
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; OnPropertyChanged(nameof(Name)); }
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
        public StationVM(StationM _station)
        {
            MyStation = _station;

            LoadData();

            _changeNameCommand = new RelayCommand(ChangeName);
        }
        #endregion

        #region Methods. 
        public void LoadData()
        {
            Name = MyStation.Name;
        }

        public void ChangeName()
        {
            MyStation.ChangeName();
            LoadData();
        }
        #endregion
    }
}
