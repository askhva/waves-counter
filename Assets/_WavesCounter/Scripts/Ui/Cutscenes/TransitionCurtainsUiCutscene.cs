using _WavesCounter.Scripts.Ui.Cutscenes.Base;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

namespace _WavesCounter.Scripts.Ui.Cutscenes
{
    public class TransitionCurtainsUiCutscene : UiCutscene
    {
        [SerializeField] private Image _leftCurtainImage;
        [SerializeField] private Image _rightCurtainImage;
        [SerializeField] private Transform _leftClosePointTransform;
        [SerializeField] private Transform _rightClosePointTransform;
        [SerializeField] private Transform _leftOpenPointTransform;
        [SerializeField] private Transform _rightOpenPointTransform;

        public Tween CloseCurtains(float duration = 0.5f)
        {
            gameObject.SetActive(true);
            
            return  DOTween.Sequence()
                .Append(_leftCurtainImage.transform.DOMove(_leftClosePointTransform.position, duration).SetEase(Ease.InQuart))
                .Join(_rightCurtainImage.transform.DOMove(_rightClosePointTransform.position, duration).SetEase(Ease.InQuart));
        }

        public Tween OpenCurtains(float duration = 0.5f)
        {
            return DOTween.Sequence()
                .Append(_leftCurtainImage.transform.DOMove(_leftOpenPointTransform.position, duration).SetEase(Ease.OutQuart))
                .Join(_rightCurtainImage.transform.DOMove(_rightOpenPointTransform.position, duration).SetEase(Ease.OutQuart))
                .AppendCallback(() => gameObject.SetActive(false));
        }
    }
}