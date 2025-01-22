using System;
using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;
using static UnityEngine.RuleTile.TilingRuleOutput;

public class PlayerLookAt : MonoBehaviour
{
    InputAction lookAction;
    InputAction shootAction;

    private Vector2 lookDir;
    private Vector2 mousePosition;

    private float _fireRate = 0.1f;
    private float nextFire = 0.0f;
    private float bulletLifetime = 1.5f;

    public GameObject player;
    public GameObject bulletPrefab;
    public UnityEngine.Transform spawnPoint;

    public Camera cam;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //cam.ScreenToWorldPoint()
        lookAction = InputSystem.actions.FindAction("Look");
        shootAction = InputSystem.actions.FindAction("Attack");
    }

    // Update is called once per frame
    void Update()
    {
        mousePosition = cam.ScreenToWorldPoint(lookAction.ReadValue<Vector2>());
        lookDir = new Vector3(mousePosition.x, mousePosition.y, transform.position.z) - transform.position;

        float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
    }

    void Shoot()
    {
        nextFire = Time.time + _fireRate;

        Quaternion dispersion = spawnPoint.rotation * Quaternion.Euler(0, 0, UnityEngine.Random.Range(-2f, 2f));

        GameObject bullet = Instantiate(bulletPrefab, spawnPoint.position, dispersion);
        Destroy(bullet, bulletLifetime);
    }

    private void FixedUpdate()
    {
        if (shootAction.ReadValue<float>() > 0.5 && Time.time > nextFire)
        {
            Shoot();
        }
    }
}
