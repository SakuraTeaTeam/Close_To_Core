using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Bullet : MonoBehaviour
{
    [SerializeField] Vector2 _spownPosition;
    [SerializeField] Vector2 _scaleMy;


    void Start()
    {
        _spownPosition = transform.position;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        transform.position = _spownPosition;

    }
}
