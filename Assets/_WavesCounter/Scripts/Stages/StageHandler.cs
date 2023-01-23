using _WavesCounter.Scripts.Characters.Player;
using _WavesCounter.Scripts.Stages.ArenaStages.Base;

namespace _WavesCounter.Scripts.Stages
{
    public sealed class StageHandler
    {
        private PlayerCharacter _playerCharacter;
        private ArenaStage _arenaStage;
        
        public StageHandler(PlayerCharacter playerCharacter, ArenaStage arenaStage)
        {
            _playerCharacter = playerCharacter;
            _arenaStage = arenaStage;
            
            _playerCharacter.Prepare(_arenaStage.PlayerSpawnPoint);
        }
    }
}