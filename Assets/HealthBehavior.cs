using System;
using UnityEngine;
using UnityEngine.Events;

public class HealthBehavior : MonoBehaviour
{
    [HideInInspector]
    public UnityEvent<float> HealtChange;

    [SerializeField]
    private float _health;

    private float _curentHealth;

    void Start()
    {
        _curentHealth = _health;
    }

    public void DoDamage(float damage)
    {
        if (_curentHealth > 0)
        {
            _curentHealth = Math.Max(_curentHealth - damage, 0);

            OnHealthChange(_curentHealth);
        }
    }

    public void DoHeal(float heal)
    {
        if (_curentHealth < _health)
        {
            _curentHealth = Math.Min(_curentHealth + heal, _health);

            OnHealthChange(_curentHealth);
        }
    }

    private void OnHealthChange(float health)
    {
        HealtChange.Invoke(health);
    }
}
