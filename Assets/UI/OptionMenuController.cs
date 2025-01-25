using UnityEngine;
using UnityEngine.UI;

public class OptionMenuController : MonoBehaviour
{
    [SerializeField] GameObject _sfx;
    [SerializeField] GameObject _music;
    [SerializeField] GameObject _bloodAndGore;
    private Slider _sfxSlider;
    private Slider _musicSlider;
    private Toggle _bloodToggle;

    private void Awake()
    {
        _sfxSlider = _sfx.GetComponent<Slider>();
        _musicSlider = _music.GetComponent<Slider>();
        _bloodToggle = _bloodAndGore.GetComponent<Toggle>();
    }

    public void UpdateSettings()
    {

        float SfxValue = _sfxSlider.value;
        float MusicValue = _musicSlider.value;
        bool BloodValue = _bloodToggle.isOn;
        // SEND THE DATA HERE
    }

}
