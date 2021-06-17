// GENERATED AUTOMATICALLY FROM 'Assets/Prefabs/Controls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @Controls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @Controls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Controls"",
    ""maps"": [
        {
            ""name"": ""Main"",
            ""id"": ""4b2ebd25-f4f2-46d6-bb94-9a9d6d8699ad"",
            ""actions"": [
                {
                    ""name"": ""Spawn"",
                    ""type"": ""Button"",
                    ""id"": ""0dbf2550-4f29-4a15-8360-ca7c93f9eab9"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Destruction"",
                    ""type"": ""Button"",
                    ""id"": ""8708bbfc-eb8a-4b66-a2cd-a85770d4c353"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""9b4ed74b-00d2-4813-8396-ae5c041c0550"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Spawn"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a5e2a562-1f15-43d5-887b-c15b6fd263cd"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Destruction"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Main
        m_Main = asset.FindActionMap("Main", throwIfNotFound: true);
        m_Main_Spawn = m_Main.FindAction("Spawn", throwIfNotFound: true);
        m_Main_Destruction = m_Main.FindAction("Destruction", throwIfNotFound: true);
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

    // Main
    private readonly InputActionMap m_Main;
    private IMainActions m_MainActionsCallbackInterface;
    private readonly InputAction m_Main_Spawn;
    private readonly InputAction m_Main_Destruction;
    public struct MainActions
    {
        private @Controls m_Wrapper;
        public MainActions(@Controls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Spawn => m_Wrapper.m_Main_Spawn;
        public InputAction @Destruction => m_Wrapper.m_Main_Destruction;
        public InputActionMap Get() { return m_Wrapper.m_Main; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MainActions set) { return set.Get(); }
        public void SetCallbacks(IMainActions instance)
        {
            if (m_Wrapper.m_MainActionsCallbackInterface != null)
            {
                @Spawn.started -= m_Wrapper.m_MainActionsCallbackInterface.OnSpawn;
                @Spawn.performed -= m_Wrapper.m_MainActionsCallbackInterface.OnSpawn;
                @Spawn.canceled -= m_Wrapper.m_MainActionsCallbackInterface.OnSpawn;
                @Destruction.started -= m_Wrapper.m_MainActionsCallbackInterface.OnDestruction;
                @Destruction.performed -= m_Wrapper.m_MainActionsCallbackInterface.OnDestruction;
                @Destruction.canceled -= m_Wrapper.m_MainActionsCallbackInterface.OnDestruction;
            }
            m_Wrapper.m_MainActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Spawn.started += instance.OnSpawn;
                @Spawn.performed += instance.OnSpawn;
                @Spawn.canceled += instance.OnSpawn;
                @Destruction.started += instance.OnDestruction;
                @Destruction.performed += instance.OnDestruction;
                @Destruction.canceled += instance.OnDestruction;
            }
        }
    }
    public MainActions @Main => new MainActions(this);
    public interface IMainActions
    {
        void OnSpawn(InputAction.CallbackContext context);
        void OnDestruction(InputAction.CallbackContext context);
    }
}
