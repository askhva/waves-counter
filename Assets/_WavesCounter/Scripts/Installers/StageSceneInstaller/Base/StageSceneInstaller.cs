using _WavesCounter.Scripts.Characters.Player;
using _WavesCounter.Scripts.Configs.StageSceneInstallers.Base;
using _WavesCounter.Scripts.Stages.ArenaStages.Base;
using _WavesCounter.Scripts.Ui;
using _WavesCounter.Scripts.Ui.Windows;
using UnityEngine;
using Zenject;

namespace _WavesCounter.Scripts.Installers.StageSceneInstaller.Base
{
    public abstract class StageSceneInstaller : MonoInstaller
    {
        [SerializeField] private StageSceneInstallerConfig _stageSceneInstallerConfig;
        
        private ArenaStage _arenaStage;
        private PlayerCharacter _playerCharacter;
        private UiWindowsRoot _uiWindowsRoot;

        [Inject]
        private void Construct(PlayerCharacter playerCharacter, UiWindowsRoot uiWindowsRoot)
        {
            _playerCharacter = playerCharacter;
            _uiWindowsRoot = uiWindowsRoot;
        }
        
        public override void Start()
        {
            _arenaStage = Container.InstantiatePrefabForComponent<ArenaStage>(_stageSceneInstallerConfig.ArenaStagePrefab);
            _playerCharacter.Prepare(_arenaStage.PlayerSpawnPoint);
            _uiWindowsRoot.GetItem<InGameInputUiWindow>().Show();
            
            OnStageStart();
        }

        private void OnDestroy()
        {
            _playerCharacter.Disable();
            _uiWindowsRoot.GetItem<InGameInputUiWindow>().Hide();
        }

        protected abstract void OnStageStart();
    }
}