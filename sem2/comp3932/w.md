# S
    ## Short Answer

Use **Finite State Machine (FSM)** to describe what you built. Reserve **Deterministic Finite Automaton (DFA)** for theoretical computer science contexts (e.g., compiler design, formal language theory).

---

## Why FSM is Correct for Your Project

| Term    | Best Used For                                                           | Your Project                                                        |
| ------- | ----------------------------------------------------------------------- | ------------------------------------------------------------------- |
| **FSM** | Software engineering, game development, robotics, UI controllers        | ✅ Correct – you built a practical interaction controller            |
| **DFA** | Automata theory, compilers, formal language parsing, string recognition | ❌ Too formal – you aren't recognizing a language or parsing strings |

Your state machine controls object manipulation. It has outputs (moving the liver, logging telemetry). This makes it an **FSM with actions**, not a pure DFA (which only accepts/rejects input strings).

---

## Correct Sentences for Your Dissertation

### Using "Finite State Machine" (Recommended)

> *"The interaction controller was implemented as a **finite state machine (FSM)** with four states: IDLE, TRANSFORMING, SCALING, and CLUTCHED."*

> *"A deterministic **finite state machine** governed the transition between manipulation modes based on hand pinch events and controller inputs."*

> *"To decouple gesture recognition from kinematic execution, the system utilised a modular **finite state machine** that responded to abstract trigger signals from interchangeable hardware providers."*

> *"The FSM ensured that scaling could only occur after a valid grab, preventing unintended model deformations."*

---

### Using "Deterministic Finite Automaton" (Avoid Unless Necessary)

You would only use DFA in a sentence like:

> *"The gesture recognition logic can be modelled as a **deterministic finite automaton** where each hand pose maps to a unique state."*

But this is unnecessarily formal for an HCI/VR project. Stick with FSM.

---

## The Safe Phrase

If you want to emphasise determinism without over‑formalising:

> *"A **deterministic finite state machine** was implemented to ensure unambiguous state transitions."*

This acknowledges determinism while staying in software engineering terminology.

---

## Summary Table

| Phrase                             | Appropriate?    | Example                                                                             |
| ---------------------------------- | --------------- | ----------------------------------------------------------------------------------- |
| Finite state machine (FSM)         | ✅ Yes           | "The FSM transitioned from IDLE to TRANSFORMING when a pinch was detected."         |
| Deterministic finite state machine | ✅ Yes (if true) | "The deterministic FSM guaranteed that each input produced exactly one next state." |
| Finite automaton                   | ⚠️ Rare in HCI   | Only if discussing theoretical recognisers                                          |
| DFA                                | ❌ No            | Too formal; implies language recognition                                            |

---

## Final Recommendation

In your dissertation, always use **Finite State Machine (FSM)**. If you want to highlight determinism, say **deterministic finite state machine**. Reserve DFA for the footnotes or a brief side comment.


# Code

## UnityProject/Assets/_Project/Scripts/Kinematics/

### BaseInteractionProvider.cs

using UnityEngine;

namespace COMP3932.Kinematics
{
    /// <summary>
    /// The abstract mathematical hub for all hardware interactions.
    /// Translates raw hardware inputs into generic spatial deltas for the FSM.
    /// </summary>
    public abstract class BaseInteractionProvider : MonoBehaviour
    {
        [Header("Provider Status")]
        public bool isTrackingValid;

        [Header("Diagnostics")]
        [Tooltip("Enable to print log messages to the Unity Console")]
        public bool isDiagnosticsEnabled = false; // Production default: false to save performance

        // Last Frame memory for Delta math
        protected Vector3 lastPosition;
        protected Quaternion lastRotation;
        protected float lastBimanualDistance;

        #region Abstract Properties & Methods

        /// <summary>
        /// Gets the hardware-specific sensitivity tuning for scaling operations.
        /// </summary>
        public abstract float ScaleSensitivity { get; }

        /// <summary>
        /// Defines the hardware-specific Trigger (e.g., Valid Pinch or Grip Button)
        /// </summary>
        public abstract bool IsInteractionTriggered();

        /// <summary>
        /// Gets the hardware-specific spatial anchor.
        /// </summary>
        public abstract Vector3 GetPinchPosition();

        /// <summary>
        /// Gets the hardware-specific input rotation.
        /// </summary>
        public abstract Quaternion GetInputRotation();

        /// <summary>
        /// Gets the hardware-specific bimanual interaction trigger
        /// (e.g., Two-Handed Pinch or Grip Button).
        /// </summary>
        public abstract bool IsBimanualInteractionTriggered();

        /// <summary>
        /// Gets the hardware-specific bimanual distance in meters.
        /// </summary>
        public abstract float GetBimanualDistance();

        /// <summary>
        /// Gets the hardware-specific discrete scale input
        /// (e.g., Thumbstick Up/Down)
        /// </summary>
        public abstract float GetDiscreteScaleInput();

        /// <summary>
        /// Gets the raw, un-thresholded analog grip or pinch strength (0.0 to 1.0) for precision telemetry.
        /// </summary>
        public abstract float GetRawGripStrength();

        #endregion

        #region Memory Management

        /// <summary>
        /// Updates the internal memory of the last frame's position and rotation.
        /// </summary>
        public void UpdateFrameMemory()
        {
            lastPosition = GetPinchPosition();
            lastRotation = GetInputRotation();
        }

        /// <summary>
        /// Updates the internal memory of the bimanual distance.
        /// </summary>
        public void UpdateBimanualMemory()
        {
            lastBimanualDistance = GetBimanualDistance();
        }

        #endregion

        #region Delta Calculations

        /// <summary>
        /// Calculates the delta position since the last frame.
        /// </summary>
        public Vector3 GetDeltaPosition() => GetPinchPosition() - lastPosition;

        /// <summary>
        /// Calculates the delta rotation since the last frame using quaternion math.
        /// </summary>
        public Quaternion GetDeltaRotation() => GetInputRotation() * Quaternion.Inverse(lastRotation);

        /// <summary>
        /// Calculates the scale multiplier based on the distance change
        /// between two points (e.g., two hands) since the last frame.
        /// </summary>
        public float GetBimanualScaleMultiplier()
        {
            // Prevents divide-by-zero errors on the first frame of a scale
            if (lastBimanualDistance <= 0.001f) return 1f;
            return GetBimanualDistance() / lastBimanualDistance;
        }

        #endregion

        #region Provider Lifecycle

        /// <summary>
        /// Explicitly enables or disables the provider's tracking logic and visual models to save performance.
        /// </summary>
        public virtual void SetProviderActive(bool isActive)
        {
            this.enabled = isActive;
        }

        #endregion
    }
}

### UltraleapInteractionProvider.cs

using UnityEngine;
using Leap;
using COMP3932.Core;

namespace COMP3932.Kinematics
{
    /// <summary>
    /// Condition B Provider: Filters raw Ultraleap infrared data into spatial anchors.
    /// Utilises finger auditing and 'Coyote Time' to reject optical occlusion noise.
    /// </summary>
    public class UltraleapInteractionProvider : BaseInteractionProvider
    {
        [Header("Ultraleap Settings")]
        [SerializeField] private LeapServiceProvider leapProvider;

        [Header("Scaling Tuning")]
        [Tooltip("1.0 = 1:1 hand movement. 0.2 = Moves 20% as fast (Precision Mode)")]
        [Range(0.1f, 5.0f)]
        [SerializeField] private float opticalScaleSensitivity = 1.5f;

        [Header("Gesture Signature Tuning")]
        [Tooltip("Minimum pinch strength required to engage (0.0 to 1.0)")]
        [SerializeField] private float pinchThreshold = 0.85f;

        [Tooltip("Coyote Time (Grace Period): Time in seconds before dropping an object after tracking loss")]
        [SerializeField] private float stabilityBufferTime = 0.1f;

        public override float ScaleSensitivity => opticalScaleSensitivity;

        // Hand state
        private Hand primaryHand;
        private Hand secondaryHand;
        private int lockedPrimaryHandId = -1;
        private int lockedSecondaryHandId = -1;

        // Coyote Time Timers
        private float primaryLossTimer = 0f;
        private float secondaryLossTimer = 0f;

        #region Unity Lifecycle

        private void Awake()
        {
            leapProvider ??= FindFirstObjectByType<LeapServiceProvider>();
        }

        private void Start()
        {
            HandTrackingHintManager.RequestHandTrackingHints(new string[]
            {
                "high_hand_fidelity",
                "microgestures"
            });

            if (leapProvider != null)
            {
                if (isDiagnosticsEnabled)
                {
                    Diagnostics.LogSystem("Ultraleap Provider", "Successfully linked to LeapServiceProvider.");
                    Diagnostics.LogHardwareEvent("Leap Motion 2", "Data stream initialised.");
                }
            }
            else
            {
                Diagnostics.LogError("Ultraleap Provider", "Failed to locate LeapServiceProvider in scene.");
            }
        }

        private void Update()
        {
            if (leapProvider == null || leapProvider.CurrentFrame == null) return;

            Frame frame = leapProvider.CurrentFrame;
            isTrackingValid = frame != null && frame.Hands.Count > 0;

            if (!isTrackingValid) return; // FSM handles total tracking loss safely

            UpdatePrimaryHand(frame);
            UpdateSecondaryHand(frame);
            ScanForNewHands(frame);
            AssignFallbackHand(frame);
        }

        #endregion

        #region Hand Management

        private void UpdatePrimaryHand(Frame frame)
        {
            if (lockedPrimaryHandId != -1)
            {
                Hand foundHand = frame.Hand(lockedPrimaryHandId);
                if (foundHand != null)
                {
                    primaryHand = foundHand;
                    primaryLossTimer = 0f; // Reset grace period
                }
                else
                {
                    primaryLossTimer += Time.deltaTime;
                    if (primaryLossTimer > stabilityBufferTime)
                    {
                        lockedPrimaryHandId = -1;
                        primaryHand = null;
                        primaryLossTimer = 0f;
                    }
                }
            }
        }

        private void UpdateSecondaryHand(Frame frame)
        {
            if (lockedSecondaryHandId != -1)
            {
                Hand foundHand = frame.Hand(lockedSecondaryHandId);
                if (foundHand != null)
                {
                    secondaryHand = foundHand;
                    secondaryLossTimer = 0f; // Reset grace period
                }
                else
                {
                    secondaryLossTimer += Time.deltaTime;
                    if (secondaryLossTimer > stabilityBufferTime)
                    {
                        lockedSecondaryHandId = -1;
                        secondaryHand = null;
                        secondaryLossTimer = 0f;
                    }
                }
            }
        }

        private void ScanForNewHands(Frame frame)
        {
            // Scan for valid pinches to assign to empty slots
            foreach (Hand hand in frame.Hands)
            {
                if (hand.Id == lockedPrimaryHandId || hand.Id == lockedSecondaryHandId) continue;

                if (IsHandPinching(hand))
                {
                    if (lockedPrimaryHandId == -1)
                    {
                        primaryHand = hand;
                        lockedPrimaryHandId = hand.Id;
                        primaryLossTimer = 0f;
                    }
                    else if (lockedSecondaryHandId == -1)
                    {
                        secondaryHand = hand;
                        lockedSecondaryHandId = hand.Id;
                        secondaryLossTimer = 0f;
                    }
                }
            }
        }

        private void AssignFallbackHand(Frame frame)
        {
            // Fallback for IDLE positioning (not holding anything)
            if (lockedPrimaryHandId == -1 && frame.Hands.Count > 0)
            {
                primaryHand = frame.Hands[0];
            }
        }

        #endregion

        #region Gesture Detection

        /// <summary>
        /// Audits finger states to explicitly isolate a "Precision Pinch".
        /// Rejects fully closed fists or casual swipes to preserve metric integrity.
        /// </summary>
        private bool IsHandPinching(Hand hand)
        {
            if (hand == null) return false;

            bool isPinching = hand.PinchStrength >= pinchThreshold;
            bool isMiddleCurled = !hand.fingers[(int)Finger.FingerType.MIDDLE].IsExtended;
            bool isPinkyCurled = !hand.fingers[(int)Finger.FingerType.PINKY].IsExtended;

            return isPinching && isMiddleCurled && isPinkyCurled;
        }

        #endregion

        #region BaseInteractionProvider Implementation

        public override bool IsInteractionTriggered()
        {
            if (!isTrackingValid || primaryHand == null) return false;

            bool isPrimaryTriggered = IsHandPinching(primaryHand);

            // If primary drops but secondary is still holding, swap hands
            if (!isPrimaryTriggered && secondaryHand != null && IsHandPinching(secondaryHand))
            {
                if (isDiagnosticsEnabled)
                {
                    Diagnostics.LogHardwareEvent("Leap SDK", "Primary lost. Secondary hand promoted to Primary.");
                }

                primaryHand = secondaryHand;
                lockedPrimaryHandId = lockedSecondaryHandId;

                secondaryHand = null;
                lockedSecondaryHandId = -1;
                isPrimaryTriggered = true;

                primaryLossTimer = 0f;
                secondaryLossTimer = 0f;
            }
            else if (!isPrimaryTriggered && primaryLossTimer > stabilityBufferTime)
            {
                lockedPrimaryHandId = -1;
            }

            return isPrimaryTriggered;
        }

        public override bool IsBimanualInteractionTriggered()
        {
            if (!isTrackingValid || primaryHand == null || secondaryHand == null) return false;

            bool isSecondaryTriggered = IsHandPinching(secondaryHand);
            if (!isSecondaryTriggered && secondaryLossTimer > stabilityBufferTime)
            {
                lockedSecondaryHandId = -1;
                secondaryHand = null;
            }

            return IsHandPinching(primaryHand) && isSecondaryTriggered;
        }

        private Vector3 GetPinchPosition(Hand hand)
        {
            // Fallback safety if accessed during a coyote-time dropped frame
            if (hand == null) return Vector3.zero;

            Vector3 thumbTip = hand.fingers[(int)Finger.FingerType.THUMB].TipPosition;
            Vector3 indexTip = hand.fingers[(int)Finger.FingerType.INDEX].TipPosition;

            return Vector3.Lerp(thumbTip, indexTip, 0.5f);
        }

        public override Vector3 GetPinchPosition() => GetPinchPosition(primaryHand);

        public override Quaternion GetInputRotation()
        {
            return primaryHand != null ? primaryHand.Rotation : Quaternion.identity;
        }

        public override float GetBimanualDistance()
        {
            return Vector3.Distance(GetPinchPosition(primaryHand), GetPinchPosition(secondaryHand));
        }

        public override float GetDiscreteScaleInput() => 0f;

        public override float GetRawGripStrength()
        {
            if (primaryHand != null) return primaryHand.PinchStrength;
            if (secondaryHand != null) return secondaryHand.PinchStrength;
            return 0f;
        }

        #endregion

        #region Provider Lifecycle

        public override void SetProviderActive(bool isActive)
        {
            // Disable the script's Update loop
            this.enabled = isActive;

            // Turn off the actual Leap camera rig and 3D hand models to save CPU and hide visuals
            if (leapProvider != null && leapProvider.gameObject != this.gameObject)
            {
                leapProvider.gameObject.SetActive(isActive);
            }
            else if (leapProvider != null && leapProvider.gameObject == this.gameObject)
            {
                Diagnostics.LogWarning("Ultraleap Provider",
                    "CRITICAL: Provider script is attached to the Leap Rig. Move it to a separate Manager object to safely toggle visuals.");
            }

            // Purge memory so old hand positions don't teleport the liver when turned back on
            if (!isActive)
            {
                primaryHand = null;
                secondaryHand = null;
                lockedPrimaryHandId = -1;
                lockedSecondaryHandId = -1;
                isTrackingValid = false;
            }

            if (isDiagnosticsEnabled)
            {
                Diagnostics.LogHardwareEvent("Ultraleap SDK", isActive ? "Provider woken up." : "Provider sleeping.");
            }
        }

        #endregion
    }
}

### VarjoInteractionProvider.cs

using UnityEngine;
using UnityEngine.XR;
using System.Collections.Generic;
using System.Linq;
using COMP3932.Core;

namespace COMP3932.Kinematics
{
    /// <summary>
    /// Condition A Provider: Processes XR Input Actions from physical 6-DoF controllers.
    /// Employs 'first-grab-wins' logic to prevent teleporting between active hands.
    /// </summary>
    public class VarjoInteractionProvider : BaseInteractionProvider
    {
        private enum ActiveController { None, Left, Right }
        private ActiveController currentActiveController = ActiveController.None;

        [Header("Left Controller")]
        [Tooltip("Assign the Left Hand Controller Transforms here")]
        [SerializeField] private Transform leftTransform;
        [SerializeField] private GameObject leftVisualModel;

        [Header("Right Controller")]
        [Tooltip("Assign the Right Hand Controller Transforms here")]
        [SerializeField] private Transform rightTransform;
        [SerializeField] private GameObject rightVisualModel;

        [Header("Tuning")]
        [Tooltip("Threshold for analog triggers before registering a valid grab")]
        [SerializeField] private float gripThreshold = 0.5f;

        [Tooltip("Speed multiplier for thumbstick scaling")]
        [Range(0.1f, 5.0f)]
        [SerializeField] private float thumbstickScaleSensitivity = 1.5f;

        // XR devices
        private InputDevice leftDevice;
        private InputDevice rightDevice;
        private List<InputDevice> devices = new List<InputDevice>();

        #region Properties

        public override float ScaleSensitivity => thumbstickScaleSensitivity;

        #endregion

        #region Unity Lifecycle

        private void Start()
        {
            // Check transforms are assigned
            if (leftTransform != null && rightTransform != null)
            {
                if (isDiagnosticsEnabled)
                {
                    Diagnostics.LogSystem("Varjo Provider", "Hardware tracking transforms linked successfully.");
                }
            }
            else
            {
                Diagnostics.LogError("Varjo Provider", "One or both Controller Transforms are missing!");
            }
        }

        private void Update()
        {
            UpdateDevices();

            bool leftValid = leftTransform != null &&
                             leftTransform.gameObject.activeInHierarchy &&
                             leftDevice.isValid;

            bool rightValid = rightTransform != null &&
                              rightTransform.gameObject.activeInHierarchy &&
                              rightDevice.isValid;

            isTrackingValid = leftValid || rightValid;
        }

        #endregion

        #region Device Management

        /// <summary>
        /// Polls the legacy XR system to acquire the physical hardware devices.
        /// </summary>
        private void UpdateDevices()
        {
            InputDevices.GetDevicesAtXRNode(XRNode.LeftHand, devices);
            leftDevice = devices.FirstOrDefault();

            InputDevices.GetDevicesAtXRNode(XRNode.RightHand, devices);
            rightDevice = devices.FirstOrDefault();
        }

        /// <summary>
        /// Reads hardware grip state, checking for precise analog values first to prevent binary jitter.
        /// </summary>
        private bool GetGripButton(InputDevice device)
        {
            if (!device.isValid) return false;

            // Check for analog triggers (Index/Varjo/Quest)
            if (device.TryGetFeatureValue(CommonUsages.grip, out float gripValue))
            {
                return gripValue >= gripThreshold;
            }

            // Fallback for older binary buttons (Vive Wands)
            if (device.TryGetFeatureValue(CommonUsages.gripButton, out bool isPressed))
            {
                return isPressed;
            }

            return false;
        }

        private Vector2 GetThumbstick(InputDevice device)
        {
            if (!device.isValid) return Vector2.zero;

            if (device.TryGetFeatureValue(CommonUsages.primary2DAxis, out Vector2 axis))
            {
                return axis;
            }

            return Vector2.zero;
        }

        #endregion

        #region BaseInteractionProvider Implementation

        public override bool IsInteractionTriggered()
        {
            if (!isTrackingValid) return false;

            bool isLeftGripping = GetGripButton(leftDevice);
            bool isRightGripping = GetGripButton(rightDevice);

            // First Grab Wins (prevents spatial teleporting)
            if (currentActiveController == ActiveController.None)
            {
                if (isLeftGripping)
                {
                    currentActiveController = ActiveController.Left;
                }
                else if (isRightGripping)
                {
                    currentActiveController = ActiveController.Right;
                }
            }

            // Release logic: object will only be dropped if the active holding hand lets go
            if (currentActiveController == ActiveController.Left && !isLeftGripping)
            {
                currentActiveController = ActiveController.None;
            }
            else if (currentActiveController == ActiveController.Right && !isRightGripping)
            {
                currentActiveController = ActiveController.None;
            }

            return currentActiveController != ActiveController.None;
        }

        public override Vector3 GetPinchPosition()
        {
            if (!isTrackingValid) return Vector3.zero;

            if (currentActiveController == ActiveController.Left && leftTransform != null)
            {
                return leftTransform.position;
            }

            if (currentActiveController == ActiveController.Right && rightTransform != null)
            {
                return rightTransform.position;
            }

            return Vector3.zero;
        }

        public override Quaternion GetInputRotation()
        {
            if (!isTrackingValid) return Quaternion.identity;

            if (currentActiveController == ActiveController.Left && leftTransform != null)
            {
                return leftTransform.rotation;
            }

            if (currentActiveController == ActiveController.Right && rightTransform != null)
            {
                return rightTransform.rotation;
            }

            return Quaternion.identity;
        }

        public override bool IsBimanualInteractionTriggered() => false;

        public override float GetBimanualDistance() => 0f;

        public override float GetDiscreteScaleInput()
        {
            if (!isTrackingValid) return 0f;

            // Enforces scaling only when actively grabbing
            bool isGripping = IsInteractionTriggered();
            if (!isGripping) return 0f;

            // Read thumbstick from both controllers simultaneously
            Vector2 leftThumbstick = GetThumbstick(leftDevice);
            Vector2 rightThumbstick = GetThumbstick(rightDevice);

            // Use the strongest input vector for strongest input
            float chosenY = Mathf.Abs(leftThumbstick.y) > Mathf.Abs(rightThumbstick.y)
                ? leftThumbstick.y
                : rightThumbstick.y;

            return chosenY * ScaleSensitivity * Time.deltaTime;
        }

        public override float GetRawGripStrength()
        {
            if (!isTrackingValid) return 0f;

            // Poll the active controller, or default to right hand if none is active
            InputDevice activeDevice = (currentActiveController == ActiveController.Left)
                ? leftDevice
                : rightDevice;

            if (!activeDevice.isValid)
            {
                activeDevice = rightDevice;
            }

            // 1. Try high-fidelity analog grip first
            if (activeDevice.TryGetFeatureValue(CommonUsages.grip, out float gripValue))
            {
                // Some controllers return 0 for analog even when pressed, so only return if > 0
                if (gripValue > 0.01f)
                {
                    return gripValue;
                }
            }

            // 2. Legacy fallback for digital binary buttons (returns 1.0 if fully pressed)
            if (activeDevice.TryGetFeatureValue(CommonUsages.gripButton, out bool isPressed))
            {
                return isPressed ? 1f : 0f;
            }

            return 0f;
        }

        #endregion

        #region Provider Lifecycle

        public override void SetProviderActive(bool isActive)
        {
            // Natively calls OnEnable()/OnDisable() which
            // unregisters the InputSystem Actions to save polling performance.
            this.enabled = isActive;

            // Explicitly hide/show the 3D Varjo meshes attached to the XR Rig
            if (leftVisualModel != null)
            {
                leftVisualModel.SetActive(isActive);
            }

            if (rightVisualModel != null)
            {
                rightVisualModel.SetActive(isActive);
            }

            if (!isActive)
            {
                currentActiveController = ActiveController.None;
                isTrackingValid = false;
            }

            if (isDiagnosticsEnabled)
            {
                Diagnostics.LogHardwareEvent("Varjo Controllers",
                    isActive ? "Provider woken up." : "Provider sleeping.");
            }
        }

        #endregion
    }
}

## UnityProject/Assets/_Project/Scripts/Core

### Diagnostics.cs

using UnityEngine;

namespace COMP3932.Core
{
    /// <summary>
    /// Centralised diagnostic logger for the Kinematics framework.
    /// Standardises console output formatting for development and engineering audit trail.
    /// </summary>
    public static class Diagnostics
    {
        [Tooltip("Global toggle - turn this off to save CPU cycles")]
        public static bool EnableSystemDiagnostics = true;

        public static void LogSystem(string systemName, string message)
        {
            if (!EnableSystemDiagnostics) return;
            Debug.Log($"<color=#4CAF50><b>[SYS - {systemName}]</b></color> {message}");
        }

        public static void LogHardwareEvent(string device, string status)
        {
            if (!EnableSystemDiagnostics) return;
            Debug.Log($"<color=#FF9800><b>[HARDWARE - {device}]</b></color> {status}");
        }

        public static void LogStateChange(string controlType, string newState)
        {
            if (!EnableSystemDiagnostics) return;
            Debug.Log($"<color=#00FFE8><b>[FSM - {controlType}]</b></color> Transitioned to: <b>{newState}</b>");
        }

        public static void LogDataOutput(string currentState, string metricName, string metricValue)
        {
            if (!EnableSystemDiagnostics) return;
            Debug.Log($"<color=#FFFFFF80><b>[DATA - {currentState}]</b></color> {metricName}: <b>{metricValue}</b>");
        }

        public static void LogWarning(string context, string warningMessage)
        {
            if (!EnableSystemDiagnostics) return;
            Debug.LogWarning($"<color=#FFC107><b>[WARN - {context}]</b></color> {warningMessage}");
        }

        public static void LogError(string context, string errorMessage)
        {
            // Errors should always log, even if standard diagnostics are turned off
            Debug.LogError($"<color=#F44336><b>[ERROR - {context}]</b></color> {errorMessage}");
        }

        public static void LogPerformance(string metricName, float value, string unit = "ms")
        {
            if (!EnableSystemDiagnostics) return;
            Debug.Log($"<color=#9C27B0><b>[PERF - {metricName}]</b></color> {value:F2}{unit}");
        }

        public static void LogBoundaryEvent(string boundaryType, string value)
        {
            if (!EnableSystemDiagnostics) return;
            Debug.Log($"<color=#FFEB3B><b>[BOUNDARY - {boundaryType}]</b></color> {value}");
        }

        public static void LogSessionEvent(string eventType, string details)
        {
            Debug.Log($"<color=#E91E63><b>[SESSION - {eventType}]</b></color> {details}");
        }
    }
}

### SystemBootstrapper.cs

using UnityEngine;
using Leap;
using COMP3932.Kinematics;

namespace COMP3932.Core
{
    /// <summary>
    /// Executes on scene load to verify all critical hardware and software
    /// dependencies are active before the user begins the trial.
    /// </summary>
    public class SystemBootstrapper : MonoBehaviour
    {
        [Header("Critical Dependencies")]
        [SerializeField] private LeapServiceProvider leapProvider;
        [SerializeField] private InteractionOrchestrator orchestrator;

        #region Unity Lifecycle

        private void Awake()
        {
            // Initial setup here. Do not query external components yet.
            Diagnostics.LogSystem("Bootstrapper", "Awake phase complete. Awaiting external services.");
        }

        private void Start()
        {
            // Scene is loaded. Verify external singletons and SDKs
            Diagnostics.LogSystem("Bootstrapper", "Start phase initiated. Verifying hardware and frameworks...");
            VerifyCriticalSystems();
        }

        #endregion

        #region System Verification

        private void VerifyCriticalSystems()
        {
            bool systemHalt = false;

            systemHalt |= VerifyUltraleapTracking();
            systemHalt |= VerifyKinematicFramework();

            HandleVerificationResult(systemHalt);
        }

        private bool VerifyUltraleapTracking()
        {
            // Verify ultraleap tracking
            leapProvider ??= FindFirstObjectByType<LeapServiceProvider>();

            if (leapProvider != null)
            {
                Diagnostics.LogHardwareEvent("Ultraleap SDK", "Provider located and active.");
                return false; // No halt
            }
            else
            {
                Diagnostics.LogError("Ultraleap SDK", "FATAL: LeapServiceProvider not found in scene!");
                return true; // Halt system
            }
        }

        private bool VerifyKinematicFramework()
        {
            // Verify kinematic framework
            if (orchestrator != null)
            {
                Diagnostics.LogSystem("Kinematic Framework", "Interaction Orchestrator linked.");
                return false; // No halt
            }
            else
            {
                Diagnostics.LogError("Kinematic Framework", "FATAL: Interaction Orchestrator is missing!");
                return true; // Halt system
            }
        }

        private void HandleVerificationResult(bool systemHalt)
        {
            if (systemHalt)
            {
                Diagnostics.LogError("Bootstrapper", "SYSTEM HALT. Critical dependencies missing. Please check the hierarchy.");

                #if UNITY_EDITOR
                Debug.Break(); // Pauses the unity editor automatically
                #endif
            }
            else
            {
                Diagnostics.LogSystem("Bootstrapper", "All systems verified. Ready for Clinical Trial.");

                // Log the active model if available
                if (orchestrator != null && orchestrator.activeLiverModel != null)
                {
                    orchestrator.SetActiveModel(orchestrator.activeLiverModel);
                }
            }
        }

        #endregion
}

## UnityProject/Assets/_Project/Scripts/Experiment

### TrialOrchestrator.cs

using UnityEngine;
using COMP3932.Kinematics;
using COMP3932.Telemetry;
using COMP3932.Core;

namespace COMP3932.Experiment
{
    public enum TrialTask : byte
    {
        PureTranslation     = 0b0001,  // Bit 0 (value 1)   - Translation allowed
        PureRotation        = 0b0010,  // Bit 1 (value 2)   - Rotation allowed
        SixDegreesOfFreedom = 0b0011,  // Bits 0 + 1 (1+2=3) - Translation and Rotation
        FullScale           = 0b0111   // Bits 0,1,2 (1+2+4=7) - Translation, Rotation, and Scaling
    }

    /// <summary>
    /// The master sequence manager for the clinical trial.
    /// Enforces spatial dwell times, resets environments between tasks,
    /// synchronises the telemetry logger automatically, and handles condition swapping.
    /// </summary>
    public class TrialOrchestrator : MonoBehaviour
    {
        [Header("Trial Administration")]
        public string participantID = "P01";
        public TrialTask currentTask = TrialTask.PureTranslation;

        [Header("System References")]
        [SerializeField] private InteractionOrchestrator interactionOrchestrator;
        [SerializeField] private SessionTelemetryLogger telemetryLogger;
        [SerializeField] private Transform activeLiver;
        [SerializeField] private Transform targetHologram;
        [SerializeField] private Transform xrOrigin;
        [Tooltip("The Main Camera tracking the user's head")]
        [SerializeField] private Transform mainCamera;

        [Header("Validation Constraints")]
        [Tooltip("Maximum allowed distance (meters) from target")]
        [SerializeField] private float acceptableDistanceError = 0.05f; // 5cm

        [Tooltip("Maximum allowed angular difference (degrees) from target")]
        [SerializeField] private float acceptableAngularError = 5.0f; // 5 degrees

        [Tooltip("Maximum allowed scale difference (ratio) from target")]
        [SerializeField] private float acceptableScaleErrorRatio = 0.1f; // Within 10%

        [Tooltip("How long the user must hold the model inside the tolerances (seconds)")]
        [SerializeField] private float requiredDwellTime = 3.0f;

        // Internal State
        private bool isTrialActive = false;
        private bool isTaskActive = false;
        private bool isPaused = false;
        private bool hasSwappedCondition = false;
        private float currentDwellTimer = 0f;
        private Vector3 initialXROriginPos;
        private Quaternion initialXROriginRot;

        // Task sequence constants
        private static readonly TrialTask[] TaskSequence = new TrialTask[]
        {
            TrialTask.PureTranslation,
            TrialTask.PureRotation,
            TrialTask.SixDegreesOfFreedom,
            TrialTask.FullScale
        };

        private void Start()
        {
            if (xrOrigin != null)
            {
                initialXROriginPos = xrOrigin.position;
                initialXROriginRot = xrOrigin.rotation;
            }

            // BUG: EndTrial(); causes hand-tracking to break
        }

        private void Update()
        {
            AdminControls();

            if (!isTaskActive || isPaused) return;

            ValidateSpatialDwell();
        }

        #region Trial Lifecycle

        private void BeginTrial()
        {
            isTrialActive = true;
            DisableInteractions();

            Diagnostics.LogSessionEvent("Trial Orchestrator",
                $"CONDITION 1: <b>[{interactionOrchestrator.GetCurrentControlType()}]</b>, " +
                $"CONDITION 2: <b>[{interactionOrchestrator.GetOtherControlType()}]</b>.");

            Diagnostics.LogSessionEvent("Trial Orchestrator",
                $"Task queued: <b>{currentTask}</b>. Please put on the headset.");

            ResetEnvironment();
            Diagnostics.LogSessionEvent("Trial Orchestrator",
                "Press <i>[DOWN ARROW]</i> to begin the first task when ready.");
        }

        // BUG: This method is currently unused because it causes hand-tracking to break when called.
        // The environment is now reset at the start of the trial and between tasks.
        // private void EndTrial()
        // {
        //     // Unlock all degrees of freedom for free play
        //     if (interactionOrchestrator != null)
        //     {
        //         // Unlock all degrees of freedom for free play
        //         interactionOrchestrator.allowTranslation = true;
        //         interactionOrchestrator.allowRotation = true;
        //         interactionOrchestrator.allowScaling = true;
        //     }

        //     // EnableInteractions();
        // }

        public void StartTask(TrialTask taskToLoad)
        {
            currentTask = taskToLoad;

            EnableInteractions();
            interactionOrchestrator.ForceIdleState();

            if (interactionOrchestrator.activeProvider != null)
            {
                interactionOrchestrator.activeProvider.UpdateFrameMemory();
            }

            ApplyTaskConstraints();

            string condition = interactionOrchestrator.controlType.ToString();
            telemetryLogger.StartTrialLog(participantID, condition, currentTask.ToString());

            isTaskActive = true;
            isPaused = false;
            telemetryLogger.IsPaused = false;
            currentDwellTimer = 0f;

            Diagnostics.LogSessionEvent("TASK_START",
                $"Task <b>[{currentTask}]</b> initiated for Condition <b>[{condition}]</b>.");
        }

        private void CompleteTask()
        {
            isTaskActive = false;
            DisableInteractions();
            telemetryLogger.StopAndExportLog();

            Diagnostics.LogSessionEvent("TASK_COMPLETE",
                $"Task <b>[{currentTask}]</b> successfully completed and logged.");

            AdvanceTaskSequence();
        }

        #endregion

        #region Admin Controls

        /// <summary>
        /// Keyboard inputs for the researcher to control the flow of the experiment.
        /// </summary>
        private void AdminControls()
        {
            // Trial start (SPACE)
            if (Input.GetKeyDown(KeyCode.Space) && !isTrialActive)
            {
                BeginTrial();
                return;
            }

            // Task start (DOWN ARROW)
            if (Input.GetKeyDown(KeyCode.DownArrow) && isTrialActive && !isTaskActive)
            {
                StartTask(currentTask);
                return;
            }

            // Force task completion (RETURN)
            if (Input.GetKeyDown(KeyCode.Return) && isTaskActive)
            {
                Diagnostics.LogSystem("ADMIN", "OVERRIDE: Forcing task completion and data export.");
                CompleteTask();
                return;
            }

            // Navigation: Next task (RIGHT ARROW)
            if (Input.GetKeyDown(KeyCode.RightArrow) && !isTaskActive)
            {
                NavigateToTask(direction: +1);
                return;
            }

            // Navigation: Previous task (LEFT ARROW)
            if (Input.GetKeyDown(KeyCode.LeftArrow) && !isTaskActive)
            {
                NavigateToTask(direction: -1);
                return;
            }

            // Toggle pause (UP ARROW)
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                TogglePause();
                return;
            }

            // Reset environment (MINUS)
            if (Input.GetKeyDown(KeyCode.Minus) && !isTaskActive)
            {
                Diagnostics.LogSystem("ADMIN", "OVERRIDE: Environment reset without starting the task.");
                ResetEnvironment();
                return;
            }
        }

        private void NavigateToTask(int direction)
        {
            currentTask = direction > 0 ? GetNextTask() : GetPreviousTask();
            ResetEnvironment();

            string directionText = direction > 0 ? "Skipping to" : "Returning to";
            string taskPosition = direction > 0 ? "next" : "previous";

            Diagnostics.LogSystem("ADMIN",
                $"OVERRIDE: {directionText} the {taskPosition} task: <b>{currentTask}</b>. " +
                $"Press <i>[DOWN ARROW]</i> to begin.");
        }

        private void TogglePause()
        {
            isPaused = !isPaused;

            if (isPaused)
            {
                DisableInteractions();
                telemetryLogger.IsPaused = true;
                Diagnostics.LogWarning("Trial Orchestrator",
                    "TRIAL PAUSED. Tracking and telemetry suspended. Press <i>[UP ARROW]</i> to resume.");
            }
            else
            {
                if (isTaskActive) EnableInteractions();
                telemetryLogger.IsPaused = false;
                Diagnostics.LogSystem("Trial Orchestrator", "TRIAL RESUMED.");
            }
        }

        #endregion

        #region Interaction Control

        private void DisableInteractions()
        {
            if (interactionOrchestrator?.activeProvider != null)
            {
                interactionOrchestrator.activeProvider.SetProviderActive(false);
            }
        }

        private void EnableInteractions()
        {
            if (interactionOrchestrator?.activeProvider != null)
            {
                interactionOrchestrator.activeProvider.SetProviderActive(true);
            }
        }

        #endregion

        #region Task Sequence Management

        /// <summary>
        /// Advances to the next task in the sequence or condition. If all tasks in both conditions are complete, ends the trial.
        /// </summary>
        private void AdvanceTaskSequence()
        {
            int currentIndex = GetCurrentTaskIndex();
            int nextIndex = currentIndex + 1;

            // Still more tasks in current condition
            if (nextIndex < TaskSequence.Length)
            {
                currentTask = TaskSequence[nextIndex];
                ResetEnvironment();
                Diagnostics.LogSessionEvent("Trial Orchestrator",
                    $"Please fill out the RTLX. Next task queued: <b>{currentTask}</b>. Press <i>[DOWN ARROW]</i> to begin.");
                return;
            }

            // End of current condition
            if (!hasSwappedCondition)
            {
                SwapToNextCondition();
                return;
            }

            // Both conditions complete
            CompleteAllConditions();
        }

        private void SwapToNextCondition()
        {
            hasSwappedCondition = true;
            currentTask = TaskSequence[0];

            ControlType nextControl = interactionOrchestrator.controlType == ControlType.HAND
                ? ControlType.CONTROLLER
                : ControlType.HAND;

            interactionOrchestrator.SetControlType(nextControl);
            DisableInteractions();

            ResetEnvironment();
            Diagnostics.LogSessionEvent("Trial Orchestrator",
                $"CONDITION 1 COMPLETE. Please rest and fill out the SUS. Press <i>[DOWN ARROW]</i> to start Condition 2.");
        }

        private void CompleteAllConditions()
        {
            Diagnostics.LogSessionEvent("Trial Orchestrator",
                "CONDITION 2 COMPLETE. Please rest and fill out the SUS.");
            Diagnostics.LogSessionEvent("Trial Orchestrator",
                "ALL CONDITIONS COMPLETE. TRIAL FINISHED.");
            ExitApplication();
        }

        #endregion

        #region Spatial Validation

        /// <summary>
        /// Enforces the dwell time rule. User must hold model within all tolerances simultaneously.
        /// </summary>
        private void ValidateSpatialDwell()
        {
            float distError = Vector3.Distance(activeLiver.localPosition, targetHologram.localPosition);
            float rotError = Quaternion.Angle(activeLiver.localRotation, targetHologram.localRotation);
            float scaleError = Mathf.Abs(activeLiver.localScale.x - targetHologram.localScale.x) / targetHologram.localScale.x;

            bool isPosValid = distError <= acceptableDistanceError;
            bool isRotValid = rotError <= acceptableAngularError;
            bool isScaleValid = scaleError <= acceptableScaleErrorRatio;

            bool taskCriteriaMet = EvaluateTaskCriteria(isPosValid, isRotValid, isScaleValid);

            if (taskCriteriaMet)
            {
                currentDwellTimer += Time.deltaTime;

                // Log every 0.5 seconds
                if (currentDwellTimer % 0.5f < Time.deltaTime)
                {
                    Diagnostics.LogDataOutput("VALIDATING", "Dwell Time", $"{currentDwellTimer:F1}s / {requiredDwellTime}s");
                }

                if (currentDwellTimer >= requiredDwellTime)
                {
                    CompleteTask();
                }
            }
            else if (currentDwellTimer > 0f)
            {
                currentDwellTimer = 0f;
                Diagnostics.LogBoundaryEvent("VALIDATION",
                    "Dwell timer reset. User slipped out of tolerance bounds.");
            }
        }

        private bool EvaluateTaskCriteria(bool isPosValid, bool isRotValid, bool isScaleValid)
        {
            switch (currentTask)
            {
                case TrialTask.PureTranslation:
                    return isPosValid;

                case TrialTask.PureRotation:
                    return isPosValid && isRotValid;

                case TrialTask.SixDegreesOfFreedom:
                    return isPosValid && isRotValid;

                case TrialTask.FullScale:
                    return isPosValid && isRotValid && isScaleValid;

                default:
                    return false;
            }
        }

        #endregion

        #region Environment Management

        private void ResetEnvironment()
        {
            ResetXROrigin();
            ResetTargetHologram();
            ResetActiveLiverBasedOnTask();
        }

        private void ResetXROrigin()
        {
            if (xrOrigin != null)
            {
                xrOrigin.position = initialXROriginPos;
                xrOrigin.rotation = initialXROriginRot;
            }
        }

        private void ResetTargetHologram()
        {
            Vector3 targetPos = new Vector3(0.972f, -0.197f, -0.852f);
            Vector3 baseScale = new Vector3(0.001f, 0.001f, 0.001f);

            targetHologram.localPosition = targetPos;
            targetHologram.localRotation = Quaternion.identity;
            targetHologram.localScale = baseScale;
        }

        private void ResetActiveLiverBasedOnTask()
        {
            Vector3 baseScale = new Vector3(0.001f, 0.001f, 0.001f);
            Vector3 targetPos = new Vector3(0.972f, -0.197f, -0.852f);

            switch (currentTask)
            {
                case TrialTask.PureTranslation:
                    activeLiver.localPosition = new Vector3(0.534f, -0.206f, -0.957f);
                    activeLiver.localRotation = Quaternion.identity;
                    activeLiver.localScale = baseScale;
                    break;

                case TrialTask.PureRotation:
                    activeLiver.localPosition = targetPos;
                    activeLiver.localRotation = Quaternion.Euler(
                        Random.Range(45, 135),
                        Random.Range(45, 135),
                        Random.Range(45, 135));
                    activeLiver.localScale = baseScale;
                    break;

                case TrialTask.SixDegreesOfFreedom:
                    activeLiver.localPosition = new Vector3(1.251f, -0.244f, -1.062f);
                    activeLiver.localRotation = Quaternion.Euler(
                        Random.Range(45, 135),
                        Random.Range(45, 135),
                        Random.Range(45, 135));
                    activeLiver.localScale = baseScale;
                    break;

                case TrialTask.FullScale:
                    activeLiver.localPosition = new Vector3(0.614f, -0.088f, -1.037f);
                    activeLiver.localRotation = Quaternion.Euler(
                        Random.Range(45, 135),
                        Random.Range(45, 135),
                        Random.Range(45, 135));
                    activeLiver.localScale = baseScale * Random.Range(0.5f, 1.15f);
                    break;
            }
        }

        /// <summary>
        /// Applies the constraints for the current task using a bitmask.
        /// </summary>
        private void ApplyTaskConstraints()
        {
            byte mask = (byte)currentTask;

            interactionOrchestrator.allowTranslation = (mask & 0b0001) != 0;
            interactionOrchestrator.allowRotation    = (mask & 0b0010) != 0;
            interactionOrchestrator.allowScaling     = (mask & 0b0100) != 0;
        }

        #endregion

        #region Task Navigation Helpers

        public TrialTask GetCurrentTask() => currentTask;

        public int GetCurrentTaskIndex()
        {
            for (int i = 0; i < TaskSequence.Length; i++)
            {
                if (TaskSequence[i] == currentTask) return i;
            }
            return 0;
        }

        public TrialTask GetPreviousTask()
        {
            int currentIndex = GetCurrentTaskIndex();
            int previousIndex = (currentIndex - 1 + TaskSequence.Length) % TaskSequence.Length;
            return TaskSequence[previousIndex];
        }

        public TrialTask GetNextTask()
        {
            int currentIndex = GetCurrentTaskIndex();
            int nextIndex = (currentIndex + 1) % TaskSequence.Length;
            return TaskSequence[nextIndex];
        }

        #endregion

        #region Utilities

        private void ExitApplication()
        {
            #if UNITY_EDITOR
                UnityEditor.EditorApplication.isPlaying = false;
            #else
                Application.Quit();
            #endif
        }

        #endregion
    }
}

## UnityProject/Assets/_Project/Scripts/Telemetry

### SessionTelemetryLogger.cs

using System;
using System.IO;
using System.Text;
using UnityEngine;
using COMP3932.Kinematics;
using COMP3932.Core;
using COMP3932.Experiment;

namespace COMP3932.Telemetry
{
    /// <summary>
    /// High-frequency, memory-safe metrics engine for 6-DoF alignment tasks.
    /// Captures efficiency ratios, error deltas, and ergonomic variance at 20Hz.
    /// </summary>
    public class SessionTelemetryLogger : MonoBehaviour
    {
        [Header("System References")]
        [SerializeField] private InteractionOrchestrator orchestrator;
        [SerializeField] private TrialOrchestrator trial;
        [SerializeField] private Transform activeModel;
        [SerializeField] private Transform targetGhost;

        [Header("Configuration")]
        [Tooltip("Polling frequency in seconds. 0.05 = 20Hz")]
        [SerializeField] private float pollingInterval = 0.05f;

        public bool IsPaused { get; set; } = false;
        public bool isDiagnosticsEnabled = false;

        private string currentFilePath;
        private StringBuilder dataBuffer;
        private float pollTimer = 0f;
        private bool isLogging = false;

        // Session Metadata
        private string currentParticipantID;
        private string currentCondition;
        private string currentTask;
        private int currentTaskIndex;
        private float sessionStartTime;
        private float accumulatedPauseTime = 0f;
        private float lastPauseTimestamp = 0f;

        // Metric Accumulators
        private Vector3 lastModelPosition;
        private Quaternion lastModelRotation;
        private float optimalPathLength;
        private float optimalRotationAngle;

        private float accumulatedPathLength = 0f;
        private float accumulatedRotation = 0f;

        private int clutchCount = 0;
        private InteractionState lastFsmState;

        // Welford's Algorithm variables for memory-safe running variance
        private int gripSampleCount = 0;
        private float gripMean = 0f;
        private float gripM2 = 0f;

        #region Unity Lifecycle

        private void Awake()
        {
            dataBuffer = new StringBuilder();
        }

        private void FixedUpdate()
        {
            if (!isLogging || orchestrator == null || activeModel == null || targetGhost == null) return;

            if (IsPaused)
            {
                // Track how long we are paused so we can subtract it from the final completion time
                if (lastPauseTimestamp == 0f) lastPauseTimestamp = Time.time;
                return;
            }
            else if (lastPauseTimestamp > 0f)
            {
                accumulatedPauseTime += (Time.time - lastPauseTimestamp);
                lastPauseTimestamp = 0f;
            }

            // Continuous Accumulation (Runs every physics frame for accuracy)
            TrackInefficiencyAndClutches();

            // Scheduled Polling (Runs at 20Hz for CSV output)
            pollTimer += Time.fixedDeltaTime;
            if (pollTimer >= pollingInterval)
            {
                RecordMetricsRow();
                pollTimer -= pollingInterval;
            }
        }

        #endregion

        #region Public API

        /// <summary>
        /// Initialises a new telemetry log for the current trial.
        /// Generates a unique filename based on participant ID, condition, task, and timestamp.
        /// </summary>
        public void StartTrialLog(string participantId, string condition, string taskName)
        {
            currentParticipantID = participantId;
            currentCondition = condition;
            currentTask = taskName;
            currentTaskIndex = trial.GetCurrentTaskIndex();

            string timestamp = DateTime.Now.ToString("ddMMyyyy_HHmmss");
            string directory = Path.Combine(Application.dataPath, "../ProjectData/Telemetry");
            Directory.CreateDirectory(directory);

            currentFilePath = Path.Combine(directory, $"{participantId}_{condition}_{currentTaskIndex}_{taskName}_{timestamp}.csv");

            optimalPathLength = Vector3.Distance(activeModel.position, targetGhost.position);
            optimalRotationAngle = Quaternion.Angle(activeModel.rotation, targetGhost.rotation);

            ResetAccumulators();

            dataBuffer.Clear();
            dataBuffer.AppendLine("Time(s),State,PosError(m),RotError(deg),PathInefficiency,RotInefficiency,ClutchCount,RawGrip,GripVariance");

            sessionStartTime = Time.time;
            accumulatedPauseTime = 0f;
            isLogging = true;
            IsPaused = false;
            pollTimer = 0f;

            if (isDiagnosticsEnabled)
                Diagnostics.LogSessionEvent("TELEMETRY_START", $"Buffering high-frequency data for {taskName}");
        }

        public void StopAndExportLog()
        {
            isLogging = false;

            if (dataBuffer.Length > 0)
            {
                File.WriteAllText(currentFilePath, dataBuffer.ToString());
                float totalActiveTime = (Time.time - sessionStartTime) - accumulatedPauseTime;

                if (isDiagnosticsEnabled)
                {
                    Diagnostics.LogSessionEvent("TELEMETRY_EXPORT", $"Saved telemetry to: {currentFilePath}");
                    Diagnostics.LogDataOutput("TRIAL_END", "Total Task Completion Time (TCT)", totalActiveTime.ToString("F2") + "s");
                }

                dataBuffer.Clear();
            }
        }

        #endregion

        #region Metric Tracking

        private void ResetAccumulators()
        {
            lastModelPosition = activeModel.position;
            lastModelRotation = activeModel.rotation;
            accumulatedPathLength = 0f;
            accumulatedRotation = 0f;
            clutchCount = 0;
            lastFsmState = InteractionState.IDLE;

            gripSampleCount = 0;
            gripMean = 0f;
            gripM2 = 0f;
        }

        private void TrackInefficiencyAndClutches()
        {
            accumulatedPathLength += Vector3.Distance(lastModelPosition, activeModel.position);
            accumulatedRotation += Quaternion.Angle(lastModelRotation, activeModel.rotation);

            lastModelPosition = activeModel.position;
            lastModelRotation = activeModel.rotation;

            TrackClutchCount();

            if (IsCurrentlyGrabbing() && orchestrator.activeProvider != null)
            {
                UpdateWelfordVariance(orchestrator.activeProvider.GetRawGripStrength());
            }
        }

        /// <summary>
        /// Increments clutch count when transitioning from an idle/clutched state to a grabbing state.
        /// </summary>
        private void TrackClutchCount()
        {
            InteractionState currentState = orchestrator.currentState;
            bool wasIdle = lastFsmState == InteractionState.IDLE || lastFsmState == InteractionState.CLUTCHED;
            bool isGrabbing = currentState == InteractionState.TRANSFORMING || currentState == InteractionState.SCALING;

            if (wasIdle && isGrabbing)
            {
                clutchCount++;
            }
            lastFsmState = currentState;
        }

        private bool IsCurrentlyGrabbing()
        {
            InteractionState currentState = orchestrator.currentState;
            return currentState == InteractionState.TRANSFORMING || currentState == InteractionState.SCALING;
        }

        #endregion

        #region Welford's Algorithm (Running Variance)

        /// <summary>
        /// Updates the running mean and variance of grip strength using Welford's algorithm.
        /// </summary>
        private void UpdateWelfordVariance(float currentValue)
        {
            gripSampleCount++;
            float delta = currentValue - gripMean;
            gripMean += delta / gripSampleCount;
            float delta2 = currentValue - gripMean;
            gripM2 += delta * delta2;
        }

        private float GetCurrentGripVariance()
        {
            if (gripSampleCount < 2) return 0f;
            return gripM2 / (gripSampleCount - 1);
        }

        #endregion

        #region Data Recording

        private void RecordMetricsRow()
        {
            // Calculate active time by subtracting any accumulated mid-task pause time
            float activeElapsedTime = (Time.time - sessionStartTime) - accumulatedPauseTime;
            string stateStr = orchestrator.currentState.ToString();

            float posError = Vector3.Distance(activeModel.position, targetGhost.position);
            float rotError = Quaternion.Angle(activeModel.rotation, targetGhost.rotation);

            float pathIneff = CalculatePathInefficiency();
            float rotIneff = CalculateRotationInefficiency();

            float rawGrip = orchestrator.activeProvider != null ? orchestrator.activeProvider.GetRawGripStrength() : 0f;
            float gripVariance = GetCurrentGripVariance();

            dataBuffer.AppendLine($"{activeElapsedTime:F3},{stateStr},{posError:F4},{rotError:F4},{pathIneff:F4},{rotIneff:F4},{clutchCount},{rawGrip:F1},{gripVariance:F6}");
        }

        private float CalculatePathInefficiency()
        {
            return optimalPathLength > 0.001f ? (accumulatedPathLength / optimalPathLength) : 1f;
        }

        private float CalculateRotationInefficiency()
        {
            return optimalRotationAngle > 0.001f ? (accumulatedRotation / optimalRotationAngle) : 1f;
        }

        #endregion
    }
}
