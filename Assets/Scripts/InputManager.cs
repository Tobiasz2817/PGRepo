using Cinemachine;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    public InputActions Inputs;

    private void Awake()
    {
        Inputs = new InputActions();
    }

    private void OnEnable()
    {
        var playerController = FindObjectOfType<PlayerController>();
        if (playerController == null) return;

        #if UNITY_ANDROID

        Inputs.Character.MoveJoystick.performed += moveValue =>
        {
            playerController.MovementValue = moveValue.ReadValue<Vector2>();
        };
        Inputs.Character.MoveJoystick.canceled += moveValue => {
            playerController.MovementValue = moveValue.ReadValue<Vector2>();
        };
        
        var cinemachineInputProvider = FindObjectOfType<CinemachineInputProvider>();
        cinemachineInputProvider.AutoEnableInputs = true;
        
        #else
        
        Inputs.Character.Move.performed += moveValue =>
        {
            playerController.MovementValue = moveValue.ReadValue<Vector3>();
        };

        #endif

        Inputs.Character.Jump.performed += jumpValue =>
        {
            playerController.IsJumping = jumpValue.ReadValueAsButton();
        };
        Inputs.Character.Sprint.performed += sprintValue =>
        {
            playerController.IsSprinting = sprintValue.ReadValueAsButton();
        };
        Inputs.Enable();
    }

    private void OnDisable()
    {
        Inputs.Disable();
    }
}
