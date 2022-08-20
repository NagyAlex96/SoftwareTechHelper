using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace SoftwareTechHelper.Logic
{
    interface ILanguageLogic
    {
        string Root { get; }

        ResourceDictionary SetupLanguage(string Language);
    }
}
