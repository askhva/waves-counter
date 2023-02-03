using _WavesCounter.Scripts.Ui.Windows.Base;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace _WavesCounter.Scripts.Ui.Windows
{
    public class InGameInputUiWindow : UiWindow
    {
        [SerializeField] private Button _pauseMenuButton;

        private UiWindowsRoot _uiWindowsRoot;
        
        [Inject]
        private void Construct(UiWindowsRoot uiWindowsRoot)
        {
            _uiWindowsRoot = uiWindowsRoot;
        }
        
        private void Start()
        {
            _pauseMenuButton.onClick.AddListener(OnPauseMenuButtonClick);
        }

        private void OnDestroy()
        {
            _pauseMenuButton.onClick.RemoveListener(OnPauseMenuButtonClick);
        }
        
        public override void Show()
        {
            gameObject.SetActive(true);
        }

        public override void Hide()
        {
            gameObject.SetActive(false);
        }
        
        private void OnPauseMenuButtonClick()
        {
            _uiWindowsRoot.GetItem<PauseMenuUiWindow>().Show();
            Time.timeScale = 0;
        }
    }
}