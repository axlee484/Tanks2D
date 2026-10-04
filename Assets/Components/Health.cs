using System;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] private float maxHealth = 100f;
    public float MaxHealth => maxHealth;
    [SerializeField] private HurtBox hurtBox;
    private float currentHealth = 0f;
    public float CurrentHealth => currentHealth;
    public event Action<float> HealthChangeEvent;

    private void Awake()
    {
        currentHealth = maxHealth;
        if(hurtBox != null)
        {
            hurtBox.HurtEvent += OnHurt;
        }
    }

    void OnHurt(float damage)
    {
        TakeDamage(damage);
    }

    public void TakeDamage(float damage)
    {
        currentHealth -= damage;
        HealthChangeEvent?.Invoke(-currentHealth);
        if (currentHealth <= 0f)
        {
            Die();
        }
    }
    public void Heal(float heal)
    {
        currentHealth += heal;
        HealthChangeEvent?.Invoke(currentHealth);
        if (currentHealth > maxHealth)
        {
            currentHealth = maxHealth;
        }
    }

    void Die()
    {
        Destroy(gameObject);
    }
}
