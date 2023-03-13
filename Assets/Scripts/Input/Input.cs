using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Input : MonoBehaviour
{
    private static IInput input;

    private void Awake() {
/*#if VIRTUAL_INPUT
        input = new VirtualInput();
#else 
        input = new BaseInput();
#endif*/
        input = new BaseInput();
    }

    internal static Vector3 GetMousePosition() => input.GetMousePosition();
    internal static Vector3 GetMouseScrollDelta() => input.GetMouseScrollDelta();

    internal static float GetAxis(string v) => input.GetAxis(v);
    internal static bool GetMouseButton(int v) => input.GetMouseButton(v);
    internal static bool GetMouseButtonDown(int v) => input.GetMouseButtonDown(v);
    internal static bool GetMouseButtonUp(int v) => input.GetMouseButtonUp(v);
    internal static bool GetKey(KeyCode v) => input.GetKey(v);
    internal static bool GetKeyDown(KeyCode v) => input.GetKeyDown(v);
}

public class BaseInput : IInput
{
    Vector3 IInput.GetMousePosition() => UnityEngine.Input.mousePosition;
    Vector3 IInput.GetMouseScrollDelta() => UnityEngine.Input.mouseScrollDelta;

    float IInput.GetAxis(string v) => UnityEngine.Input.GetAxis(v);

    bool IInput.GetMouseButton(int v) => UnityEngine.Input.GetMouseButton(v);
    bool IInput.GetMouseButtonDown(int v) => UnityEngine.Input.GetMouseButtonDown(v);
    bool IInput.GetMouseButtonUp(int v) => UnityEngine.Input.GetMouseButtonUp(v);
    bool IInput.GetKey(KeyCode v) => UnityEngine.Input.GetKey(v);
    bool IInput.GetKeyDown(KeyCode v) => UnityEngine.Input.GetKeyDown(v);
}

#if VIRTUAL_INPUT
public class VirtualInput : IInput
{
    Vector3 IInput.GetMousePosition() => UnityEngine.Input.mousePosition;
    Vector3 IInput.GetMouseScrollDelta() => UnityEngine.Input.mouseScrollDelta;

    float IInput.GetAxis(string v) => -1;

    bool IInput.GetMouseButton(int v) => UnityEngine.Input.GetMouseButton(v);
    bool IInput.GetMouseButtonDown(int v) => UnityEngine.Input.GetMouseButtonDown(v);
    bool IInput.GetMouseButtonUp(int v) => UnityEngine.Input.GetMouseButtonUp(v);
    bool IInput.GetKey(KeyCode v) => UnityEngine.Input.GetKey(v);
    bool IInput.GetKeyDown(KeyCode v) => UnityEngine.Input.GetKeyDown(v);
}
#endif

public interface IInput
{
    internal Vector3 GetMousePosition();
    internal Vector3 GetMouseScrollDelta();
    internal float GetAxis(string v);
    internal bool GetMouseButton(int v);
    internal bool GetMouseButtonDown(int v);
    internal bool GetMouseButtonUp(int v);
    internal bool GetKey(KeyCode v);
    internal bool GetKeyDown(KeyCode v);
}
