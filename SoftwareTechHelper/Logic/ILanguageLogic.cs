using System;
using System.Windows;

namespace SoftwareTechHelper.Logic
{
    public interface ILanguageLogic
    {
        string Root { get; }

        void SetupLanguage(string Language, ref ResourceDictionary dictionary);
    }
}