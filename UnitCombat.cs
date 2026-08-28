using UnityEngine;

public class UnitCombat : MonoBehaviour
{
    [SerializeField] private UnitData unitData;

    private float attackTimer;
    private Transform enemy;

    private UnitMovement movement;
    private BattleManager battleManager;

    private bool movingToThrone = false;

    public UnitData GetUnitData()
    {
        return unitData;
    }

    private void Awake()
    {
        movement = GetComponent<UnitMovement>();
        battleManager = FindFirstObjectByType<BattleManager>();
    }

    private void Update()
    {
        if (battleManager != null && battleManager.IsBattleEnded())
        {
            StopMoving();
            return;
        }

        // Если враг уже умер или его больше нет
        if (enemy == null)
        {
            FindEnemy();

            // Врагов больше нет — идём к трону
            if (enemy == null)
            {
                MoveToEnemyThrone();
                return;
            }
        }

        // Если мы уже идём к трону
        if (movingToThrone)
        {
            MoveToEnemyThrone();
            return;
        }

        float distance = Vector2.Distance(
            transform.position,
            enemy.position
        );

        if (distance <= unitData.attackRange)
        {
            StopMoving();
            Attack();
        }
        else
        {
            ResumeMoving();
        }
    }

    private void FindEnemy()
    {
        GameObject enemyObject = null;

        if (CompareTag("Player"))
        {
            enemyObject = GameObject.FindGameObjectWithTag("Enemy");
        }
        else if (CompareTag("Enemy"))
        {
            enemyObject = GameObject.FindGameObjectWithTag("Player");
        }

        if (enemyObject != null)
        {
            enemy = enemyObject.transform;
            movingToThrone = false;
        }
    }

    private void MoveToEnemyThrone()
    {
        if (battleManager == null)
        {
            return;
        }

        bool isPlayer = CompareTag("Player");

        Transform throne = battleManager.GetEnemyThrone(isPlayer);

        if (throne == null)
        {
            ResumeMoving();
            return;
        }

        movingToThrone = true;
        ResumeMoving();

        float distance = Vector2.Distance(
            transform.position,
            throne.position
        );

        if (distance <= 0.2f)
        {
            StopMoving();
            battleManager.ThroneReached(isPlayer);
        }
    }

    private void StopMoving()
    {
        if (movement != null)
        {
            movement.enabled = false;
        }
    }

    private void ResumeMoving()
    {
        if (movement != null)
        {
            movement.enabled = true;
        }
    }

    private void Attack()
    {
        attackTimer -= Time.deltaTime;

        if (attackTimer > 0f)
        {
            return;
        }

        if (unitData.attackType == AttackType.Melee)
        {
            UnitHealth targetHealth = enemy.GetComponent<UnitHealth>();

            if (targetHealth != null)
            {
                targetHealth.TakeDamage(unitData.attackDamage);
            }
        }
        else if (unitData.attackType == AttackType.Ranged)
        {
            if (unitData.projectilePrefab != null)
            {
                Projectile projectile = Instantiate(
                    unitData.projectilePrefab,
                    transform.position,
                    Quaternion.identity
                );

                projectile.Initialize(
                    enemy,
                    unitData.attackDamage,
                    unitData.projectileSpeed
                );
            }
        }

        attackTimer = unitData.attackCooldown;
    }
}