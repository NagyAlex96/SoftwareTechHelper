using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace SoftwareTechHelper.Model
{
    class MainWindowModel : ObservableObject
    {
        private double windowHeight = SystemParameters.PrimaryScreenHeight / 1.5;
        public double WindowHeight
        {
            get { return windowHeight; }
            set
            {
                windowHeight = value;
                RaisePropertyChanged(() => this.WindowHeight);
            }
        }

        private double windowWidth = SystemParameters.PrimaryScreenWidth / 1.5;
        public double WindowWidth
        {
            get { return windowWidth; }
            set
            {
                windowWidth = value;
                RaisePropertyChanged(() => this.WindowWidth);
            }
        }

        private WindowState curWindowState;
        public WindowState CurWindowState
        {
            get
            {
                return curWindowState;
            }
            set
            {
                curWindowState = value;
                RaisePropertyChanged(() => this.CurWindowState);
            }
        }

        private ResizeMode resizing;
        public ResizeMode Resizing
        {
            get
            {
                return resizing;
            }
            set
            {
                resizing = value;
                RaisePropertyChanged(() => this.Resizing);
            }
        }


    }
}
