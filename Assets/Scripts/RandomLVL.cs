using UnityEngine;

public class RandomLVL : MonoBehaviour
{
    private int _scoreLVL;
    [SerializeField] private GameObject[] _levels;
    void Start()
    {
        _scoreLVL = Random.Range(0, _levels.Length);
        Instantiate(_levels[_scoreLVL], new Vector3(0, 0, 0), Quaternion.identity);
    }
    public void ButtonRandom()
    {
        _scoreLVL = Random.Range(0, _levels.Length);
        Instantiate(_levels[_scoreLVL], new Vector3(0, 0, 0), Quaternion.identity);
    }
}
