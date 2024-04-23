using System;
using UnityEngine;

public class EnemyHeath : MonoBehaviour
{
    [SerializeField] private float health;
    [SerializeField] private float xpDrop = 50;

    public event Action OnHurt;
    public event Action OnDie;

    private bool isDead;

    public void TakeDamage(int damageTakenValue)
    {
        health -= damageTakenValue;
        CheckHealth();
    }

    private void CheckHealth()
    {
        if (health <= 0 && isDead == false)
        {
            isDead = true;
            XPHandler.instance.XPAdicionado(xpDrop);
            OnDie?.Invoke();
        }
        else
        {
            OnHurt?.Invoke();
        }
    }
}
