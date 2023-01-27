using _WavesCounter.Scripts.Installers.SceneInstallers.Base;
using _WavesCounter.Scripts.ScenesHandle;
using _WavesCounter.Scripts.Ui;
using UnityEngine;

namespace _WavesCounter.Scripts.Installers.SceneInstallers
{
    public class MainMenuInstaller : SceneInstaller
    {
        [SerializeField] private Canvas _cameraCanvas;
        [SerializeField] private GameMainMenu _mainMenu;
        
        public override void InstallBindings()
        {
            Container.BindInterfacesAndSelfTo<MainMenuScene>().AsSingle().WithArguments(_mainMenu, _cameraCanvas);
        }
    }
}