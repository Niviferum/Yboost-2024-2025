using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerLookAt : MonoBehaviour
{
    InputAction lookAction;
    InputAction shootAction;

    private Vector2 lookDir;
    private Vector2 mousePosition;

    public GameObject player;
    private GameObject weapon;
    private IShooting weaponScript;
    private UnityEngine.Transform spawnPoint;

    public Camera cam;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {   
        weapon = gameObject.transform.GetChild(0).gameObject;
        
        if (weapon != null)
        {
            spawnPoint = weapon.transform.GetChild(0).transform;
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
