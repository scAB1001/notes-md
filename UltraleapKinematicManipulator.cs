// Assets/_Project/Scripts/Interaction/UltraleapKinematicManipulator.cs
using UnityEngine;
using Leap;

namespace COMP3932.Interaction
{
    /// <summary>
    /// Proof-of-concept kinematic manipulator. Directly couples Ultraleap
    /// hand tracking to a target mesh transform via a pinch gesture.
    /// Superseded by the modality-agnostic BaseInteractionProvider architecture.
    /// </summary>
    public class UltraleapKinematicManipulator : MonoBehaviour
    {
        [Header("References")]
        [SerializeField] private LeapServiceProvider leapProvider;
        [SerializeField] private Transform targetMesh;

        [Header("Thresholds")]
        [SerializeField] private float grabThreshold    = 0.02f;
        [SerializeField] private float releaseThreshold = 0.05f;

        [Header("Constraints")]
        [SerializeField] private bool allowTranslation = true;
        [SerializeField] private bool allowRotation    = true;

        private bool       isGrabbing;
        private int        activeHandId = -1;
        private Vector3    positionOffset;
        private Quaternion rotationOffset;

        private void Update()
        {
            if (leapProvider.CurrentFrame == null) return;

            if (!isGrabbing) TryBeginGrab(leapProvider.CurrentFrame);
            else             UpdateGrab(leapProvider.CurrentFrame);
        }

        private void TryBeginGrab(Frame frame)
        {
            foreach (Hand hand in frame.Hands)
            {
                if (hand.PinchDistance > grabThreshold) continue;

                activeHandId   = hand.Id;
                isGrabbing     = true;
                positionOffset = targetMesh.position - PinchCenter(hand);
                rotationOffset = Quaternion.Inverse(hand.Rotation) * targetMesh.rotation;
                break;
            }
        }

        private void UpdateGrab(Frame frame)
        {
            Hand hand = frame.Hand(activeHandId);

            if (hand == null || hand.PinchDistance >= releaseThreshold)
            {
                isGrabbing   = false;
                activeHandId = -1;
                return;
            }

            if (allowTranslation) targetMesh.position = PinchCenter(hand) + positionOffset;
            if (allowRotation)    targetMesh.rotation = hand.Rotation * rotationOffset;
        }

        private static Vector3 PinchCenter(Hand hand)
        {
            Vector3 thumb = hand.fingers[(int)Finger.FingerType.THUMB].TipPosition;
            Vector3 index = hand.fingers[(int)Finger.FingerType.INDEX].TipPosition;
            return Vector3.Lerp(thumb, index, 0.5f);
        }
    }
}