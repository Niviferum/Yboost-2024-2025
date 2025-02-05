using UnityEngine;

public class SniperBullet : MonoBehaviour, IBullet
{
    private Rigidbody2D _rb;
    private float _speed = 20f;
    private float _damage = 40f;

    public float Damage
    {
        get { return _damage; }
    }

    public void DestroyBullet()
    {
        Destroy(gameObject);
    }

    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        _rb.linearVelocity = transform.right * _speed;
    }
}
