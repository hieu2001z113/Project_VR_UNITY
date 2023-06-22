using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    private InputAction movementAction;
    private Vector2 movementInput;
    public float speed = 5f;
    private void Awake()
    {
        movementAction = new InputAction("PlayerMovement", binding: "<Gamepad>/leftStick");
        movementAction.performed += OnMovementPerformed;
        movementAction.canceled += OnMovementCanceled;
    }

    private void OnEnable()
    {
        movementAction.Enable();
    }

    private void OnDisable()
    {
        movementAction.Disable();
    }

    private void OnMovementPerformed(InputAction.CallbackContext context)
    {
        movementInput = context.ReadValue<Vector2>();
    }

    private void OnMovementCanceled(InputAction.CallbackContext context)
    {
        movementInput = Vector2.zero;
    }

    private void Update()
    {
        Vector3 movement = new Vector3(movementInput.x, 0f, movementInput.y);
        Vector3 moveDelta = movement * speed * Time.deltaTime;
        transform.Translate(moveDelta);
    }
}


