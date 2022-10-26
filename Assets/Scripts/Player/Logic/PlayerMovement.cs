using UnityEngine;
//using UnityEngine.UI;
using UnityEngine.SceneManagement;


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
        public void ReloadScene()
        {
            Application.LoadLevel(SceneManager.GetActiveScene().buildIndex);
        }
        private void Init()
        {
            _rigidbody = GetComponent<Rigidbody2D>();
        }

        [SerializeField] private int _jumpforse;
        public void Jump()
        {
           _rigidbody.AddForce(Vector2.up * _jumpforse, ForceMode2D.Impulse);
        }

        private void FixedUpdate()
        {
            transform.position += transform.right * _joystick.Horizontal * _speed * Time.deltaTime;
        }
        private void OnCollisionEnter(Collision collision)
        {
        }
    }
}
