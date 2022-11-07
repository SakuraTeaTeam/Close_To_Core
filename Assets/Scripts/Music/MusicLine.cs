using UnityEditor.SceneManagement;
using UnityEngine;

[RequireComponent(typeof(AudioSource))] 

public class MusicLine : MonoBehaviour
{   
    [SerializeField]
    private AudioSource _backGraundSound;
    [SerializeField]
    private float _radiusPlay;
    [SerializeField]
    private GameObject _listenBox;

    private float _distanceBetweenPoints;

    private void Update()
    {
        SoundPlayRadius();
    }
    #region œ–Œ»√–€¬¿Õ»≈ Ã”«€ » œ–» œ–»¡À»∆≈Õ»» 
    private void SoundPlayRadius()
    {
        _distanceBetweenPoints = Vector3.Distance(_listenBox.transform.position, transform.position);

        if (_distanceBetweenPoints <= _radiusPlay)
        {
            _backGraundSound.volume = (_radiusPlay - _distanceBetweenPoints) / _radiusPlay;
        }
        else _backGraundSound.volume = 0 * Time.deltaTime;
    }
    #endregion
}
