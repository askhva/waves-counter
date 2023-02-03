using _WavesCounter.Scripts.Ui.Windows.Base;
using _WavesCounter.Scripts.Utilities;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace _WavesCounter.Scripts.Ui.Windows
{
    public class PauseMenuUiWindow : UiWindow
    {
        [SerializeField] private Button _continueButton;
        [SerializeField] private Button _settingsButton;
        [SerializeField] private Button _exitMainMenuButton;
        [SerializeField] private Image _backgroundImage;

        private ScenesLoader _scenesLoader;
        
        [Inject]
        private void Construct(ScenesLoader scenesLoader)
        {
            _scenesLoader = scenesLoader;
        }
        
        private void Start()
        {
            _continueButton.onClick.AddListener(OnContinueButtonClick);
            _settingsButton.onClick.AddListener(OnSettingsButtonClick);
            _exitMainMenuButton.onClick.AddListener(OnExitMenuButtonClick);
        }

        private void OnDestroy()
        {
            _continueButton.onClick.RemoveListener(OnContinueButtonClick);
            _settingsButton.onClick.RemoveListener(OnSettingsButtonClick);
            _exitMainMenuButton.onClick.RemoveListener(OnExitMenuButtonClick);
        }
        
        public override void Show()
        {
            gameObject.SetActive(true);
            _backgroundImage.DOFade(0.75f, 0.25f).SetUpdate(UpdateType.Normal, true);
        }

        public override void Hide()
        {
            _backgroundImage.DOFade(0.0f, 0.0f);
            gameObject.SetActive(false);
        }

        private void OnContinueButtonClick()
        {
            Time.timeScale = 1;
            Hide();
        }
        
        private void OnSettingsButtonClick()
        {
            Debug.LogError("SETTINGS_NOT_IMPLEMENTED_YET");
        }
        
        private void OnExitMenuButtonClick()
        {
            Time.timeScale = 1;
            Hide();
            _scenesLoader.Load(LoadableScenes.MainMenu);
        }
    }
}