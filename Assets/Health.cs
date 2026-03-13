using UnityEngine;
using System;

public class Health : MonoBehaviour
{
    public int defaultHealthPoint = 3;

    public Action onDead;
    public Action onHealthChanged;

    public int healthPoint;

    void Start()
    {
        healthPoint = defaultHealthPoint;
        onHealthChanged?.Invoke();
    }

    public void TakeDamage(int damage)
    {
        if (healthPoint <= 0) return;

        healthPoint -= damage;

        onHealthChanged?.Invoke();

        if (healthPoint <= 0)
        {
            Die();
        }
    }

    protected virtual void Die()
    {
        Destroy(gameObject);
        onDead?.Invoke();
    }
}