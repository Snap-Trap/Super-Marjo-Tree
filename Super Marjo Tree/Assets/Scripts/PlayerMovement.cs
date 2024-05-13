using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;

    public Vector2 MoveDirection;

    public InputAction PlayerControls;

    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void OnEnable()
    {
        PlayerControls.Enable();
    }

    void OnDisable()
    {
        PlayerControls.Disable();
    }

    void Update()
    {
        MoveDirection = PlayerControls.ReadValue<Vector2>();

        rb.velocity = new Vector2(MoveDirection.x * speed, MoveDirection.y * speed);
    }
}
