using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;

namespace MVVMSample.ViewModels
{
    public class MainPageViewModel : INotifyPropertyChanged
    {
        
        public event PropertyChangedEventHandler PropertyChanged;

        public MainPageViewModel()
        { }
        public MainPageViewModel(WriteableBitmap original)
        {
            this.Original = original;
        }


        public WriteableBitmap _original;
        public WriteableBitmap Original
        {
            get { return this._original; }
            set {
                this._original = value;
                RaisePropertyChanged();
                }
        }

        private void RaisePropertyChanged([CallerMemberName]string propertyName="")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
