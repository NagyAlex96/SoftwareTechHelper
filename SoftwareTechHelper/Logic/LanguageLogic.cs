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

        //TODO: Compiler Error CS0206
        //public void SetupLanguage(string Language, ref ResourceDictionary dictionary)
        //{
        //    dictionary = new ResourceDictionary();

        //    dictionary.Source = new Uri(Root + $@"\Assest\Localization\{Language}.xaml", UriKind.RelativeOrAbsolute);
        //}
    }
}
