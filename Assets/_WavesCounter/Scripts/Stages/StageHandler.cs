using _WavesCounter.Scripts.Characters.Player;
using _WavesCounter.Scripts.Stages.ArenaStages.Base;

namespace _WavesCounter.Scripts.Stages
{
    public class StageHandler
    {
        public StageHandler(PlayerCharacter playerCharacter, ArenaStage arenaStage)
        {
            playerCharacter.Prepare(arenaStage.PlayerSpawnPoint);
        }
    }
}