using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    private Vector2 playerMovement;
    private InputAction moveAction;
    private float playerSpeed = 3f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        moveAction = InputSystem.actions.FindAction("Move");
    }

    // Update is called once per frame
    void Update()
    {
        playerMovement = moveAction.ReadValue<Vector2>();
    }

    private void FixedUpdate()
    {
        transform.position = new Vector2(transform.position.x, transform.position.y) + playerMovement * Time.deltaTime * playerSpeed;
    }
}
