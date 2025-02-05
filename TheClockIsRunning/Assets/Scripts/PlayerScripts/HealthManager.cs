using Unity.VisualScripting;
using UnityEngine;

public class HealthManager : MonoBehaviour
{
    private float _maxHealth;
    public float Health = 100;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "bullet") {
            TakeDamage(other.GetComponent<IBullet>().Damage);
            other.GetComponent<IBullet>().DestroyBullet();
        }
    }

    private void TakeDamage(float damage)
    {
        Health -= damage;
        if (Health < 0)
        {
            Death();
            
        }
    }

    private void IsHealed(float heal)
    {
        Health += heal;
        if ( Health > _maxHealth)
        {
            Health = _maxHealth;
        }

        
    }

    private void Death()
    {
        gameObject.SetActive(false);
        Health = _maxHealth;
    }
}
