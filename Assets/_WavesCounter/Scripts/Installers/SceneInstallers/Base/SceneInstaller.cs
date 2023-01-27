using _WavesCounter.Scripts.Configs.ScenesConfigs.Base;
using UnityEngine;
using Zenject;

namespace _WavesCounter.Scripts.Installers.SceneInstallers.Base
{
    public abstract class SceneInstaller : MonoInstaller
    {
        [SerializeField] protected SceneConfig _sceneConfig;
    }
}