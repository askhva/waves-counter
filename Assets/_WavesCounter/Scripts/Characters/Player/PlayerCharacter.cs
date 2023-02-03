using UnityEngine;

namespace _WavesCounter.Scripts.Characters.Player
{
    public class PlayerCharacter : MonoBehaviour
    {
        public void Prepare(Vector3 startPosition)
        {
            gameObject.SetActive(true);
            transform.position = startPosition;
        }

        public void Disable()
        {
            transform.rotation = Quaternion.identity;
            gameObject.SetActive(false);
        }
    }
}