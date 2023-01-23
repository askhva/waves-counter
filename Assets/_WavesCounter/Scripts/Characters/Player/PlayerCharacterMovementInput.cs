using _WavesCounter.Scripts.Utilities;
using UnityEngine;

namespace _WavesCounter.Scripts.Characters.Player
{
    public class PlayerCharacterMovementInput : MonoBehaviour
    {
        [SerializeField] private Rigidbody _rigidbody;
        [SerializeField] private float _moveSpeed;
        [SerializeField] private float _rotationSpeed;

        private CameraOutBoundsMoveLimiter _moveLimiter;
        private MovementHandler _movementHandler;
        
        private void Start()
        {
            _moveLimiter = Camera.main.GetComponent<CameraOutBoundsMoveLimiter>();
            _movementHandler = new MovementHandler(_rigidbody);
        }

        private void Update()
        {
            var horizontal = Input.GetAxis("Horizontal");
            var vertical = Input.GetAxis("Vertical");
            var direction = new Vector3(horizontal, 0.0f, vertical);
            
            if (direction != Vector3.zero)
            {
                _moveLimiter.TryRestrictMovement(transform);
                
                _movementHandler.Move(direction, _moveSpeed);
                _movementHandler.Rotate(direction, _rotationSpeed);
            }
        }
    }
}