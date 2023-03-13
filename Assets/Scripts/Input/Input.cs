using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Input : MonoBehaviour
{
    private static IInput input;

    private void Awake() {
        input = new BaseInput();
    }

    internal static Vector3 GetMousePosition() => input.GetMousePosition();
    internal static Vector3 GetMouseScrollDelta() => input.GetMouseScrollDelta();

    internal static Vector3 GetAxis() => input.GetAxis();
    internal static bool GetKey(KeyCode v) => input.GetKey(v);
    internal static bool GetKeyDown(KeyCode v) => input.GetKeyDown(v);
}

public class BaseInput : IInput
{
    private InputActions inputAction;
    public BaseInput() {
        inputAction = new InputActions();
    }
    
    Vector3 IInput.GetMousePosition() => inputAction.Inputs.GetMousePosition.ReadValue<Vector3>();
    Vector3 IInput.GetMouseScrollDelta() => inputAction.Inputs.GetMouseScrollDelta.ReadValue<Vector3>();
    Vector3 IInput.GetAxis() => inputAction.Inputs.GetAxis.ReadValue<Vector3>();
    bool IInput.GetKey(KeyCode v) {
        inputAction.Inputs.GetKey.ChangeBindingWithPath(v.ToString());
        return inputAction.Inputs.GetKey.WasPressedThisFrame();
    }

    bool IInput.GetKeyDown(KeyCode v) {
        inputAction.Inputs.GetKey.ChangeBindingWithPath(v.ToString());
        return inputAction.Inputs.GetKey.IsPressed();
    }
}

public interface IInput
{
    internal Vector3 GetMousePosition();
    internal Vector3 GetMouseScrollDelta();
    internal Vector3 GetAxis();
    internal bool GetKey(KeyCode v);
    internal bool GetKeyDown(KeyCode v);
}
