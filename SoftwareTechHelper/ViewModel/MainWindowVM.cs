using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using SoftwareTechHelper.Logic;
using SoftwareTechHelper.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace SoftwareTechHelper.ViewModel
{
    class MainWindowVM : ViewModelBase
    {
        //TODO resize törlése
        public MainWindowModel MainWindowModel { get; set; }
        public LanguageModel LanguageModel { get; set; }
        public LanguageLogic LanguageLogic { get; set; }

        public MainWindowVM()
        {
            this.MainWindowModel = new MainWindowModel();
            this.LanguageModel = new LanguageModel();
            this.LanguageLogic = new LanguageLogic();
            this.LanguageModel.Dictionary = LanguageLogic.SetupLanguage("Hungarian");

            MaximalizeCommand = new RelayCommand(() => Maximalize());
            CloseWindowCommand = new RelayCommand<Window>(CloseWindow);

        }

        #region RelayCommands
        public RelayCommand<Window> CloseWindowCommand { get; private set; }
        private void CloseWindow(Window window)
        {
            if (MessageBox.Show(LanguageModel.Dictionary["closeProgram"] as string, "", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                //TODO: saving?
                window.Close();
            }
        }

        public RelayCommand MinimizeCommand { get; private set; }
        private void Minimize()
        {
            MainWindowModel.CurWindowState = WindowState.Minimized;
        }

        public RelayCommand MaximalizeCommand { get; private set; }
        private void Maximalize()
        {
            MainWindowModel.CurWindowState =
                (MainWindowModel.CurWindowState == WindowState.Normal ? WindowState.Maximized :
                WindowState.Normal);
        }
        #endregion    

    }
}
