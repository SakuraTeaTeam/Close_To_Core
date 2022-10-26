//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;

public class CameraMover : MonoBehaviour
{
    [SerializeField] Transform _targetPosition;
    [SerializeField] float _smoothCamera = 0.03f;
    [SerializeField] bool _movedCamera = false;
    [SerializeField] [Range(1, 2)] float clampHorizontalMove = 1.3f;
    [SerializeField] [Range(20, 60)] int _frameRate = 60;

    private void Awake()
    {
        _targetPosition = GameObject.Find("Player").transform;
        Application.targetFrameRate = _frameRate;
    }

    private void LateUpdate()
    {
        Vector3 fallow_ = Vector3.Lerp(transform.position, _targetPosition.position, _smoothCamera);

        transform.position = new Vector3(fallow_.x / clampHorizontalMove, transform.position.y, transform.position.z);

        if (transform.position.y > _targetPosition.position.y)
        {
            _movedCamera = true;
        }

        if (_movedCamera )
        {
            if (_targetPosition.position.y < 0)
            {
                transform.position = new Vector3(fallow_.x / clampHorizontalMove, fallow_.y, transform.position.z);
            }
        }
    }
}
