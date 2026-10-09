using UnityEngine;


public enum AmmoType
{
    NormalAmmo,
    RailgunAmmo,
    HomingMissile,
    Bomb,
    Mine
}

[CreateAssetMenu(fileName = "NewAmmo", menuName = "Scriptable Objects/Ammo")]
public class AmmoData : ScriptableObject
{
    [SerializeField] private AmmoType ammoType;
    public AmmoType AmmoType => ammoType;
}
