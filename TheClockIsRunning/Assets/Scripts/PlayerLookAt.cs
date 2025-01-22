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

    public GameObject player;
    [SerializeField] private GameObject weapon;
    private IShooting weaponScript;
    public UnityEngine.Transform spawnPoint;

    public Camera cam;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (weapon != null)
        {
            weaponScript = weapon.GetComponent<IShooting>();
        }

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

        if (shootAction.ReadValue<float>() > 0.5 && weapon != null)
        {
            weaponScript.Shoot(spawnPoint);
        }
    }
}
