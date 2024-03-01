using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager
{
    private PlayerControls playerControls;

    public event Action OnJump;

    public Vector2 MoveDirection => playerControls.Movement.Move.ReadValue<Vector2>();
    
    public InputManager()
    {
        playerControls = new PlayerControls();
        playerControls.Enable();
        playerControls.Movement.Jump.performed += OnJumpPerfomed;
    }

    private void OnJumpPerfomed(InputAction.CallbackContext context)
    {
        OnJump?.Invoke();
    }
}
