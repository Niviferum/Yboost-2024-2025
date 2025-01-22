using Unity.VisualScripting;
using UnityEngine;

public class BulletMovement : MonoBehaviour
{
    public Rigidbody2D rb;
    private float speed = 20f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb.linearVelocity = transform.right * speed;
    }
}
