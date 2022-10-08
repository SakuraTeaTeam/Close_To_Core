using Assets.Scripts.Player.Logic;
using UnityEngine;

namespace Foes.Shade
{
    public class ShadeAttack : MonoBehaviour
    {
        [SerializeField] private float _damage = 1f;
        private void OnTriggerEnter2D(Collider2D collider)
        {
            IDamageable damageable = collider.GetComponent<IDamageable>();
            if (damageable != null)
            {
                damageable.TakeDamage(_damage);
            }
        }
    }
}
