using CommunityToolkit.Mvvm.Messaging;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace SoftwareTechHelper.Logic
{
    public class LanguageLogic : ILanguageLogic
    {
        public LanguageLogic()
        {

        }

        public string Root
        {
            get { return Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location); }
        }

        public void SetupLanguage(string Language, ref ResourceDictionary dictionary)
        {
            if (dictionary == null)
            {
                dictionary = new ResourceDictionary();
            }
            else
            {
                dictionary.Clear();
            }
            dictionary.Source = new Uri(Root + $@"\Assest\Localization\{Language}.xaml", UriKind.RelativeOrAbsolute);
        }
    }
}
