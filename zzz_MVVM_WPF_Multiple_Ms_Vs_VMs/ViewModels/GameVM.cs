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
    class GameVM :BaseViewModel
    {
        private GameM myGame;

        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; OnPropertyChanged(nameof(Name)); }
        }

        private WorldM _myWorld;
        public WorldM MyWorld
        {
            get { return _myWorld; }
            set { _myWorld = value; OnPropertyChanged(nameof(MyWorld)); }
        }

        private RelayCommand _changeNameCommand;

        public RelayCommand ChangeNameCommand
        {
            get { return _changeNameCommand; }
        }

        public GameVM()
        {
            myGame = new GameM();

            LoadData();

            _changeNameCommand = new RelayCommand(ChangeName);
        }

        public void LoadData()
        {
            Name = myGame.Name;
            MyWorld = myGame.MyWorld;
        }

        public void ChangeName()
        {
            myGame.ChangeName();
            LoadData();
        }
    }
}
