using _WavesCounter.Scripts.Ui.Cutscenes.Base;
using _WavesCounter.Scripts.Utilities;
using UnityEngine;

namespace _WavesCounter.Scripts.Ui
{
    public class UiCutscenesRoot : MonoBehaviour, IReturnableByType<UiCutscene>
    {
        [SerializeField] private UiCutscene[] _uiCutscenes;
        
        public T GetItem<T>() where T : UiCutscene
        {
            for (int i = 0; i < _uiCutscenes.Length; i++)
            {
                if (_uiCutscenes[i].GetType() == typeof(T))
                {
                    return _uiCutscenes[i] as T;
                }
            }
            
            return null;
        }
    }
}