using UnityEngine;

namespace Assets.Scripts.Foes.Shade
{
    public class ShadeMovement : MonoBehaviour
    {
        [SerializeField] private BoxCollider2D _platformCollider;

        [Header("Movement")]
        [SerializeField] [Range(1, 5)] private float _movementSpeed;
        [SerializeField] private bool _lookInRight;

        private Vector3 _maxLeftDelta, _maxRightDelta;

        void Start()
        {
            Init();
        }

        private void Init()
        {
            _maxLeftDelta = _platformCollider.bounds.center - new Vector3(_platformCollider.bounds.extents.x - 0.25f, 0f, 0f);
            _maxRightDelta = _platformCollider.bounds.center + new Vector3(_platformCollider.bounds.extents.x - 0.25f, 0f, 0f);

            if (!_lookInRight)
            {
                _movementSpeed *= -1f;
            }
        }

        void Update()
        {
            if (ReachedDelta())
            {
                MoveAndTurnInOppositeDirection();
            }

            Move();
        }

        private void Move()
        {
            transform.position += new Vector3(_movementSpeed * Time.deltaTime, 0f, 0f);
        }

        private void MoveAndTurnInOppositeDirection()
        {
            _movementSpeed *= -1f;
            _lookInRight = !_lookInRight;

        }

        private bool ReachedDelta()
        {
            return transform.position.x < _maxLeftDelta.x || transform.position.x > _maxRightDelta.x;
        }
    }
}

