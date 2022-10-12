using UnityEngine;

public class UiManager : MonoBehaviour
{
    [SerializeField]
    private Sprite _heart1;
    [SerializeField]
    private Sprite _heart2;
    [SerializeField]
    private Sprite _heart3;
    [SerializeField]
    private Sprite _damageHeart;
    [SerializeField]
    private HealingSystem _healingSystem;
    [SerializeField]
    private float _limit1;
    [SerializeField]
    private float _limit2;
    [SerializeField]
    private float _limit3;

    private void Update()
    {
        if(_healingSystem.Hp < _limit3)
        {
            _heart3 = _damageHeart;
        }
        else if(_healingSystem.Hp < _limit2)
        {
            _heart2 = _damageHeart;
        }
        else if(_healingSystem.Hp < _limit1)
        {
            _heart1 = _damageHeart;
        }
        if(_healingSystem.Hp > _limit1)
        {
            _heart1 = _heart1;
        }
        else if(_healingSystem.Hp > _limit2)
        {
            _heart2 = _heart1;
        }
        else if (_healingSystem.Hp > _limit3)
        {
            _heart3 = _heart1;
        }
      
    }


}
