using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    [SerializeField] private Health health;
    [SerializeField] private Slider slider;
    [SerializeField] private Image image;
    private Gradient gradient;
    private void Awake()
    {
        slider.maxValue = health.MaxHealth;
        slider.value = health.CurrentHealth;
        health.HealthChangeEvent += OnHealthChange;
    }

    private void OnHealthChange(float _health)
    {
        slider.value = health.CurrentHealth;
        var color = gradient.Evaluate(slider.normalizedValue);
        image.color = color;

    }

}
