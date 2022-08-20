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
    internal class LanguageLogic : ILanguageLogic
    {
        public string Root
        {
            get { return Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location); }
        }

        public ResourceDictionary SetupLanguage(string Language)
        {
            ResourceDictionary dictionary = new ResourceDictionary();

            dictionary.Source = new Uri(Root + $@"\Assest\Localization\{Language}.xaml", UriKind.RelativeOrAbsolute);

            return dictionary;
        }
    }
}
