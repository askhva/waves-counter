using _WavesCounter.Scripts.Characters.Player;
using _WavesCounter.Scripts.Utilities;
using UnityEngine;
using Zenject;

namespace _WavesCounter.Scripts.Installers
{
    public class ProjectInstaller : MonoInstaller
    {
        [SerializeField] private PlayerCharacter _playerCharacterPrefab;
        
        public override void InstallBindings()
        {
            Container.Bind<PlayerCharacter>().FromComponentInNewPrefab(_playerCharacterPrefab).AsSingle().NonLazy();
            Container.Bind<CameraOutBoundsMoveLimiter>().AsSingle();
        }
    }
}