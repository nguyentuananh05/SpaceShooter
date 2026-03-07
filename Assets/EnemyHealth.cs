using UnityEngine;

public class EnemyHealth : Health
{
    public static int LivingEnemyCount;

    void Awake()
    {
        LivingEnemyCount++;
    }

    protected override void Die()
    {
        LivingEnemyCount--;

        base.Die();
    }
}