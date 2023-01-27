using _WavesCounter.Scripts.Utilities;
using UnityEngine;
using Zenject;

namespace _WavesCounter.Scripts.Characters.Player
{
    public class PlayerCharacterMovement : MonoBehaviour
    {
        [SerializeField] private CharacterController _characterController;
        [SerializeField] private float _movementSpeed;
        [SerializeField] private float _rotationSpeed;

        private CameraOutBoundsMoveLimiter _moveLimiter;

        [Inject]
        private void Construct(CameraOutBoundsMoveLimiter moveLimiter)
        {
            _moveLimiter = moveLimiter;
        }

        private void Update()
        {
            float horizontal = Input.GetAxis("Horizontal");
            float vertical = Input.GetAxis("Vertical");
            Vector3 direction = new Vector3(horizontal, 0.0f, vertical);
            
            if (direction != Vector3.zero)
            {
                _characterController.Move(direction * _movementSpeed * Time.deltaTime);
                Rotate(direction);
                
                _moveLimiter.RestrictMovement(transform);
            }
        }
        
        private void Rotate(Vector3 direction)
        {
            Quaternion rotationVector = Quaternion.LookRotation(direction);
            float stepValue = _rotationSpeed * Time.deltaTime;
            
            transform.rotation = Quaternion.SlerpUnclamped(transform.rotation, rotationVector, stepValue);
        }
    }
}