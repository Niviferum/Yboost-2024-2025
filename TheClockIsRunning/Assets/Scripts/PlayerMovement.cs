using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;

public class PlayerMovement : MonoBehaviour
{
    private Vector2 playerMovement;
    private InputAction moveAction;
    private float playerSpeed = 5f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        moveAction = InputSystem.actions.FindAction("Move");
    }

    // Update is called once per frame
    void Update()
    {
        playerMovement = moveAction.ReadValue<Vector2>();
        transform.Translate(playerMovement * Time.deltaTime * playerSpeed);
    }
}
