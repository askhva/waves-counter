using _WavesCounter.Scripts.Utilities;
using Zenject;

namespace _WavesCounter.Scripts.Installers
{
    public class StartupInstaller : MonoInstaller
    {
        private ScenesLoader _scenesLoader;
        
        [Inject]
        private void Construct(ScenesLoader scenesLoader)
        {
            _scenesLoader = scenesLoader;
        }

        public override void InstallBindings()
        {
            
        }

        public override void Start()
        {
            _scenesLoader.Load(LoadableScenes.MainMenu);
        }
    }
}