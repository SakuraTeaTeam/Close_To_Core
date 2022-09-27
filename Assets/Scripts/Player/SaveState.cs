using UnityEngine;

public class SaveState : MonoBehaviour
{
    [SerializeField]
    private int _Level;
    [SerializeField]
    private int _Floor;
    private void Start()
    {
        _Level = PlayerPrefs.GetInt("Level");
        _Floor = PlayerPrefs.GetInt("Floor");
    }

    private void OnApplicationQuit()
    {
        PlayerPrefs.SetInt("Level", _Level);
        PlayerPrefs.SetInt("Floor", _Floor);
    }
}
