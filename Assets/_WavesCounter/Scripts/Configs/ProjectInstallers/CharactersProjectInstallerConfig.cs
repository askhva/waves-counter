using _WavesCounter.Scripts.Characters.Player;
using _WavesCounter.Scripts.Configs.ProjectInstallers.Base;
using UnityEngine;

namespace _WavesCounter.Scripts.Configs.ProjectInstallers
{
    [CreateAssetMenu(fileName = "CharactersProjectInstallerConfig", 
        menuName = "Configs/ProjectInstallers/CharactersInstallerConfig")]
    public class CharactersProjectInstallerConfig : ProjectInstallerConfig
    {
        [SerializeField] private PlayerCharacter _playerCharacterPrefab;

        public PlayerCharacter PlayerCharacterPrefab => _playerCharacterPrefab;
    }
}