using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    private Slider slider;
    private UnitHealth unitHealth;

    private void Awake()
    {
        slider = GetComponentInChildren<Slider>();
        unitHealth = GetComponentInParent<UnitHealth>();
    }

    private void Start()
    {
        if (slider == null)
        {
            Debug.LogError("HealthBar: Slider not found!");
            return;
        }

        if (unitHealth == null)
        {
            Debug.LogError("HealthBar: UnitHealth not found!");
            return;
        }

        slider.minValue = 0f;
        slider.maxValue = 1f;
        slider.value = 1f;
    }

    private void Update()
    {
        if (slider == null || unitHealth == null)
        {
            return;
        }

        float healthPercent =
            unitHealth.GetCurrentHealth() /
            unitHealth.GetMaxHealth();

        slider.value = healthPercent;
    }
}