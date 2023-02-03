using _WavesCounter.Scripts.Configs.StageSceneInstallers.Base;
using _WavesCounter.Scripts.Stages.ArenaStages.Base;
using UnityEngine;
using Zenject;

namespace _WavesCounter.Scripts.Installers.StageSceneInstaller.Base
{
    public abstract class StageSceneInstaller : MonoInstaller
    {
        [SerializeField] private StageSceneInstallerConfig _stageSceneInstallerConfig;
        
        protected ArenaStage ArenaStage;

        public override void Start()
        {
            ArenaStage = Container.InstantiatePrefabForComponent<ArenaStage>(_stageSceneInstallerConfig.ArenaStagePrefab);
            
            OnStageStart();
        }

        protected abstract void OnStageStart();
    }
}