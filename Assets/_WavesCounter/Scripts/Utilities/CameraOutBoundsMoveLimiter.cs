using UnityEngine;

namespace _WavesCounter.Scripts.Utilities
{
    public class CameraOutBoundsMoveLimiter
    {
        private Camera _camera;

        public CameraOutBoundsMoveLimiter()
        {
            _camera = Camera.main;
        }
        
        public void RestrictMovement(Transform restrictedTransform)
        {
            Vector3 cameraPosition = _camera.transform.position;
            float cameraDistance = Mathf.Sqrt(Mathf.Pow(cameraPosition.y, 2) + Mathf.Pow(cameraPosition.z, 2));
            
            Vector3 leftBottomLimitPoint  = _camera.ViewportToWorldPoint(new Vector3(0, 0, cameraDistance - _camera.orthographicSize));
            Vector3 rightTopLimitPoint = _camera.ViewportToWorldPoint(new Vector3(1, 1, cameraDistance + _camera.orthographicSize));

            Vector3 clampedPosition = restrictedTransform.position;
            
            clampedPosition.x = Mathf.Clamp(clampedPosition.x, leftBottomLimitPoint.x, rightTopLimitPoint.x);
            clampedPosition.z = Mathf.Clamp(clampedPosition.z, leftBottomLimitPoint.z, rightTopLimitPoint.z);
            
            restrictedTransform.position = clampedPosition;
        }
    }
}