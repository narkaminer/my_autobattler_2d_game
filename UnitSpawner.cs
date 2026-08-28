using UnityEngine;

public class UnitSpawner : MonoBehaviour
{
    [SerializeField] private GameObject unitPrefab;
    [SerializeField] private Transform spawnPoint;
    [SerializeField] private Transform unitParent;

    private void Start()
    {
        SpawnUnit();
    }

    public GameObject SpawnUnit()
    {
        GameObject newUnit = Instantiate(
            unitPrefab,
            spawnPoint.position,
            Quaternion.identity,
            unitParent
        );

        return newUnit;
    }
}