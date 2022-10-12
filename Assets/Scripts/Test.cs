using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    [SerializeField] Transform _playertransform;
    [SerializeField] Vector2 _offset;

    private void Update()
    {
        if(_playertransform.position.y < 2.5f)
        {
            _offset = _playertransform.position - transform.position;
            transform.position = new Vector2(transform.position.x, _offset.y);
        }
    }

}
