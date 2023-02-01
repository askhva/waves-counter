using _WavesCounter.Scripts.Configs.Installers;
using UnityEngine;
using Zenject;

namespace _WavesCounter.Scripts.Installers.ProjectInstallers.Base
{
    public class ProjectInstaller : MonoInstaller
    {
        [SerializeField] private Canvas _overlayCanvas;
        [SerializeField] private CharactersInstallerConfig _charactersInstallerConfig;
        [SerializeField] private UiInstallerConfig _uiInstallerConfig;
        [SerializeField] private UtilitiesInstallerConfig _utilitiesInstallerConfig;
        
        public override void InstallBindings()
        {
            CharactersInstaller.Install(Container, _charactersInstallerConfig);
            UiInstaller.Install(Container, _overlayCanvas, _uiInstallerConfig);
            UtilitiesInstaller.Install(Container, _utilitiesInstallerConfig);
        }
    }
}