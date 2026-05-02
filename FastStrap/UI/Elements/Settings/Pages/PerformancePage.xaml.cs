using FastStrap.UI.ViewModels.Settings;

namespace FastStrap.UI.Elements.Settings.Pages
{
    public partial class PerformancePage
    {
        public PerformancePage()
        {
            DataContext = new PerformanceViewModel();
            InitializeComponent();
        }
    }
}
