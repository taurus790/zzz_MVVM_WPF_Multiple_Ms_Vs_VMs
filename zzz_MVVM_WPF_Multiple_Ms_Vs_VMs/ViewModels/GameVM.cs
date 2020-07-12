using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using zzz_MVVM_WPF_Multiple_Ms_Vs_VMs.ViewModels;
using zzz_MVVM_WPF_Multiple_Ms_Vs_VMs.ViewModels.BaseVMs;
using zzz_MVVM_WPF_Multiple_Ms_Vs_VMs.Models;
using zzz_MVVM_WPF_Multiple_Ms_Vs_VMs.Commands;

namespace zzz_MVVM_WPF_Multiple_Ms_Vs_VMs.ViewModels
{
    class GameVM : BaseViewModel
    {
        #region Private attributes and public properties.
        private GameM _myGame;
        private string _name;
        private WorldM _myWorld;

        public string Name
        {
            get { return _name; }
            set { _name = value; OnPropertyChanged(nameof(Name)); }
        }
        public WorldM MyWorld
        {
            get { return _myWorld; }
            set { _myWorld = value; OnPropertyChanged(nameof(MyWorld)); }
        }
        public GameM MyGame
        {
            get { return _myGame; }
            set { _myGame = value; OnPropertyChanged(nameof(MyGame)); }
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
        public GameVM()
        {
            MyGame = new GameM();

            LoadData();

            _changeNameCommand = new RelayCommand(ChangeName);
        }
        #endregion

        #region Methods. 
        public void LoadData()
        {
            Name = MyGame.Name;
            MyWorld = MyGame.MyWorld;
        }

        public void ChangeName()
        {
            MyGame.ChangeName();
            LoadData();
        }
        #endregion
    }
}
