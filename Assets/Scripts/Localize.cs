using UnityEngine;

public class Localize : MonoBehaviour
{
    [SerializeField] private LocalizedText _settings;
    [SerializeField] private LocalizedText _sound;
    [SerializeField] private LocalizedText _vibration;
    [SerializeField] private LocalizedText _music;
    [SerializeField] private LocalizedText _language;

    public void LocalizeText()
    {
        _settings.Localize(_settings.name);
        _sound.Localize(_sound.name);
        _vibration.Localize(_vibration.name);
        _music.Localize(_music.name);
        _language.Localize(_language.name);
    }

}
