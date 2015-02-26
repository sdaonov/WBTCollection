using GalaSoft.MvvmLight;

namespace NovLocator.ViewModels
{
    public class MainViewModel : ViewModelBase
    {

        private string _text = "Hello";
        public string MainText
        {
            get { return _text; }
            set { if (Set(() => MainText, ref _text, value)) { RaisePropertyChanged(() => MainText); } }
        }

    }
}
