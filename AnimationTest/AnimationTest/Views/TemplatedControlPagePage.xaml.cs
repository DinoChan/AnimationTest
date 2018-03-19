using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace AnimationTest.Views
{
    public sealed partial class TemplatedControlPagePage : Page, INotifyPropertyChanged
    {
        public TemplatedControlPagePage()
        {
            InitializeComponent();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void Set<T>(ref T storage, T value, [CallerMemberName]string propertyName = null)
        {
            if (Equals(storage, value))
            {
                return;
            }

            storage = value;
            OnPropertyChanged(propertyName);
        }

        private void OnPropertyChanged(string propertyName) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        private void OnButtonClick(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            VisualStateManager.GoToState(Button, "Disabled", true);
        }

        private void Storyboard_Completed(object sender, object e)
        {

        }
    }

}
