using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SoundBar : MonoBehaviour
{

    [SerializeField]
    private AudioMixerGroup _mixerGroup;
    [SerializeField]
    private Toggle _toggle;
    [SerializeField]
    private Slider _slider;

    private void Start()
    {
        _toggle.isOn = PlayerPrefs.GetInt("VolumeMaster", 1) == 1;
        _slider.value = PlayerPrefs.GetFloat("VolumeMaster", 1);
    }

    #region ¬ À/¬€ À
    public void SoundPlay(bool enam)
    {
        if (enam)
            _mixerGroup.audioMixer.SetFloat("VolumeMaster", 0);
        else
            _mixerGroup.audioMixer.SetFloat("VolumeMaster", -80); 

        PlayerPrefs.SetInt("VolumeMaster", enam ? 1 : 0);
    }
    #endregion

    #region √–ŒÃ Œ—“‹
    public void ChangeVolume(float volume)
    {
        _mixerGroup.audioMixer.SetFloat("VolumeMaster", Mathf.Lerp(-80, 0, volume));
        PlayerPrefs.SetFloat("VolumeMaster", volume);
    }
    #endregion
}
