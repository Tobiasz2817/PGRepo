//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.4.4
//     from Assets/Scripts/Input/InputActions.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @InputActions : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @InputActions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputActions"",
    ""maps"": [
        {
            ""name"": ""Inputs"",
            ""id"": ""1e15053f-1117-4f0f-908a-abb3a8f7a7fc"",
            ""actions"": [
                {
                    ""name"": ""GetKey"",
                    ""type"": ""Button"",
                    ""id"": ""92b53854-061f-4782-b80d-3b3f1839d0c4"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""GetMouseScrollDelta"",
                    ""type"": ""Value"",
                    ""id"": ""001092c6-0fa4-4618-a862-69e319c66580"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""GetMousePosition"",
                    ""type"": ""Value"",
                    ""id"": ""5eb1a83b-c1ab-43d5-961c-ceacbebedc1d"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""GetAxis"",
                    ""type"": ""Value"",
                    ""id"": ""1b200f99-c8c2-471e-ad2f-eb554f21de72"",
                    ""expectedControlType"": ""Vector3"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""458933d3-d229-4496-931e-1caf7d689550"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""GetKey"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""58644263-8b61-4930-9cda-b159c9cb993a"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""GetMouseScrollDelta"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""cbfa7d76-1cd3-47ae-bcf0-a0e80ee4158b"",
                    ""path"": ""<Mouse>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""GetMousePosition"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""3D Vector"",
                    ""id"": ""149e84c4-7551-4a48-bb1a-bb3ca83e317f"",
                    ""path"": ""3DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""GetAxis"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""f46f1eb6-4795-49a7-b89f-1d39a7cc4804"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""GetAxis"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""55849841-82f2-4f82-ac2d-60d9a3334df2"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""GetAxis"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""b5a8445d-def2-4518-b136-7e25907f6801"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""GetAxis"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""forward"",
                    ""id"": ""cb95c1ef-4d02-44b9-b8f7-dab7f915be41"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""GetAxis"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""backward"",
                    ""id"": ""69820ecb-10e3-43bc-bfd9-edad54eced50"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""GetAxis"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        },
        {
            ""name"": ""Character"",
            ""id"": ""ef6da352-e999-4e37-a073-ac17d86a41d9"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""eed5d542-0f4f-4099-8e6f-151177d3929a"",
                    ""expectedControlType"": ""Vector3"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""a245b25a-6a57-46f2-b6be-d46691922070"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Sprint"",
                    ""type"": ""Button"",
                    ""id"": ""9715ebfd-beec-46f7-9d2f-1f7271dad690"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""MoveJoystick"",
                    ""type"": ""Value"",
                    ""id"": ""2f9743fe-711a-43e9-b177-c3f31abef372"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""LookJoystick"",
                    ""type"": ""Value"",
                    ""id"": ""7a63afc9-a9ff-4ed5-ba4e-4b506e06133a"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""3D Vector Movement"",
                    ""id"": ""d0dc1be0-c490-4c8c-a1b0-76f3a71b1f27"",
                    ""path"": ""3DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""fbf5f2c7-8470-4920-bab5-c7cdb5b7b193"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""a4a0bea2-1f0a-4746-912e-4c285e82f6bd"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""12fb33cc-3ff9-4ddf-831a-cf1b1240b80c"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""2bd349c3-e661-44bc-bc81-53c8109e6355"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""69cc2564-e18d-4e87-9b99-43c9a242f3e1"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0a62f4b6-b548-4e20-8cf1-9092e740feb5"",
                    ""path"": ""<Keyboard>/shift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Sprint"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1b62e88e-b3ec-40ec-a457-7ef11a4e0085"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveJoystick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a9391233-a809-41f8-bb83-e33d61368697"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LookJoystick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Inputs
        m_Inputs = asset.FindActionMap("Inputs", throwIfNotFound: true);
        m_Inputs_GetKey = m_Inputs.FindAction("GetKey", throwIfNotFound: true);
        m_Inputs_GetMouseScrollDelta = m_Inputs.FindAction("GetMouseScrollDelta", throwIfNotFound: true);
        m_Inputs_GetMousePosition = m_Inputs.FindAction("GetMousePosition", throwIfNotFound: true);
        m_Inputs_GetAxis = m_Inputs.FindAction("GetAxis", throwIfNotFound: true);
        // Character
        m_Character = asset.FindActionMap("Character", throwIfNotFound: true);
        m_Character_Move = m_Character.FindAction("Move", throwIfNotFound: true);
        m_Character_Jump = m_Character.FindAction("Jump", throwIfNotFound: true);
        m_Character_Sprint = m_Character.FindAction("Sprint", throwIfNotFound: true);
        m_Character_MoveJoystick = m_Character.FindAction("MoveJoystick", throwIfNotFound: true);
        m_Character_LookJoystick = m_Character.FindAction("LookJoystick", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }
    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }
    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // Inputs
    private readonly InputActionMap m_Inputs;
    private IInputsActions m_InputsActionsCallbackInterface;
    private readonly InputAction m_Inputs_GetKey;
    private readonly InputAction m_Inputs_GetMouseScrollDelta;
    private readonly InputAction m_Inputs_GetMousePosition;
    private readonly InputAction m_Inputs_GetAxis;
    public struct InputsActions
    {
        private @InputActions m_Wrapper;
        public InputsActions(@InputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @GetKey => m_Wrapper.m_Inputs_GetKey;
        public InputAction @GetMouseScrollDelta => m_Wrapper.m_Inputs_GetMouseScrollDelta;
        public InputAction @GetMousePosition => m_Wrapper.m_Inputs_GetMousePosition;
        public InputAction @GetAxis => m_Wrapper.m_Inputs_GetAxis;
        public InputActionMap Get() { return m_Wrapper.m_Inputs; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(InputsActions set) { return set.Get(); }
        public void SetCallbacks(IInputsActions instance)
        {
            if (m_Wrapper.m_InputsActionsCallbackInterface != null)
            {
                @GetKey.started -= m_Wrapper.m_InputsActionsCallbackInterface.OnGetKey;
                @GetKey.performed -= m_Wrapper.m_InputsActionsCallbackInterface.OnGetKey;
                @GetKey.canceled -= m_Wrapper.m_InputsActionsCallbackInterface.OnGetKey;
                @GetMouseScrollDelta.started -= m_Wrapper.m_InputsActionsCallbackInterface.OnGetMouseScrollDelta;
                @GetMouseScrollDelta.performed -= m_Wrapper.m_InputsActionsCallbackInterface.OnGetMouseScrollDelta;
                @GetMouseScrollDelta.canceled -= m_Wrapper.m_InputsActionsCallbackInterface.OnGetMouseScrollDelta;
                @GetMousePosition.started -= m_Wrapper.m_InputsActionsCallbackInterface.OnGetMousePosition;
                @GetMousePosition.performed -= m_Wrapper.m_InputsActionsCallbackInterface.OnGetMousePosition;
                @GetMousePosition.canceled -= m_Wrapper.m_InputsActionsCallbackInterface.OnGetMousePosition;
                @GetAxis.started -= m_Wrapper.m_InputsActionsCallbackInterface.OnGetAxis;
                @GetAxis.performed -= m_Wrapper.m_InputsActionsCallbackInterface.OnGetAxis;
                @GetAxis.canceled -= m_Wrapper.m_InputsActionsCallbackInterface.OnGetAxis;
            }
            m_Wrapper.m_InputsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @GetKey.started += instance.OnGetKey;
                @GetKey.performed += instance.OnGetKey;
                @GetKey.canceled += instance.OnGetKey;
                @GetMouseScrollDelta.started += instance.OnGetMouseScrollDelta;
                @GetMouseScrollDelta.performed += instance.OnGetMouseScrollDelta;
                @GetMouseScrollDelta.canceled += instance.OnGetMouseScrollDelta;
                @GetMousePosition.started += instance.OnGetMousePosition;
                @GetMousePosition.performed += instance.OnGetMousePosition;
                @GetMousePosition.canceled += instance.OnGetMousePosition;
                @GetAxis.started += instance.OnGetAxis;
                @GetAxis.performed += instance.OnGetAxis;
                @GetAxis.canceled += instance.OnGetAxis;
            }
        }
    }
    public InputsActions @Inputs => new InputsActions(this);

    // Character
    private readonly InputActionMap m_Character;
    private ICharacterActions m_CharacterActionsCallbackInterface;
    private readonly InputAction m_Character_Move;
    private readonly InputAction m_Character_Jump;
    private readonly InputAction m_Character_Sprint;
    private readonly InputAction m_Character_MoveJoystick;
    private readonly InputAction m_Character_LookJoystick;
    public struct CharacterActions
    {
        private @InputActions m_Wrapper;
        public CharacterActions(@InputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_Character_Move;
        public InputAction @Jump => m_Wrapper.m_Character_Jump;
        public InputAction @Sprint => m_Wrapper.m_Character_Sprint;
        public InputAction @MoveJoystick => m_Wrapper.m_Character_MoveJoystick;
        public InputAction @LookJoystick => m_Wrapper.m_Character_LookJoystick;
        public InputActionMap Get() { return m_Wrapper.m_Character; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(CharacterActions set) { return set.Get(); }
        public void SetCallbacks(ICharacterActions instance)
        {
            if (m_Wrapper.m_CharacterActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_CharacterActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_CharacterActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_CharacterActionsCallbackInterface.OnMove;
                @Jump.started -= m_Wrapper.m_CharacterActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_CharacterActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_CharacterActionsCallbackInterface.OnJump;
                @Sprint.started -= m_Wrapper.m_CharacterActionsCallbackInterface.OnSprint;
                @Sprint.performed -= m_Wrapper.m_CharacterActionsCallbackInterface.OnSprint;
                @Sprint.canceled -= m_Wrapper.m_CharacterActionsCallbackInterface.OnSprint;
                @MoveJoystick.started -= m_Wrapper.m_CharacterActionsCallbackInterface.OnMoveJoystick;
                @MoveJoystick.performed -= m_Wrapper.m_CharacterActionsCallbackInterface.OnMoveJoystick;
                @MoveJoystick.canceled -= m_Wrapper.m_CharacterActionsCallbackInterface.OnMoveJoystick;
                @LookJoystick.started -= m_Wrapper.m_CharacterActionsCallbackInterface.OnLookJoystick;
                @LookJoystick.performed -= m_Wrapper.m_CharacterActionsCallbackInterface.OnLookJoystick;
                @LookJoystick.canceled -= m_Wrapper.m_CharacterActionsCallbackInterface.OnLookJoystick;
            }
            m_Wrapper.m_CharacterActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @Sprint.started += instance.OnSprint;
                @Sprint.performed += instance.OnSprint;
                @Sprint.canceled += instance.OnSprint;
                @MoveJoystick.started += instance.OnMoveJoystick;
                @MoveJoystick.performed += instance.OnMoveJoystick;
                @MoveJoystick.canceled += instance.OnMoveJoystick;
                @LookJoystick.started += instance.OnLookJoystick;
                @LookJoystick.performed += instance.OnLookJoystick;
                @LookJoystick.canceled += instance.OnLookJoystick;
            }
        }
    }
    public CharacterActions @Character => new CharacterActions(this);
    public interface IInputsActions
    {
        void OnGetKey(InputAction.CallbackContext context);
        void OnGetMouseScrollDelta(InputAction.CallbackContext context);
        void OnGetMousePosition(InputAction.CallbackContext context);
        void OnGetAxis(InputAction.CallbackContext context);
    }
    public interface ICharacterActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnSprint(InputAction.CallbackContext context);
        void OnMoveJoystick(InputAction.CallbackContext context);
        void OnLookJoystick(InputAction.CallbackContext context);
    }
}
