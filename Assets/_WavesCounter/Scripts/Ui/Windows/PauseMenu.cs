using _WavesCounter.Scripts.Utilities;
using DG.Tweening;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace _WavesCounter.Scripts.Ui.PauseMenu
{
    public class PauseMenu : MonoBehaviour
    {
        [SerializeField] private Button _pauseMenuButton;
        [SerializeField] private Button _continueButton;
        [SerializeField] private Button _settingsButton;
        [SerializeField] private Button _exitMainMenuButton;
        [SerializeField] private Transform _pauseMenuViewTransform;
        [SerializeField] private Image _backgroundImage;

        private void Start()
        {
            _pauseMenuButton.onClick.AddListener(OnPauseMenuButtonClick);
            _continueButton.onClick.AddListener(OnContinueButtonClick);
            _settingsButton.onClick.AddListener(OnSettingsButtonClick);
            _exitMainMenuButton.onClick.AddListener(OnExitMenuButtonClick);
        }

        private void OnDestroy()
        {
            _pauseMenuButton.onClick.RemoveListener(OnPauseMenuButtonClick);
            _continueButton.onClick.RemoveListener(OnContinueButtonClick);
            _settingsButton.onClick.RemoveListener(OnSettingsButtonClick);
            _exitMainMenuButton.onClick.RemoveListener(OnExitMenuButtonClick);
        }

        private void OnPauseMenuButtonClick()
        {
            _pauseMenuViewTransform.gameObject.SetActive(true);
            _backgroundImage.DOFade(0.75f, 0.25f).SetUpdate(UpdateType.Normal, true);
            Time.timeScale = 0;
        }
        
        private void OnContinueButtonClick()
        {
            _pauseMenuViewTransform.gameObject.SetActive(false);
            _backgroundImage.DOFade(0.0f, 0.0f);
            Time.timeScale = 1;
        }
        
        private void OnSettingsButtonClick()
        {
            Debug.LogError("SETTINGS_NOT_IMPLEMENTED_YET");
        }
        
        private void OnExitMenuButtonClick()
        {
            SceneManager.LoadScene((int) LoadableScenes.MainMenu);
        }
    }
}