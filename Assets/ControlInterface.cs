//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.6.1
//     from Assets/ControlInterface.inputactions
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

public partial class @ControlInterface: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @ControlInterface()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""ControlInterface"",
    ""maps"": [
        {
            ""name"": ""miner"",
            ""id"": ""8ea07afa-b959-4899-af88-c031f2b4d540"",
            ""actions"": [
                {
                    ""name"": ""mouseClick"",
                    ""type"": ""Button"",
                    ""id"": ""df0ab721-73ff-4bd0-8654-0b49f71ba898"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""mousePosition"",
                    ""type"": ""Value"",
                    ""id"": ""8cb8b02a-cce6-4e1c-8c32-1a5b18695329"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""wasd"",
                    ""type"": ""Value"",
                    ""id"": ""60ac85bc-7c2f-4f19-ab88-b7925f476d7d"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""miningDirection"",
                    ""type"": ""Value"",
                    ""id"": ""09eb758d-9a9b-4167-8b64-f84c071987cc"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""enteract"",
                    ""type"": ""Button"",
                    ""id"": ""fb18bc37-1f30-438f-be48-7ba09f15631b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""650dc5e7-9ed8-46b0-88e3-cf280b49e55b"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""mouseClick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""73c58ccd-befa-426c-a080-28daf43448fc"",
                    ""path"": ""<Mouse>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""mousePosition"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""keyboard"",
                    ""id"": ""a635b350-af05-4d67-8fe4-660b3c90f38d"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""wasd"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""4299a56b-3804-44a2-8863-7487f36e2255"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""wasd"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""3374bee2-4e65-458d-9209-8448de15d083"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""wasd"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""5effbd4b-bc99-4e7b-9d17-1a4ca9215cc2"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""wasd"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""1d130456-d480-45c7-b836-0d6b044db04b"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""wasd"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""61a9e44d-f353-474a-bbb0-4c0fd7ccc445"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""miningDirection"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""e2b5626f-21e7-435e-b21c-ade06de3bb00"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""miningDirection"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""1e4510f5-81f4-4231-a3e9-ee1377e37392"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""miningDirection"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""47cd5bcb-e5cc-4597-b766-df751a9d8eca"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""miningDirection"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""dc868d6f-18ab-4177-b76d-d58719660995"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""miningDirection"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""a0f04a38-8e69-47e4-ba4d-76ec55fe6fab"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""enteract"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // miner
        m_miner = asset.FindActionMap("miner", throwIfNotFound: true);
        m_miner_mouseClick = m_miner.FindAction("mouseClick", throwIfNotFound: true);
        m_miner_mousePosition = m_miner.FindAction("mousePosition", throwIfNotFound: true);
        m_miner_wasd = m_miner.FindAction("wasd", throwIfNotFound: true);
        m_miner_miningDirection = m_miner.FindAction("miningDirection", throwIfNotFound: true);
        m_miner_enteract = m_miner.FindAction("enteract", throwIfNotFound: true);
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

    // miner
    private readonly InputActionMap m_miner;
    private List<IMinerActions> m_MinerActionsCallbackInterfaces = new List<IMinerActions>();
    private readonly InputAction m_miner_mouseClick;
    private readonly InputAction m_miner_mousePosition;
    private readonly InputAction m_miner_wasd;
    private readonly InputAction m_miner_miningDirection;
    private readonly InputAction m_miner_enteract;
    public struct MinerActions
    {
        private @ControlInterface m_Wrapper;
        public MinerActions(@ControlInterface wrapper) { m_Wrapper = wrapper; }
        public InputAction @mouseClick => m_Wrapper.m_miner_mouseClick;
        public InputAction @mousePosition => m_Wrapper.m_miner_mousePosition;
        public InputAction @wasd => m_Wrapper.m_miner_wasd;
        public InputAction @miningDirection => m_Wrapper.m_miner_miningDirection;
        public InputAction @enteract => m_Wrapper.m_miner_enteract;
        public InputActionMap Get() { return m_Wrapper.m_miner; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MinerActions set) { return set.Get(); }
        public void AddCallbacks(IMinerActions instance)
        {
            if (instance == null || m_Wrapper.m_MinerActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_MinerActionsCallbackInterfaces.Add(instance);
            @mouseClick.started += instance.OnMouseClick;
            @mouseClick.performed += instance.OnMouseClick;
            @mouseClick.canceled += instance.OnMouseClick;
            @mousePosition.started += instance.OnMousePosition;
            @mousePosition.performed += instance.OnMousePosition;
            @mousePosition.canceled += instance.OnMousePosition;
            @wasd.started += instance.OnWasd;
            @wasd.performed += instance.OnWasd;
            @wasd.canceled += instance.OnWasd;
            @miningDirection.started += instance.OnMiningDirection;
            @miningDirection.performed += instance.OnMiningDirection;
            @miningDirection.canceled += instance.OnMiningDirection;
            @enteract.started += instance.OnEnteract;
            @enteract.performed += instance.OnEnteract;
            @enteract.canceled += instance.OnEnteract;
        }

        private void UnregisterCallbacks(IMinerActions instance)
        {
            @mouseClick.started -= instance.OnMouseClick;
            @mouseClick.performed -= instance.OnMouseClick;
            @mouseClick.canceled -= instance.OnMouseClick;
            @mousePosition.started -= instance.OnMousePosition;
            @mousePosition.performed -= instance.OnMousePosition;
            @mousePosition.canceled -= instance.OnMousePosition;
            @wasd.started -= instance.OnWasd;
            @wasd.performed -= instance.OnWasd;
            @wasd.canceled -= instance.OnWasd;
            @miningDirection.started -= instance.OnMiningDirection;
            @miningDirection.performed -= instance.OnMiningDirection;
            @miningDirection.canceled -= instance.OnMiningDirection;
            @enteract.started -= instance.OnEnteract;
            @enteract.performed -= instance.OnEnteract;
            @enteract.canceled -= instance.OnEnteract;
        }

        public void RemoveCallbacks(IMinerActions instance)
        {
            if (m_Wrapper.m_MinerActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IMinerActions instance)
        {
            foreach (var item in m_Wrapper.m_MinerActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_MinerActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public MinerActions @miner => new MinerActions(this);
    public interface IMinerActions
    {
        void OnMouseClick(InputAction.CallbackContext context);
        void OnMousePosition(InputAction.CallbackContext context);
        void OnWasd(InputAction.CallbackContext context);
        void OnMiningDirection(InputAction.CallbackContext context);
        void OnEnteract(InputAction.CallbackContext context);
    }
}
