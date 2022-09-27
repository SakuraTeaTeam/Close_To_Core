using UnityEngine;

public class SaveScore : MonoBehaviour
{
    [SerializeField] 
    private int _Score;
    [SerializeField] 
    private int _Coins;
    
    private void Start()
    {
        _Score = PlayerPrefs.GetInt("Score");
        _Coins = PlayerPrefs.GetInt("Coins");
    }

    private void OnApplicationQuit()
    {
        PlayerPrefs.SetInt("Score", _Score);
        PlayerPrefs.SetInt("Coins", _Coins);
    }
}
