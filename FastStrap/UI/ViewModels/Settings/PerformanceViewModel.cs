namespace FastStrap.UI.ViewModels.Settings
{
    public class PerformanceViewModel : NotifyPropertyChangedViewModel
    {
        public bool RobloxHighPriority
        {
            get => App.Settings.Prop.RobloxHighPriority;
            set => App.Settings.Prop.RobloxHighPriority = value;
        }

        public bool CloseBackgroundApps
        {
            get => App.Settings.Prop.CloseBackgroundApps;
            set => App.Settings.Prop.CloseBackgroundApps = value;
        }

        public bool UseCloudflareDns
        {
            get => App.Settings.Prop.UseCloudflareDns;
            set => App.Settings.Prop.UseCloudflareDns = value;
        }
    }
}
