using _WavesCounter.Scripts.Configs.Installers;
using _WavesCounter.Scripts.Ui;
using UnityEngine;
using Zenject;

namespace _WavesCounter.Scripts.Installers.ProjectInstallers
{
    public class UiInstaller : Installer<Canvas, UiInstallerConfig, UiInstaller>
    {
        private Canvas _overlayCanvas;
        private UiInstallerConfig _uiInstallerConfig;

        public UiInstaller(Canvas overlayCanvas, UiInstallerConfig uiInstallerConfig)
        {
            _overlayCanvas = overlayCanvas;
            _uiInstallerConfig = uiInstallerConfig;
        }
        
        public override void InstallBindings()
        {
            Container.Bind<UiWindowsRoot>().FromComponentInNewPrefab(_uiInstallerConfig.UiWindowsRootPrefab)
                .UnderTransform(_overlayCanvas.transform).AsSingle().NonLazy();
            Container.Bind<UiCutscenesRoot>().FromComponentInNewPrefab(_uiInstallerConfig.UiCutscenesRootPrefab)
                .UnderTransform(_overlayCanvas.transform).AsSingle().NonLazy();
        }
    }
}