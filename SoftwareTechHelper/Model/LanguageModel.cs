using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace SoftwareTechHelper.Model
{
    internal class LanguageModel : ObservableObject
    {
        private ResourceDictionary dictionary;
        public ResourceDictionary Dictionary
        {
            get { return dictionary; }
            set
            {
                dictionary = value;
                RaisePropertyChanged(() => this.Dictionary);
            }
        }

    }
}
