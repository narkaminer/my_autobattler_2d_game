using UnityEngine;

public class BattleManager : MonoBehaviour
{
    [SerializeField] private Transform playerSide;
    [SerializeField] private Transform enemySide;

    [SerializeField] private Transform playerThrone;
    [SerializeField] private Transform enemyThrone;

    private bool battleEnded = false;

    public void UnitDied()
    {
        if (battleEnded)
        {
            return;
        }

        Invoke(nameof(CheckBattleResult), 0.01f);
    }

    public bool IsBattleEnded()
    {
        return battleEnded;
    }

    public Transform GetEnemyThrone(bool isPlayer)
    {
        return isPlayer ? enemyThrone : playerThrone;
    }

    public void ThroneReached(bool playerReachedEnemyThrone)
    {
        if (battleEnded)
        {
            return;
        }

        if (playerReachedEnemyThrone)
        {
            EndBattle("PLAYER WINS!");
        }
        else
        {
            EndBattle("ENEMY WINS!");
        }
    }

    private void CheckBattleResult()
    {
        if (battleEnded)
        {
            return;
        }

        bool playerAlive = HasLivingUnits(playerSide);
        bool enemyAlive = HasLivingUnits(enemySide);

        // Обе стороны уничтожены одновременно
        if (!playerAlive && !enemyAlive)
        {
            EndBattle("DRAW!");
        }

        // Если жива только одна сторона —
        // победитель должен добраться до трона.
    }

    private bool HasLivingUnits(Transform side)
    {
        return side.childCount > 0;
    }

    private void EndBattle(string result)
    {
        battleEnded = true;
        Debug.Log(result);
    }
}