using _WavesCounter.Scripts.Ui.Cutscenes.Base;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;

namespace _WavesCounter.Scripts.Ui.Cutscenes
{
    public class LoadingUiCutscene : UiCutscene
    {
        [SerializeField] private Image _loadingProgressBarImage;
        [SerializeField] private int _minStepsValue;
        [SerializeField] private int _maxStepsValue;
        [SerializeField] private float _minTimePerStepValue;
        [SerializeField] private float _maxTimePerStepValue;

        public Tween Show(AsyncOperation asyncOperation = null)
        {
            return asyncOperation == null ? GetFakeLoading() : GetLoading(asyncOperation);
        }

        private Tween GetFakeLoading()
        {
            int stepsCount = Random.Range(_minStepsValue, _maxStepsValue);
            float valuePerStep = 1.0f / stepsCount;
            Sequence loadingSequence = DOTween.Sequence();
            
            gameObject.SetActive(true);
            _loadingProgressBarImage.fillAmount = 0.0f;
            
            for (int i = 0; i < stepsCount; i++)
            {
                float fillingTime = Random.Range(_minTimePerStepValue, _maxTimePerStepValue);
                float targetValue = valuePerStep * (i + 1);

                loadingSequence
                    .Append(_loadingProgressBarImage.DOFillAmount(targetValue, fillingTime));
            }

            loadingSequence.AppendCallback(() => gameObject.SetActive(false));

            return loadingSequence;
        }

        private Tween GetLoading(AsyncOperation asyncOperation)
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