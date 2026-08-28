using UnityEngine;

public class UnitMovement : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 1.5f;
    [SerializeField] private int direction = 1;

    private void Update()
    {
        transform.position += Vector3.right * direction * moveSpeed * Time.deltaTime;
    }
}