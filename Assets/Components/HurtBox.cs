using System;
using UnityEngine;

[RequireComponent(typeof(Collider2D))]
public class HurtBox : MonoBehaviour
{
    private Collider2D collider;
    public event Action<float> HurtEvent;
    private void Awake()
    {
        collider = GetComponent<Collider2D>();
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.collider.TryGetComponent<HitBox>(out var otherHitBox))
        {
            HurtEvent?.Invoke(otherHitBox.Damage);
        }
    }
}
