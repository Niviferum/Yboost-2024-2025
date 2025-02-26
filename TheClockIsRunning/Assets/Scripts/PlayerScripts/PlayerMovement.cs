using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;

public class PlayerMovement : MonoBehaviour
{
    private Vector2 playerMovement;
    private InputAction moveAction;
    private float playerSpeed = 5f;
    Vector3 lastPosition;
    SpriteRenderer spriteRenderer;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        moveAction = InputSystem.actions.FindAction("Move");
        lastPosition = transform.position;
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
        
        playerMovement = moveAction.ReadValue<Vector2>();
        Debug.Log(playerMovement.x);
        if (playerMovement.x < 0)
        {
            spriteRenderer.flipX = true;
        }
        else if (playerMovement.x > 0)
        {
            spriteRenderer.flipX = false;
        }
        transform.Translate(playerMovement * Time.deltaTime * playerSpeed);
        lastPosition = transform.position;
    }
}
