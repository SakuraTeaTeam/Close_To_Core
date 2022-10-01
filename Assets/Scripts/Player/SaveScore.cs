using UnityEngine;

public class SaveScore : MonoBehaviour
{
    private int _score;
    private int _coins;
    
    private void Start()
    {
        _score = PlayerPrefs.GetInt("Score");
        _coins = PlayerPrefs.GetInt("Coins");
    }

    private void OnApplicationQuit()
    {
        PlayerPrefs.SetInt("Score", _score);
        PlayerPrefs.SetInt("Coins", _coins);
    }
}
