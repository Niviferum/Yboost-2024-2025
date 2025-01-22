using UnityEngine;

public class ShotgunShooting : MonoBehaviour, IShooting
{
    private float _fireRate = 1f;
    private float nextFire = 0.0f;
    private float bulletLifetime = 0.5f;
    private float bulletDamage = 1f;
    private float dispersionRange = 6f;
    [SerializeField] private GameObject bulletPrefab;

    public void Shoot(Transform spawnPoint)
    {
        if (Time.time > nextFire)
        {
            nextFire = Time.time + _fireRate;

            GameObject bullet1 = Instantiate(bulletPrefab, spawnPoint.position, spawnPoint.rotation * Quaternion.Euler(0, 0, UnityEngine.Random.Range(-dispersionRange, dispersionRange)));
            GameObject bullet2 = Instantiate(bulletPrefab, spawnPoint.position, spawnPoint.rotation * Quaternion.Euler(0, 0, UnityEngine.Random.Range(-dispersionRange, dispersionRange)));
            GameObject bullet3 = Instantiate(bulletPrefab, spawnPoint.position, spawnPoint.rotation * Quaternion.Euler(0, 0, UnityEngine.Random.Range(-dispersionRange, dispersionRange)));
            GameObject bullet4 = Instantiate(bulletPrefab, spawnPoint.position, spawnPoint.rotation * Quaternion.Euler(0, 0, UnityEngine.Random.Range(-dispersionRange, dispersionRange)));
            GameObject bullet5 = Instantiate(bulletPrefab, spawnPoint.position, spawnPoint.rotation * Quaternion.Euler(0, 0, UnityEngine.Random.Range(-dispersionRange, dispersionRange)));
            GameObject bullet6 = Instantiate(bulletPrefab, spawnPoint.position, spawnPoint.rotation * Quaternion.Euler(0, 0, UnityEngine.Random.Range(-dispersionRange, dispersionRange)));
            GameObject bullet7 = Instantiate(bulletPrefab, spawnPoint.position, spawnPoint.rotation * Quaternion.Euler(0, 0, UnityEngine.Random.Range(-dispersionRange, dispersionRange)));


            Destroy(bullet1, bulletLifetime);
            Destroy(bullet2, bulletLifetime);
            Destroy(bullet3, bulletLifetime);
            Destroy(bullet4, bulletLifetime);
            Destroy(bullet5, bulletLifetime);
            Destroy(bullet6, bulletLifetime);
            Destroy(bullet7, bulletLifetime);
        }
    }
}
