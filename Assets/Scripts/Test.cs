using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    [SerializeField] Transform _targetPosition; 
    [SerializeField] float _smoothCamera = 0.03f;
    [SerializeField] bool _movedCamera = false;
    [SerializeField] [Range(1, 2)] float clampHorizontalMove = 1f;
    [SerializeField] bool _movedHorizontalCamera;

    private void Update()
    {
        Vector3 fallow_ = Vector3.Lerp(transform.position, _targetPosition.position, _smoothCamera);

        if (_movedHorizontalCamera)
        {
            transform.position = new Vector3(fallow_.x / clampHorizontalMove, transform.position.y, transform.position.z);
        }
        else transform.position = new Vector3(0f, transform.position.y, transform.position.z);

        if (transform.position.y > _targetPosition.position.y)
        {
            _movedCamera = true;
        }

        if (_movedCamera)
        {
            if(_movedHorizontalCamera) transform.position = new Vector3(fallow_.x / clampHorizontalMove, fallow_.y, transform.position.z);

            else transform.position = new Vector3(0f, fallow_.y, transform.position.z);
        }
    }
}
