using UnityEngine;

namespace Characters
{
    public class MovementHandler
    {
        private Rigidbody _rigidbody;

        public MovementHandler(Rigidbody rigidbody)
        {
            _rigidbody = rigidbody;
        }

        public void Move(Vector3 direction, float moveSpeed)
        {
            float stepValue = moveSpeed * Time.deltaTime;
            
            _rigidbody.MovePosition(_rigidbody.position + direction * stepValue);
        }

        public void Rotate(Vector3 direction, float rotationSpeed)
        {
            Quaternion rotationVector = Quaternion.LookRotation(direction);
            float stepValue = rotationSpeed * Time.deltaTime;
            
            _rigidbody.MoveRotation(Quaternion.SlerpUnclamped(_rigidbody.rotation, rotationVector, stepValue));
        }
    }
}