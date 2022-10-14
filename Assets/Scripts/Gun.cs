using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//[RequireComponent(typeof(Rigidbody2D))]
public class Gun : MonoBehaviour
{
    [SerializeField] Vector2 _spownPosition;
    [SerializeField] Transform _bullet;
    [SerializeField] float _speed, _timerShoote;


    private void Awake()
    {
        print("Awake");
        _spownPosition = _bullet.position;
        _timerShoote = Random.Range(0.7f, 2f);
    }

    void Update()
    {

        _bullet.position += transform.right * _speed * Time.deltaTime;
        //_bullet.transform.Translate(transform.right * _speed * Time.deltaTime);
    }
}
