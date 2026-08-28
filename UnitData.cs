using UnityEngine;

public enum AttackType
{
    Melee,
    Ranged
}

[CreateAssetMenu(fileName = "NewUnitData", menuName = "Autobattler/Unit Data")]
public class UnitData : ScriptableObject
{
    [Header("Basic Info")]
    public string unitName;
    public int cost;

    [Header("Combat Stats")]
    public float maxHealth;
    public float attackDamage;
    public float attackCooldown;
    public float attackRange;
    public AttackType attackType;

    [Header("Movement")]
    public float moveSpeed;

    [Header("Visuals")]
    public Sprite sprite;

    [Header("Projectile")]
    public Projectile projectilePrefab;
    public float projectileSpeed = 8f;
}