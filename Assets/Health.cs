using UnityEngine;
using System;

public class Health : MonoBehaviour
{
    public GameObject explosionPrefab;
    public int defaultHealthPoint = 3;

    int currentHealth;

    public Action onDead;

    void Awake()
    {
        currentHealth = defaultHealthPoint;
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;

        if (currentHealth <= 0)
        {
            Die();
        }
    }

    protected virtual void Die()
    {
        var explosion = Instantiate(
            explosionPrefab,
            transform.position,
            transform.rotation
        );

        Destroy(explosion, 1);

        Destroy(gameObject);

        onDead?.Invoke();
    }
}