using UnityEngine;
using UnityEngine.UI;

namespace _WavesCounter.Scripts.Ui.MainMenu
{
    public class MainGameMenu : MonoBehaviour
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
            
        }
        
        private void OnNewGameButtonClick()
        {
            
        }

        private void OnSettingsButtonClick()
        {
            
        }
        
        private void OnExitButtonClick()
        {
            
        }
    }
}