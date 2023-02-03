using _WavesCounter.Scripts.Configs.ProjectInstallers;
using _WavesCounter.Scripts.Ui;
using UnityEngine;
using Zenject;

namespace _WavesCounter.Scripts.Installers.ProjectInstallers
{
    public class UiInstaller : Installer<Canvas, UiProjectInstallerConfig, UiInstaller>
    {
        private Canvas _overlayCanvas;
        private UiProjectInstallerConfig _uiProjectInstallerConfig;

        public UiInstaller(Canvas overlayCanvas, UiProjectInstallerConfig uiProjectInstallerConfig)
        {
            _overlayCanvas = overlayCanvas;
            _uiProjectInstallerConfig = uiProjectInstallerConfig;
        }
        
        public override void InstallBindings()
        {
            Container.Bind<UiWindowsRoot>().FromComponentInNewPrefab(_uiProjectInstallerConfig.UiWindowsRootPrefab)
                .UnderTransform(_overlayCanvas.transform).AsSingle().NonLazy();
            Container.Bind<UiCutscenesRoot>().FromComponentInNewPrefab(_uiProjectInstallerConfig.UiCutscenesRootPrefab)
                .UnderTransform(_overlayCanvas.transform).AsSingle().NonLazy();
        }
    }
}