                                              // BY: Mylti
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class UiManager : MonoBehaviour
{
    [SerializeField]
    private Image[] _heartImages;
    [SerializeField]
    private Sprite _damageHeart;
    [SerializeField]
    private Sprite _fullHeart;
    [SerializeField]
    private Image _music;
    [SerializeField]
    private Sprite _musicOn;
    [SerializeField]
    private Sprite _musicOff;
    private static float a = 1f;
    [SerializeField]
    private HealingSystem _csHealingSystem;
    [SerializeField]
    private GameObject _settings;
    [SerializeField]
    private GameObject _foneStart;

    private void Start()
    {
        _csHealingSystem = FindObjectOfType<HealingSystem>();
        Time.timeScale = 0;
        _foneStart.SetActive(true);
        _music.sprite = _musicOn;
    }
    private void Update()
    {
        CheckHP(_csHealingSystem.Hp);
    }

    private void CheckHP(float HP)
    {
        for (int i = 0; i < _heartImages.Length; i++)
        {
            if(i < Mathf.RoundToInt(_csHealingSystem.Hp))
            {
                _heartImages[i].sprite = _fullHeart;
            }
            else
            {
                _heartImages[i].sprite = _damageHeart;
            }
            if(i < _csHealingSystem.MaxHP)
            {
                _heartImages[i].enabled = true;
            }
            else
            {
                _heartImages[i].enabled = false;
            }
        }
    }
    public void Settings()
    {
        if(_settings.activeSelf == false)
        {
            _settings.SetActive(true);
            Time.timeScale = 0;
        }
        else
        {
            _settings.SetActive(false);
            Time.timeScale = 1;
        }
    }
    public void StartGame()
    {
        Time.timeScale = 1;
        _foneStart.SetActive(false);
    }
    public void Music()
    {
        if(_music.sprite == _musicOn)
        {
            _music.sprite = _musicOff;
        }
        else
        {
            _music.sprite = _musicOn;
        }
    }
    public void Exit()
    {
        SceneManager.LoadScene(0);
    }
    public void Restart()
    {
        SceneManager.LoadScene(0);
    }
}
