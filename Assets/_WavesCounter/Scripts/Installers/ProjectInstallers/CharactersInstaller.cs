using _WavesCounter.Scripts.Characters.Player;
using _WavesCounter.Scripts.Configs.Installers;
using Zenject;

namespace _WavesCounter.Scripts.Installers.ProjectInstallers
{
    public class CharactersInstaller : Installer<CharactersInstallerConfig, CharactersInstaller>
    {
        private CharactersInstallerConfig _charactersInstallerConfig;

        public CharactersInstaller(CharactersInstallerConfig charactersInstallerConfig)
        {
            _charactersInstallerConfig = charactersInstallerConfig;
        }
        
        public override void InstallBindings()
        {
            Container.Bind<PlayerCharacter>().FromComponentInNewPrefab(_charactersInstallerConfig.PlayerCharacterPrefab)
                .AsSingle().NonLazy();
        }
    }
}