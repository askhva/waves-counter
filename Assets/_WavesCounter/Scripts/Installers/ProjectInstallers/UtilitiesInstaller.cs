using _WavesCounter.Scripts.Configs.Installers;
using _WavesCounter.Scripts.Utilities;
using UnityEngine;
using Zenject;

namespace _WavesCounter.Scripts.Installers.ProjectInstallers
{
    public class UtilitiesInstaller : Installer<UtilitiesInstallerConfig, UtilitiesInstaller>
    {
        private UtilitiesInstallerConfig _utilitiesInstallerConfig;
        
        public UtilitiesInstaller(UtilitiesInstallerConfig utilitiesInstallerConfig)
        {
            _utilitiesInstallerConfig = utilitiesInstallerConfig;
        }
        
        public override void InstallBindings()
        {
            Container.Bind<Camera>().FromComponentInNewPrefab(_utilitiesInstallerConfig.CameraPrefab).AsSingle();
            Container.Bind<CameraOutBoundsMoveLimiter>().AsSingle();
            Container.Bind<ScenesLoader>().AsSingle();
        }
    }
}