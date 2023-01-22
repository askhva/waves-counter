using UnityEngine;

namespace _WavesCounter.Scripts.Utilities
{
    public class CameraOutBoundsMoveLimiter : MonoBehaviour
    {
        [SerializeField] private Vector2 _leftBottomLimitPoint;
        [SerializeField] private Vector2 _rightTopLimitPoint;
        
        public void TryRestrictMovement(Transform restrictedTransform)
        {
            Vector3 clampedPosition = restrictedTransform.position;
            
            clampedPosition.x = Mathf.Clamp(clampedPosition.x, _leftBottomLimitPoint.x, _rightTopLimitPoint.x);
            clampedPosition.z = Mathf.Clamp(clampedPosition.z, _leftBottomLimitPoint.y, _rightTopLimitPoint.y);
            
            restrictedTransform.position = clampedPosition;
        }
    }
}