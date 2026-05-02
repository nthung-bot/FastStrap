using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FastStrap.UI.ViewModels.Settings;

namespace FastStrap.UI.Elements.Settings.Pages
{
    /// <summary>
    /// Interaction logic for FastStrapPage.xaml
    /// </summary>
    public partial class FastStrapPage
    {
        public FastStrapPage()
        {
            DataContext = new FastStrapViewModel();
            InitializeComponent();
        }
    }
}
