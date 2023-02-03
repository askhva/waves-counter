using _WavesCounter.Scripts.Configs.ProjectInstallers.Base;
using _WavesCounter.Scripts.Ui;
using UnityEngine;

namespace _WavesCounter.Scripts.Configs.ProjectInstallers
{
    [CreateAssetMenu(fileName = "UiProjectInstallerConfig", 
        menuName = "Configs/ProjectInstallers/UiInstallerConfig")]
    public class UiProjectInstallerConfig : ProjectInstallerConfig
    {
        [SerializeField] private UiWindowsRoot _uiWindowsRootPrefab;
        [SerializeField] private UiCutscenesRoot _uiCutscenesRootPrefab;
        
        public UiWindowsRoot UiWindowsRootPrefab => _uiWindowsRootPrefab;
        public UiCutscenesRoot UiCutscenesRootPrefab => _uiCutscenesRootPrefab;
    }
}