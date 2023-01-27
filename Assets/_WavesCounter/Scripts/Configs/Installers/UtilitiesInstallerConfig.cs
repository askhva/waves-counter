using _WavesCounter.Scripts.Configs.Installers.Base;
using UnityEngine;

namespace _WavesCounter.Scripts.Configs.Installers
{
    [CreateAssetMenu(fileName = "UtilitiesInstallerConfig", menuName = "Configs/Installers/UtilitiesInstallerConfig")]
    public class UtilitiesInstallerConfig : InstallerConfig
    {
        [SerializeField] private Camera _cameraPrefab;

        public Camera CameraPrefab => _cameraPrefab;
    }
}