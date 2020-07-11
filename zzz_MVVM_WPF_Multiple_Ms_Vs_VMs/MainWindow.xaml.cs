using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

using zzz_MVVM_WPF_Multiple_Ms_Vs_VMs.ViewModels;

namespace zzz_MVVM_WPF_Multiple_Ms_Vs_VMs
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    /// 
    public partial class MainWindow : Window
    {
        GameVM myGame;

        public MainWindow()
        {
            InitializeComponent();

            myGame = new GameVM();
            this.DataContext = myGame;
        }
    }
}
