using UnityEngine;

namespace Assets.Scripts.Foes.Logic
{
    public class FollowSomething : MonoBehaviour
    {
        [SerializeField]
        private GameObject _followTarget;

        //[SerializeField]
        //private Vector3 _deltaPosition;
        
        [SerializeField] [Range(0, 1)] private float _followSpeed;

        void Update()
        {
            FollowTarget();
        }

        private void FollowTarget()
        {
            if (Vector3.Distance(_followTarget.transform.position, transform.position) <= 0.3f)
            {
                return;
            }
            transform.position = Vector3.Lerp(transform.position, _followTarget.transform.position, Time.deltaTime * _followSpeed);
        }
    }
}
