using UnityEngine;
using UnityEngine.UI;


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
        
        public void ExitApplivcation()
        {
            Application.Quit();
        }
        private void Init()
        {
            _rigidbody = GetComponent<Rigidbody2D>();
        }

        [SerializeField] private int _jumpforse;
        public void Jump()
        {
            print("ПРЫЖОК");
          //_rigidbody.velocity = new Vector2(_rigidbody.velocity.x, _jumpforse);
           _rigidbody.AddForce(Vector2.up * _jumpforse, ForceMode2D.Impulse);
        }

        private void FixedUpdate()
        {
            //transform.position = new Vector2(Input.GetAxisRaw("Horizontal"), 0f);
            transform.position += transform.right * _joystick.Horizontal * _speed * Time.deltaTime;
            //_rigidbody.velocity = new Vector2(_joystick.Horizontal * _speed, 0f);
        }
        private void OnCollisionEnter(Collision collision)
        {
            //if(collision)
        }
    }
}
