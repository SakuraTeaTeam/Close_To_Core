using UnityEngine;

namespace Player.Logic
{
    public class SaveState : MonoBehaviour
    {
        private int _level;
        private int _floor;
        private void Start()
        {
            _level = PlayerPrefs.GetInt("Level");
            _floor = PlayerPrefs.GetInt("Floor");
        }

        private void OnApplicationQuit()
        {
            PlayerPrefs.SetInt("Level", _level);
            PlayerPrefs.SetInt("Floor", _floor);
        }
    }
}
