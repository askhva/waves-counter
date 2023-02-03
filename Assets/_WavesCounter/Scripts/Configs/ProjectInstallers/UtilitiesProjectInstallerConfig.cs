using _WavesCounter.Scripts.Configs.ProjectInstallers.Base;
using UnityEngine;

namespace _WavesCounter.Scripts.Configs.ProjectInstallers
{
    [CreateAssetMenu(fileName = "UtilitiesProjectInstallerConfig", 
        menuName = "Configs/ProjectInstallers/UtilitiesInstallerConfig")]
    public class UtilitiesProjectInstallerConfig : ProjectInstallerConfig
    {
        [SerializeField] private Camera _cameraPrefab;

        public Camera CameraPrefab => _cameraPrefab;
    }
}