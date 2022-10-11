using Assets.Scripts.Player.Logic;
using UnityEngine;

namespace Player.Logic
{
    public class HealingSystem : MonoBehaviour, IDamageable
    {
        [SerializeField]
        private float _hp;
        [SerializeField]
        private float _maxHp;

        private void Start()
        {
            _hp = _maxHp;
        }

        private void Update()
        {
            //DecreaseHealth();
            //Debug.Log(_hp);
        }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if(collision.gameObject.tag == "Light")
            {
                Heal();
            }
        }
   
        private void Heal()
        {
            _hp++;
            if (_hp > _maxHp)
            {
                _hp = _maxHp;
            }
        }
    
        private void DecreaseHealth()
        {
            _hp -= Time.deltaTime;
        }


        public void TakeDamage(float damage)
        {
            _hp -= damage;
        }
    }
}
