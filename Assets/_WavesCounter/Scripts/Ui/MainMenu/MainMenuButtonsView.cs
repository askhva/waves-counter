using DG.Tweening;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace _WavesCounter.Scripts.Ui.MainMenu
{
    public class MainMenuButtonsView : MonoBehaviour, IDragHandler, IBeginDragHandler
    {
        [SerializeField] private VerticalLayoutGroup _verticalGroupContainer;
        [SerializeField] private Transform _viewTargetPointTransform;
        [SerializeField] private Image _indicatorTopArrowImage;
        [SerializeField] private Image _indicatorBotArrowImage;
        [SerializeField] private Button[] _buttons;
        
        private float _buttonsSpacingOffset;
        private int _buttonsCounter;
        private int _previousButtonNumber;
        
        private void Start()
        {
            _buttonsCounter = 1;
            _buttonsSpacingOffset = _verticalGroupContainer.spacing + 
                                    _buttons[_buttonsCounter].GetComponent<RectTransform>().rect.height;
            Move();
            Show();
        }
        
        public void OnBeginDrag(PointerEventData eventData)
        {
            if (eventData.delta.y > 0)
            {
                if (_buttonsCounter > 0)
                {
                    _previousButtonNumber = _buttonsCounter--;
                    
                    Move();
                    Show();
                }
            }
            else
            {
                if (_buttonsCounter < _buttons.Length - 1)
                {
                    _previousButtonNumber = _buttonsCounter++;
                    
                    Move();
                    Show();
                }
            }
        }

        public void OnDrag(PointerEventData eventData)
        {
            
        }

        private void Move()
        {
            Vector3 targetPosition = _viewTargetPointTransform.localPosition;
            
            targetPosition.y = _buttonsSpacingOffset * _buttonsCounter;
            _viewTargetPointTransform.localPosition = targetPosition;
            
            _verticalGroupContainer.transform.DOMove(_viewTargetPointTransform.position, 0.5f).SetEase(Ease.OutBack);
        }

        private void Show()
        {
            _buttons[_previousButtonNumber].targetGraphic.DOFade(0.0f, 0.25f).SetEase(Ease.OutBack);
            _buttons[_previousButtonNumber].interactable = false;
            
            _buttons[_buttonsCounter].targetGraphic.DOFade(1.0f, 0.25f).SetEase(Ease.InBack);
            _buttons[_buttonsCounter].interactable = true;
            
            _indicatorTopArrowImage.DOFade(_buttonsCounter > 0 ? 0.5f : 0.0f, 0.25f);
            _indicatorBotArrowImage.DOFade(_buttonsCounter < _buttons.Length - 1 ? 0.5f : 0.0f, 0.25f);
        }
    }
}