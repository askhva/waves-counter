using _WavesCounter.Scripts.Characters.Player;
using _WavesCounter.Scripts.Configs.Installers.Base;
using UnityEngine;

namespace _WavesCounter.Scripts.Configs.Installers
{
    [CreateAssetMenu(fileName = "CharactersInstallerConfig", menuName = "Configs/Installers/CharactersInstallerConfig")]
    public class CharactersInstallerConfig : InstallerConfig
    {
        [SerializeField] private PlayerCharacter _playerCharacterPrefab;

        public PlayerCharacter PlayerCharacterPrefab => _playerCharacterPrefab;
    }
}