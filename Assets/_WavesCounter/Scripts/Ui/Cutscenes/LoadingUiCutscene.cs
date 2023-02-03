using _WavesCounter.Scripts.Ui.Cutscenes.Base;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

namespace _WavesCounter.Scripts.Ui.Cutscenes
{
    public class LoadingUiCutscene : UiCutscene
    {
        [SerializeField] private Image _loadingProgressBarImage;

        public Tween Show(AsyncOperation asyncOperation)
        {
            Sequence loadingSequence = DOTween.Sequence();
            asyncOperation.allowSceneActivation = false;

            loadingSequence
                .AppendCallback(() =>
                {
                    _loadingProgressBarImage.fillAmount = asyncOperation.progress;
                    
                    if (asyncOperation.progress >= 0.9f)
                    {
                        asyncOperation.allowSceneActivation = true;
                        loadingSequence.Kill();
                    }
                })
                .SetLoops(-1);

            return loadingSequence;
        }
    }
}