using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Settings : MonoBehaviour
{
    public Text language;
    public Text sound;
    public Text settings;
    public Text vibration;
    public Text music;
    
    public Button soundBtn;
    public Button vibrationBtn;
    public Button musicBtn;
    public Button ActsoundBtn;
    public Button ActvibrationBtn;
    public Button ActmusicBtn;
    
    private bool IsSound;
    private bool IsVibration;
    private bool IsMusic;
    private bool IsActSound;
    private bool IsActVibration;
    private bool IsActMusic;
    
    
    private String _language;
    private String _sound;
    private String _settings;
    private String _vibration;
    private String _music;
    public void changeLanguage()
    {
        if (language.text.Equals("english"))
        {
            language.text = "русский";
            settings.text = "настройки";
            vibration.text = "вибрация";
            music.text = "музыка";
            sound.text = "звуки";
        }
        else
        {
            language.text = "english";
            settings.text = "Settings";
            vibration.text = "vibration";
            music.text = "music";
            sound.text = "sound";
        }
    }

    public void SaveCondition()
    {
        IsSound = soundBtn.IsActive();
        IsVibration = vibrationBtn.IsActive();
        IsMusic = musicBtn.IsActive();
        IsActSound = ActsoundBtn.IsActive();
        IsActVibration = ActvibrationBtn.IsActive();
        IsActMusic = ActmusicBtn.IsActive();
        _language = language.text;
        _settings = settings.text;
        _vibration =  vibration.text; 
        _music = music.text;
        _sound = sound.text;
    }

    public void dontSave()
    {
        soundBtn.gameObject.SetActive(IsSound); 
        vibrationBtn.gameObject.SetActive(IsVibration);
        musicBtn.gameObject.SetActive(IsMusic);
        ActsoundBtn.gameObject.SetActive(IsActSound); 
        ActvibrationBtn.gameObject.SetActive(IsActVibration);
        ActmusicBtn.gameObject.SetActive(IsActMusic);
        language.text = _language;
        settings.text = _settings;
        vibration.text = _vibration;
        music.text = _music;
        sound.text = _sound;
    }


    public Image settingsBG;
    public GameObject menuCentre;
    public Button activeSettingBtn;
    public Button SettingBtn;
    public Animator closeAnimation;
    public Animator openAnimation;
    public void closeSettings()
    {
        SettingBtn.gameObject.SetActive(true);
        closeAnimation.SetTrigger("Close");
    }
    public void closedSettings()
    {
        menuCentre.SetActive(true);
        settingsBG.gameObject.SetActive(false);
        activeSettingBtn.gameObject.SetActive(false);
    }
    
    public void openSettings()
    {
        menuCentre.SetActive(false);
        activeSettingBtn.gameObject.SetActive(true);
        settingsBG.gameObject.SetActive(true);
        openAnimation.SetTrigger("Open");
    }
    public void openedSettings()
    {
        
        settingsBG.rectTransform.anchoredPosition.Set(0f,-30f);
        settingsBG.rectTransform.sizeDelta.Set(-240f,-900f);
        SettingBtn.gameObject.SetActive(false);
    }

    
    
    
}
