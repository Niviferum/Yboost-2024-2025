using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class HealthManager : MonoBehaviour
{
    private float _maxHealth = 100;
    public float Health = 100;
    [SerializeField] List<Transform> respawnPossiblePosition = new List<Transform>();

    HealthUIScript healthBar;

    private void Start()
    {
        healthBar = GameObject.Find("InGameUI").transform.Find("StatusPanel").transform.Find("LifeBackground").GetComponent<HealthUIScript>();
    }

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
        healthBar.ChangeHealth();
        if (Health <= 0)
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
        transform.position = respawnPossiblePosition[Random.Range(0, respawnPossiblePosition.Count)].position;
        gameObject.SetActive(true);
    }
}
