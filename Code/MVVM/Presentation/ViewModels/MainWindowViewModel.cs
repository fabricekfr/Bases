using GalaSoft.MvvmLight;

namespace Presentation.ViewModels
{

    public class MainWindowViewModel : ViewModelBase
    {
        private string _welcomeTitle = "MVVM";
        public string WelcomeTitle
        {
            get
            {
                return _welcomeTitle;
            }
            set
            {
                Set(ref _welcomeTitle, value, true);
            }
        }
    }
}