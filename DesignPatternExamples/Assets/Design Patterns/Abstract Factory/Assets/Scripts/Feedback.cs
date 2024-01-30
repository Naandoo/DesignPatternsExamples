using System;
using DG.Tweening;
using UnityEngine;

namespace AbstractFactory
{
    public class Feedback
    {
        public void OnEatAnimation(Transform transform, Action onFinishedAnimation)
        {
            transform.DOLocalMoveY(transform.position.y + 0.75f, 0.5f).SetEase(Ease.OutQuad).OnComplete(() =>
            {
                transform.DOScale(0f, 0.5f).SetEase(Ease.InQuad).OnComplete(() =>
                {
                    onFinishedAnimation?.Invoke();
                });
            });
        }
    }
}