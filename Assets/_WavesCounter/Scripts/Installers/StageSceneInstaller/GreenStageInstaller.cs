using _WavesCounter.Scripts.Characters.Player;
using Zenject;

namespace _WavesCounter.Scripts.Installers.StageSceneInstaller
{
    public class GreenStageInstaller : Base.StageSceneInstaller
    {
        private PlayerCharacter _playerCharacter;
        
        [Inject]
        private void Construct(PlayerCharacter playerCharacter)
        {
            _playerCharacter = playerCharacter;
        }
        
        public override void InstallBindings()
        {
            
        }

        protected override void OnStageStart()
        {
            _playerCharacter.Prepare(ArenaStage.PlayerSpawnPoint);
        }
    }
}