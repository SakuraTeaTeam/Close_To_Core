using UnityEngine;

public class HealingSystem : MonoBehaviour
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
        DecreasHealth();   
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Light")
        {
            Healing();
        }
    }
   
    void Healing()
    {
        _hp++;
        if (_hp > _maxHp)
        {
            _hp = _maxHp;
        }
    }
    
    void DecreasHealth()
    {
        _hp -= Time.deltaTime;
    }
}
