using _WavesCounter.Scripts.ScenesHandle.Base;
using _WavesCounter.Scripts.Ui;
using _WavesCounter.Scripts.Ui.Cutscenes;
using DG.Tweening;
using UnityEngine;

namespace _WavesCounter.Scripts.ScenesHandle
{
    public class MainMenuScene : SceneHandle
    {
        private UiCutscenesRoot _uiCutscenesRoot;
        private GameMainMenu _mainMenu;

        public MainMenuScene(UiCutscenesRoot uiCutscenesRoot, GameMainMenu mainMenu, Canvas cameraCanvas)
        {
            _uiCutscenesRoot = uiCutscenesRoot;
            _mainMenu = mainMenu;

            cameraCanvas.worldCamera = Camera.main;
        }

        public override void Initialize()
        {
            var fakeLoadingCutScene = _uiCutscenesRoot.GetItem<FakeLoadingUiCutscene>();
            var transitionCutscene = _uiCutscenesRoot.GetItem<TransitionCurtainsUiCutscene>();

            DOTween.Sequence()
                .Append(fakeLoadingCutScene.Show())
                .Join(transitionCutscene.CloseCurtains())
                .Append(transitionCutscene.OpenCurtains())
                .AppendCallback(() => _mainMenu.gameObject.SetActive(true));
        }

        public override void Dispose()
        {
            
        }
    }
}