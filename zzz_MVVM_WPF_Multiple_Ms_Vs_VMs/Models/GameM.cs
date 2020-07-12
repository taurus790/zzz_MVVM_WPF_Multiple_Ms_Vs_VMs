using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using zzz_MVVM_WPF_Multiple_Ms_Vs_VMs.Models.BaseMs;

namespace zzz_MVVM_WPF_Multiple_Ms_Vs_VMs.Models
{
    class GameM : BaseModel
    {
        #region Private attributes and public properties.
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
        #endregion

        #region Constructor. 
        public GameM()
        {
            Name = "Game 1";
            MyWorld = new WorldM();
        }
        #endregion

        #region Methods. 
        public bool ChangeName()
        {
            Name = Name + "1";
            return true;
        }
        #endregion
    }
}
