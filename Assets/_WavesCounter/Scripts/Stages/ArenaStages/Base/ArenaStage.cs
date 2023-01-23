using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

namespace _WavesCounter.Scripts.Stages.ArenaStages.Base
{
    public abstract class ArenaStage : MonoBehaviour
    {
        [SerializeField] private List<ObstaclesSituationPlan> _obstaclesSituationPlans;
        [SerializeField] private Transform _playerSpawnPointTransform;

        public Vector3 PlayerSpawnPoint => _playerSpawnPointTransform.position;

        private void Start()
        {
            _obstaclesSituationPlans[Random.Range(0, _obstaclesSituationPlans.Count)].gameObject.SetActive(true);
        }

        private void OnDestroy()
        {
            foreach (var plan in _obstaclesSituationPlans)
            {
                plan.gameObject.SetActive(false);
            }
        }
    }
}