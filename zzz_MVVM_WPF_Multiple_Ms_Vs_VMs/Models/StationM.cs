using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using zzz_MVVM_WPF_Multiple_Ms_Vs_VMs.Models.BaseMs;

namespace zzz_MVVM_WPF_Multiple_Ms_Vs_VMs.Models
{
    class StationM: BaseModel
    {
        #region Private attributes and public properties. 
        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; OnPropertyChanged(nameof(Name)); }
        }
        #endregion

        #region Constructor. 
        public StationM()
        {
            Name = "Station3";
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
