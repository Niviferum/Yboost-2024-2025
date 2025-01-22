using UnityEngine;

public class SniperShooting : MonoBehaviour, IShooting
{
    private float _fireRate = 1.2f;
    private float nextFire = 0.0f;
    private float bulletLifetime = 3f;
    private float bulletDamage = 0.2f;
    private float dispersionRange = 2f;
    [SerializeField] private GameObject bulletPrefab;

    public void Shoot(Transform spawnPoint)
    {
        if (Time.time > nextFire)
        {
            nextFire = Time.time + _fireRate;

            Quaternion dispersion = spawnPoint.rotation * Quaternion.Euler(0, 0, UnityEngine.Random.Range(-dispersionRange, dispersionRange));

            GameObject bullet = Instantiate(bulletPrefab, spawnPoint.position, dispersion);

            Destroy(bullet, bulletLifetime);
        }
    }
}
