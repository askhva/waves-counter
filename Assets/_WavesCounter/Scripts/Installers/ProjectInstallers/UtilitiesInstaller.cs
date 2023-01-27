using _WavesCounter.Scripts.Configs.Installers;
using _WavesCounter.Scripts.Utilities;
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
            Container.InstantiatePrefab(_utilitiesInstallerConfig.CameraPrefab);
            Container.Bind<CameraOutBoundsMoveLimiter>().AsSingle();
        }
    }
}