using _WavesCounter.Scripts.Ui.Windows.Base;
using _WavesCounter.Scripts.Utilities;
using UnityEngine;

namespace _WavesCounter.Scripts.Ui
{
    public class UiWindowsRoot : MonoBehaviour, IReturnableByType<UiWindow>
    {
        [SerializeField] private UiWindow[] _uiWindows;
        
        public T GetItem<T>() where T : UiWindow
        {
            for (int i = 0; i < _uiWindows.Length; i++)
            {
                if (_uiWindows[i].GetType() == typeof(T))
                {
                    return _uiWindows[i] as T;
                }
            }
            
            return null;
        }
    }
}