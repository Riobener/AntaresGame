using System.Collections.Generic;
using System.Xml;
using UnityEngine;

public class LocalizationManager : MonoBehaviour
{
    private static int SelectedLanguage { get; set; }
    public static event LanguageChangeHandler OnLanguageChange;

    public delegate void LanguageChangeHandler();    
    private static Dictionary<string, List<string>> _localization;

    [SerializeField] private TextAsset _textFile;

    private void Awake()
    {
        if (_localization == null)
            LoadLocalization();
    }
    public void SetLanguage(int id)
    {
        SelectedLanguage = id;
        OnLanguageChange?.Invoke(); 
    }
    private void LoadLocalization()
    {
        _localization = new Dictionary<string, List<string>>();

        XmlDocument xmlDocument = new XmlDocument();
        xmlDocument.LoadXml(_textFile.text);

        foreach (XmlNode element in xmlDocument["Elements"].ChildNodes)
        {
            string elementStr = element.Attributes["name"].Value;
            var values = new List<string>();
            foreach (XmlNode translate in element["translets"].ChildNodes)
            {
                values.Add(translate.InnerText);
            }

            _localization[elementStr] = values;
        }
    }

    public static string GetTranslate(string key, int languageID = -1)
    {
        if (languageID == -1)
        {
            languageID = SelectedLanguage;
        }

        if (_localization.ContainsKey(key))
        {
            return _localization[key][languageID];
        }

        return key;
    }
}
