using System;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerLookAt : MonoBehaviour
{
    InputAction lookAction;
    private Vector2 weaponLook;
    public GameObject player;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        lookAction = InputSystem.actions.FindAction("Look");
    }

    // Update is called once per frame
    void Update()
    {
        weaponLook = lookAction.ReadValue<Vector2>();
        Debug.Log(weaponLook);
        transform.rotation = Quaternion.LookRotation(Vector3.forward, player.transform.position - new Vector3(weaponLook.x, weaponLook.y, 0));
    }
}
