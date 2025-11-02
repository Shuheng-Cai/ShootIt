// ==================================================
// Module: PlayerController
// Purpose: Control Player to Move
// Author: Shuheng
// Date: 2025/10/11
// Dependencies: None
// ==================================================

using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed; //move speed
    public Rigidbody2D rb;  //Get the rigidbody to control moving
    public Vector2 moveInput;
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
