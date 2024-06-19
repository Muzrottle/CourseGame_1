//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.7.0
//     from Assets/GameFolders/Scripts/Concretes/Inputs/DefaultAction.inputactions
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

namespace CourseGame_1.Inputs
{
    public partial class @DefaultAction: IInputActionCollection2, IDisposable
    {
        public InputActionAsset asset { get; }
        public @DefaultAction()
        {
            asset = InputActionAsset.FromJson(@"{
    ""name"": ""DefaultAction"",
    ""maps"": [
        {
            ""name"": ""Rocket"",
            ""id"": ""ae4496d5-cfd9-4b10-b6b3-f33402a444dd"",
            ""actions"": [
                {
                    ""name"": ""ForceUp"",
                    ""type"": ""PassThrough"",
                    ""id"": ""327f36fb-9e6e-494f-bdb6-e83a38818044"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""ba00951e-28c3-426c-ac15-a6ab79f8bcf6"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ForceUp"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
            // Rocket
            m_Rocket = asset.FindActionMap("Rocket", throwIfNotFound: true);
            m_Rocket_ForceUp = m_Rocket.FindAction("ForceUp", throwIfNotFound: true);
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

        // Rocket
        private readonly InputActionMap m_Rocket;
        private List<IRocketActions> m_RocketActionsCallbackInterfaces = new List<IRocketActions>();
        private readonly InputAction m_Rocket_ForceUp;
        public struct RocketActions
        {
            private @DefaultAction m_Wrapper;
            public RocketActions(@DefaultAction wrapper) { m_Wrapper = wrapper; }
            public InputAction @ForceUp => m_Wrapper.m_Rocket_ForceUp;
            public InputActionMap Get() { return m_Wrapper.m_Rocket; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(RocketActions set) { return set.Get(); }
            public void AddCallbacks(IRocketActions instance)
            {
                if (instance == null || m_Wrapper.m_RocketActionsCallbackInterfaces.Contains(instance)) return;
                m_Wrapper.m_RocketActionsCallbackInterfaces.Add(instance);
                @ForceUp.started += instance.OnForceUp;
                @ForceUp.performed += instance.OnForceUp;
                @ForceUp.canceled += instance.OnForceUp;
            }

            private void UnregisterCallbacks(IRocketActions instance)
            {
                @ForceUp.started -= instance.OnForceUp;
                @ForceUp.performed -= instance.OnForceUp;
                @ForceUp.canceled -= instance.OnForceUp;
            }

            public void RemoveCallbacks(IRocketActions instance)
            {
                if (m_Wrapper.m_RocketActionsCallbackInterfaces.Remove(instance))
                    UnregisterCallbacks(instance);
            }

            public void SetCallbacks(IRocketActions instance)
            {
                foreach (var item in m_Wrapper.m_RocketActionsCallbackInterfaces)
                    UnregisterCallbacks(item);
                m_Wrapper.m_RocketActionsCallbackInterfaces.Clear();
                AddCallbacks(instance);
            }
        }
        public RocketActions @Rocket => new RocketActions(this);
        public interface IRocketActions
        {
            void OnForceUp(InputAction.CallbackContext context);
        }
    }
}
