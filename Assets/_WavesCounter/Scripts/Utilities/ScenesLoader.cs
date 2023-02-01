using _WavesCounter.Scripts.Ui;
using _WavesCounter.Scripts.Ui.Cutscenes;
using DG.Tweening;
using UnityEngine.SceneManagement;

namespace _WavesCounter.Scripts.Utilities
{
    public enum LoadableScenes
    {
        MainMenu = 1,
        GreenStage = 2,
        YellowStage = 3
    }
    
    public class ScenesLoader
    {
        private LoadingUiCutscene _loadingUiCutscene;
        private TransitionCurtainsUiCutscene _transitionCurtainsUiCutscene;

        public ScenesLoader(UiCutscenesRoot uiCutscenesRoot)
        { 
            _loadingUiCutscene = uiCutscenesRoot.GetItem<LoadingUiCutscene>(); 
            _transitionCurtainsUiCutscene = uiCutscenesRoot.GetItem<TransitionCurtainsUiCutscene>();
        }

        public async void Load(LoadableScenes scene)
        {
            await _transitionCurtainsUiCutscene.CloseCurtains().AsyncWaitForCompletion();
            await _loadingUiCutscene.Show(SceneManager.LoadSceneAsync((int) scene)).AsyncWaitForCompletion();
            await _transitionCurtainsUiCutscene.OpenCurtains().AsyncWaitForCompletion();
        }
    }
}