using _WavesCounter.Scripts.Configs.ProjectInstallers;
using UnityEngine;
using Zenject;

namespace _WavesCounter.Scripts.Installers.ProjectInstallers.Base
{
    public class ProjectInstaller : MonoInstaller
    {
        [SerializeField] private Canvas _overlayCanvas;
        [SerializeField] private CharactersProjectInstallerConfig _charactersProjectInstallerConfig;
        [SerializeField] private UiProjectInstallerConfig _uiProjectInstallerConfig;
        [SerializeField] private UtilitiesProjectInstallerConfig _utilitiesProjectInstallerConfig;
        
        public override void InstallBindings()
        {
            CharactersInstaller.Install(Container, _charactersProjectInstallerConfig);
            UiInstaller.Install(Container, _overlayCanvas, _uiProjectInstallerConfig);
            UtilitiesInstaller.Install(Container, _utilitiesProjectInstallerConfig);
        }
    }
}