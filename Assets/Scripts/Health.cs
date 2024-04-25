using System;
using UnityEngine;

public class Health : MonoBehaviour
{
    public static Health instance;
    private float health;

    public event Action OnHurt;
    public event Action OnDie;

    private bool isDead;

    private void Awake()
    {
        instance = this;
        health = GameManager.instance.HeathPlayer() ;
    }

    public void TakeDamage(int damageTakenValue)
    {
        health -= damageTakenValue;
        CheckHealth();
    }

    private void CheckHealth()
    {
        if(health <= 0 && isDead == false)
        {
            isDead = true;
            OnDie?.Invoke();
        }
        else
        {
            OnHurt?.Invoke();
        }
    }

    public float GetPlayerHeath()
    {
        return health;
    }
}
