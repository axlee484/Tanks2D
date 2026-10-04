using UnityEngine;

[RequireComponent(typeof(Collider2D))]
public class HitBox : MonoBehaviour
{
    private Collider2D collider;
    [SerializeField] private float damage = 0f;
    public float Damage => damage;
    private void Awake()
    {
        collider = GetComponent<Collider2D>();
    }
}
