using UnityEngine;

public class FireWeapon : MonoBehaviour
{
    [SerializeField] private Bullet _bulletPrefab;
    [SerializeField] private Transform _bulletSpawnPoint;
    [SerializeField] private float _fireRate;
    [SerializeField] private AudioClip _fireSound;
    private PoolSystem<Bullet> _poolSystem;

    private void Start()
    {
        _poolSystem = new PoolSystem<Bullet>(_bulletPrefab, 30, transform);
        InvokeRepeating(nameof(Fire), 0, _fireRate);
    }

    private void Fire()
    {
        Bullet bullet = _poolSystem.Get();
        bullet.SetPool(_poolSystem);

        bullet.transform.position = _bulletSpawnPoint.position;

        AudioMixerSingleton.GetInstance().Play(_fireSound);
    }
}
