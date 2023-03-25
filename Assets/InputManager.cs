using UnityEngine;

public class InputManager : MonoBehaviour
{
    private InputActions _inputs;

    private void Awake()
    {
        _inputs = new InputActions();
    }

    private void OnEnable()
    {
        var playerController = FindObjectOfType<PlayerController>();
        if (playerController == null) return;

        _inputs.Character.MoveJoystick.performed += moveValue =>
        {
            playerController.MovementValue = moveValue.ReadValue<Vector2>();
        };
        _inputs.Character.MoveJoystick.canceled += moveValue =>
        {
            playerController.MovementValue = moveValue.ReadValue<Vector2>();
        };
        _inputs.Character.Move.performed += moveValue =>
        {
            playerController.MovementValue = moveValue.ReadValue<Vector3>();
        };
        _inputs.Character.Jump.performed += jumpValue =>
        {
            playerController.IsJumping = jumpValue.ReadValueAsButton();
        };
        _inputs.Character.Sprint.performed += sprintValue =>
        {
            playerController.IsSprinting = sprintValue.ReadValueAsButton();
        };
        
        _inputs.Enable();
    }

    private void OnDisable()
    {
        _inputs.Disable();
    }
}
