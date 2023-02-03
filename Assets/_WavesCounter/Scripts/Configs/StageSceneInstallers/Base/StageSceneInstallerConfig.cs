using _WavesCounter.Scripts.Stages.ArenaStages.Base;
using UnityEngine;

namespace _WavesCounter.Scripts.Configs.StageSceneInstallers.Base
{
    public abstract class StageSceneInstallerConfig : ScriptableObject
    {
        [SerializeField] private ArenaStage _arenaStagePrefab;
        
        public ArenaStage ArenaStagePrefab => _arenaStagePrefab;
    }
}