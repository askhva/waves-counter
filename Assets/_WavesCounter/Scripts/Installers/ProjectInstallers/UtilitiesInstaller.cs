using _WavesCounter.Scripts.Configs.ProjectInstallers;
using _WavesCounter.Scripts.Utilities;
using UnityEngine;
using Zenject;

namespace _WavesCounter.Scripts.Installers.ProjectInstallers
{
    public class UtilitiesInstaller : Installer<UtilitiesProjectInstallerConfig, UtilitiesInstaller>
    {
        private UtilitiesProjectInstallerConfig _utilitiesProjectInstallerConfig;
        
        public UtilitiesInstaller(UtilitiesProjectInstallerConfig utilitiesProjectInstallerConfig)
        {
            _utilitiesProjectInstallerConfig = utilitiesProjectInstallerConfig;
        }
        
        public override void InstallBindings()
        {
            Container.Bind<Camera>().FromComponentInNewPrefab(_utilitiesProjectInstallerConfig.CameraPrefab).AsSingle();
            Container.Bind<CameraOutBoundsMoveLimiter>().AsSingle();
            Container.Bind<ScenesLoader>().AsSingle();
        }
    }
}