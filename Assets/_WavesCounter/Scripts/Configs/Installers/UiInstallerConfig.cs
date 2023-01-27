using _WavesCounter.Scripts.Configs.Installers.Base;
using _WavesCounter.Scripts.Ui;
using UnityEngine;

namespace _WavesCounter.Scripts.Configs.Installers
{
    [CreateAssetMenu(fileName = "UiInstallerConfig", menuName = "Configs/Installers/UiInstallerConfig")]
    public class UiInstallerConfig : InstallerConfig
    {
        [SerializeField] private UiWindowsRoot _uiWindowsRootPrefab;
        [SerializeField] private UiCutscenesRoot _uiCutscenesRootPrefab;
        
        public UiWindowsRoot UiWindowsRootPrefab => _uiWindowsRootPrefab;
        public UiCutscenesRoot UiCutscenesRootPrefab => _uiCutscenesRootPrefab;
    }
}