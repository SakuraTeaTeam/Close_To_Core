using UnityEngine;


namespace Assets.Scripts.Player.Logic
{
    [RequireComponent(typeof(Rigidbody2D))]
    public class PlayerMovement : MonoBehaviour
    {
        [Header("Values")]

        [SerializeField]
        private float _speed;

        [Header("Components")]

        [SerializeField]
        private DynamicJoystick _joystick;

        private Rigidbody2D _rigidbody;

        private void Awake()
        {
            Init();
        }
        
        private void Init()
        {
            _rigidbody = GetComponent<Rigidbody2D>();
        }

        private void Update()
        {
            _rigidbody.velocity = new Vector2(_joystick.Horizontal * _speed, 0f);
        }




    }
}
