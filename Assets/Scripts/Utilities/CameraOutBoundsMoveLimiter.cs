using UnityEngine;

namespace Utilities
{
    public class CameraOutBoundsMoveLimiter : MonoBehaviour
    {
        [SerializeField] private Vector3 _leftBottomLimitPoint;
        [SerializeField] private Vector3 _rightTopLimitPoint;

        public void TryRestrictMovement(Transform restrictedTransform)
        {
            Vector3 clampedPosition = restrictedTransform.position;
            
            clampedPosition.x = Mathf.Clamp(clampedPosition.x, _leftBottomLimitPoint.x, _rightTopLimitPoint.x);
            clampedPosition.z = Mathf.Clamp(clampedPosition.z, _leftBottomLimitPoint.z, _rightTopLimitPoint.z);
            
            restrictedTransform.position = clampedPosition;
        }
    }
}