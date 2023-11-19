using System;
using DG.Tweening;
using UnityEngine;

namespace AbstractFactory
{
    public class Feedback
    {
        public void onEatAnimation(Transform transform, Action onFinishedAnimation)
        {
            transform.DOLocalMoveY(1f, 0.5f).SetEase(Ease.OutQuad).OnComplete(() =>
            {
                transform.DOShakePosition(0.5f, 0.5f, 10, 90f, false, true);
                transform.DOScale(0f, 0.5f).SetEase(Ease.InQuad).OnComplete(() =>
                {
                    onFinishedAnimation?.Invoke();
                });
            });
        }
    }
}