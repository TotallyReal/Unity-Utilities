//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.7.0
//     from Assets/MouseControl/Runtime/MouseInput/DefaultMouseInput.inputactions
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

public partial class @DefaultMouseInput: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @DefaultMouseInput()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""DefaultMouseInput"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""cd73c20d-af1b-4a70-9f76-4d462e16c018"",
            ""actions"": [
                {
                    ""name"": ""PointerSelect"",
                    ""type"": ""Button"",
                    ""id"": ""079d8a8c-9a6b-4352-b1a9-114ed1036b13"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""PointerPosition"",
                    ""type"": ""Value"",
                    ""id"": ""2f0824e4-aacd-411d-958a-2e9e8be9474d"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""AlternativePointerSelect"",
                    ""type"": ""Button"",
                    ""id"": ""6a8f8879-df49-4bfe-8a90-462c2d90a5ce"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""e9c2c756-d716-4ffe-8065-09d18daeb75e"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PointerSelect"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3f9a32e0-d935-4e9c-9e2f-e250e95ec1e1"",
                    ""path"": ""<Mouse>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PointerPosition"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7dbffe26-6c30-4739-aa81-73603e3082ab"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""AlternativePointerSelect"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Player
        m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
        m_Player_PointerSelect = m_Player.FindAction("PointerSelect", throwIfNotFound: true);
        m_Player_PointerPosition = m_Player.FindAction("PointerPosition", throwIfNotFound: true);
        m_Player_AlternativePointerSelect = m_Player.FindAction("AlternativePointerSelect", throwIfNotFound: true);
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

    // Player
    private readonly InputActionMap m_Player;
    private List<IPlayerActions> m_PlayerActionsCallbackInterfaces = new List<IPlayerActions>();
    private readonly InputAction m_Player_PointerSelect;
    private readonly InputAction m_Player_PointerPosition;
    private readonly InputAction m_Player_AlternativePointerSelect;
    public struct PlayerActions
    {
        private @DefaultMouseInput m_Wrapper;
        public PlayerActions(@DefaultMouseInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @PointerSelect => m_Wrapper.m_Player_PointerSelect;
        public InputAction @PointerPosition => m_Wrapper.m_Player_PointerPosition;
        public InputAction @AlternativePointerSelect => m_Wrapper.m_Player_AlternativePointerSelect;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void AddCallbacks(IPlayerActions instance)
        {
            if (instance == null || m_Wrapper.m_PlayerActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_PlayerActionsCallbackInterfaces.Add(instance);
            @PointerSelect.started += instance.OnPointerSelect;
            @PointerSelect.performed += instance.OnPointerSelect;
            @PointerSelect.canceled += instance.OnPointerSelect;
            @PointerPosition.started += instance.OnPointerPosition;
            @PointerPosition.performed += instance.OnPointerPosition;
            @PointerPosition.canceled += instance.OnPointerPosition;
            @AlternativePointerSelect.started += instance.OnAlternativePointerSelect;
            @AlternativePointerSelect.performed += instance.OnAlternativePointerSelect;
            @AlternativePointerSelect.canceled += instance.OnAlternativePointerSelect;
        }

        private void UnregisterCallbacks(IPlayerActions instance)
        {
            @PointerSelect.started -= instance.OnPointerSelect;
            @PointerSelect.performed -= instance.OnPointerSelect;
            @PointerSelect.canceled -= instance.OnPointerSelect;
            @PointerPosition.started -= instance.OnPointerPosition;
            @PointerPosition.performed -= instance.OnPointerPosition;
            @PointerPosition.canceled -= instance.OnPointerPosition;
            @AlternativePointerSelect.started -= instance.OnAlternativePointerSelect;
            @AlternativePointerSelect.performed -= instance.OnAlternativePointerSelect;
            @AlternativePointerSelect.canceled -= instance.OnAlternativePointerSelect;
        }

        public void RemoveCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IPlayerActions instance)
        {
            foreach (var item in m_Wrapper.m_PlayerActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_PlayerActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public PlayerActions @Player => new PlayerActions(this);
    public interface IPlayerActions
    {
        void OnPointerSelect(InputAction.CallbackContext context);
        void OnPointerPosition(InputAction.CallbackContext context);
        void OnAlternativePointerSelect(InputAction.CallbackContext context);
    }
}
