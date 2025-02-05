using UnityEngine;

public class ShotgunBulletScript : MonoBehaviour, IBullet
{
    private Rigidbody2D _rb;
    private float _speed = 20f;
    private float _damage = 5f;

    public float Damage
    {
        get { return _damage; }
    }

    public void DestroyBullet()
    {
        Destroy(gameObject);
    }


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        _rb.linearVelocity = transform.right * _speed;
    }
}
