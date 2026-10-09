using Unity.VisualScripting;
using UnityEngine;

public enum TurretType
{
    Normal,
    Railgun,
    Launcher,
}



[CreateAssetMenu(fileName = "NewTurret", menuName = "Scriptable Objects/Turret")]
public class TurretData : ScriptableObject
{
    [SerializeField] private BaseTurret turretPrefab;
    [SerializeField] private AmmoData ammoData;
    public BaseTurret TurretPrefab => turretPrefab;
    [SerializeField] private TurretType turretType;
    public TurretType TurretType => turretType;
    [SerializeField] private AmmoType ammoType;
    [SerializeField] private float baseDamage;
    public float BaseDamage => baseDamage;
    [SerializeField] private float range;
    public float Range => range;

    [SerializeField] private float fireRate;
    public float FireRate => fireRate;
    [SerializeField] private float speed;
    public float Speed => speed;
    [SerializeField] private float reloadTime;
    public float ReloadTime => reloadTime;
    [SerializeField] private int magazineSize;
    public int MagazineSize => magazineSize;
}
