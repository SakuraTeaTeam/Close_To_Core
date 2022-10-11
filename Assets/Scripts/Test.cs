using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    [SerializeField] private int _jumpforse = 6;
    [SerializeField] private Rigidbody2D _rigidbody;
    [SerializeField] private DynamicJoystick _joystick;
    [SerializeField] private float _speed = 3.5f;
    [SerializeField] bool isJumped = false;
    [SerializeField] LayerMask _mascCollision;

    public void Jump()
    {
        print("œ–€∆Œ ");
        _rigidbody.AddForce(Vector2.up * _jumpforse, ForceMode2D.Impulse);
    }
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        transform.position += transform.right *_joystick.Horizontal * _speed * Time.deltaTime;
    }
    private void OncollisionEnter(Collision collision)
    {
       // if(collision.mas)
    }
}
