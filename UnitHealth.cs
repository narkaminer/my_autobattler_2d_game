using UnityEngine;

public class UnitHealth : MonoBehaviour
{
    private float currentHealth;
    private UnitData unitData;

    private void Awake()
    {
        UnitCombat combat = GetComponent<UnitCombat>();

        if (combat != null)
        {
            unitData = combat.GetUnitData();
        }

        if (unitData != null)
        {
            currentHealth = unitData.maxHealth;
        }
    }

    public void TakeDamage(float damage)
    {
        currentHealth -= damage;

        Debug.Log(gameObject.name + " HP: " + currentHealth);

        if (currentHealth <= 0f)
        {
            Die();
        }
    }

    private void Die()
    {
        Debug.Log(gameObject.name + " died!");

        Destroy(gameObject);

        BattleManager battleManager = FindFirstObjectByType<BattleManager>();

        if (battleManager != null)
        {
            battleManager.UnitDied();
        }
    }

    public float GetCurrentHealth()
    {
        return currentHealth;
    }

    public float GetMaxHealth()
    {
        return unitData.maxHealth;
    }
}