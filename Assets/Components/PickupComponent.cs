using UnityEngine;

[RequireComponent(typeof(Collider2D))]
public class PickupComponent : MonoBehaviour
{
    public virtual void Pickup()
    {
        Destroy(transform.root.gameObject);
    }
   private void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.GetComponentInParent<Player>() != null)
        {
            Pickup();
        }
    } 
}
