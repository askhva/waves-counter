using _WavesCounter.Scripts.Characters.Player;
using _WavesCounter.Scripts.Configs.ProjectInstallers;
using Zenject;

namespace _WavesCounter.Scripts.Installers.ProjectInstallers
{
    public class CharactersInstaller : Installer<CharactersProjectInstallerConfig, CharactersInstaller>
    {
        private CharactersProjectInstallerConfig _charactersProjectInstallerConfig;

        public CharactersInstaller(CharactersProjectInstallerConfig charactersProjectInstallerConfig)
        {
            _charactersProjectInstallerConfig = charactersProjectInstallerConfig;
        }
        
        public override void InstallBindings()
        {
            Container.Bind<PlayerCharacter>().FromComponentInNewPrefab(_charactersProjectInstallerConfig.PlayerCharacterPrefab)
                .AsSingle().NonLazy();
        }
    }
}