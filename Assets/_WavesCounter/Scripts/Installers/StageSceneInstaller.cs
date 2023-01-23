using _WavesCounter.Scripts.Stages;
using _WavesCounter.Scripts.Stages.ArenaStages.Base;
using UnityEngine;
using Zenject;

namespace _WavesCounter.Scripts.Installers
{
    public class StageSceneInstaller : MonoInstaller
    {
        [SerializeField] private ArenaStage _arenaStagePrefab;
        
        public override void InstallBindings()
        {
            Container.Bind<ArenaStage>().FromComponentInNewPrefab(_arenaStagePrefab).AsSingle().NonLazy();
            Container.Bind<StageHandler>().AsSingle().NonLazy();
        }
    }
}