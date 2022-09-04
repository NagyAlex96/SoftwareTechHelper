using CommunityToolkit.Mvvm.ComponentModel;
using System.Windows;

namespace SoftwareTechHelper.Model
{
    class MainWindowModel : ObservableObject
    {
        private double windowHeight = SystemParameters.PrimaryScreenHeight / 1.5;
        public double WindowHeight
        {
            get { return windowHeight; }
            set { SetProperty(ref windowHeight, value); }
        }

        private double windowWidth = SystemParameters.PrimaryScreenWidth / 1.5;
        public double WindowWidth
        {
            get { return windowWidth; }
            set { SetProperty(ref windowWidth, value); }
        }

        private WindowState curWindowState;
        public WindowState CurWindowState
        {
            get { return curWindowState; }
            set { SetProperty(ref curWindowState, value); }
        }

        private ResizeMode resizing;
        public ResizeMode Resizing
        {
            get { return resizing; }
            set { SetProperty(ref resizing, value); }
        }
    }
}
