using _WavesCounter.Scripts.Utilities;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace _WavesCounter.Scripts.Ui
{
    public class GameMainMenu : MonoBehaviour
    {
        [SerializeField] private Button _continueButton;
        [SerializeField] private Button _newGameButton;
        [SerializeField] private Button _settingsButton;
        [SerializeField] private Button _exitButton;

        private void Start()
        {
            _continueButton.onClick.AddListener(OnContinueButtonClick);
            _newGameButton.onClick.AddListener(OnNewGameButtonClick);
            _settingsButton.onClick.AddListener(OnSettingsButtonClick);
            _exitButton.onClick.AddListener(OnExitButtonClick);
        }

        private void OnDestroy()
        {
            _continueButton.onClick.RemoveListener(OnContinueButtonClick);
            _newGameButton.onClick.RemoveListener(OnNewGameButtonClick);
            _settingsButton.onClick.RemoveListener(OnSettingsButtonClick);
            _exitButton.onClick.RemoveListener(OnExitButtonClick);
        }

        private void OnContinueButtonClick()
        {
            Debug.LogError("CONTINUE_GAME_NOT_IMPLEMENTED_YET");
        }
        
        private void OnNewGameButtonClick()
        {
            SceneManager.LoadScene((int) LoadableScenes.GreenStage);
        }

        private void OnSettingsButtonClick()
        {
            Debug.LogError("SETTINGS_NOT_IMPLEMENTED_YET");
        }
        
        private void OnExitButtonClick()
        {
            Application.Quit();
        }
    }
}