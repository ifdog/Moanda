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
using System.Windows.Shapes;
using Moanda.ViewModel;

namespace Moanda.View
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class MainView : Window
    {
        public MainViewModel ViewModel { get; private set; }
        public MainView()
        {
            ViewModel = new MainViewModel();
            InitializeComponent();
            DataContext = ViewModel;
        }
    }
}
