// Module: StateFactory
// Purpose: Control player's move.
// Invariants: rb, moveInput
// Performance: 
// Dependencies: when update, the moveSpeed will upgrade; the basic speed is 10;
// Known Tricky Cases: 

using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed; //move speed
    public Rigidbody2D rb;  //Get the rigidbody to control moving
    private Vector2 moveInput;
    private PlayerInput playerInput;

    void Start()
    {
        rb = transform.GetComponent<Rigidbody2D>();
        playerInput = GetComponent<PlayerInput>();
    }

    void Update()
    {
        moveInput = playerInput.actions["Move"].ReadValue<Vector2>();
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + moveInput * moveSpeed * Time.fixedDeltaTime); // realize moving
    }
}
