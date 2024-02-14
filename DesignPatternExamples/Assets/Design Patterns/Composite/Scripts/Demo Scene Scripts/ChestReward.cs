using UnityEngine;
using ScriptableVariable;
using System.Collections.Generic;
using System.Collections;
using UnityEngine.Events;

namespace Composite
{
    public class ChestReward : MonoBehaviour
    {
        [SerializeField] private IntVariable _totalChests;
        [SerializeField] private List<Chest> _chestList;
        [SerializeField] private Animator _chestAnimator;
        [SerializeField] private ParticleBurst _particleBurst;
        [SerializeField] private UnityEvent _onStartedChestOpen;
        [SerializeField] private UnityEvent _onFinishedChestOpen;
        private const string _chestAnimation = "OpeningChest";
        private const float _chestRewardDelay = 2f;

        public void OpenChest()
        {
            Chest chest = _chestList[Random.Range(0, _chestList.Count)];

            StartCoroutine(OpenChestRoutine(chest));
        }

        private IEnumerator OpenChestRoutine(Chest chest)
        {
            yield return new WaitForSeconds(PlayChestAnimation());
            _onStartedChestOpen?.Invoke();
            _totalChests.Value--;
            chest.Reclaim();
            ClaimCoinsFound(chest);
            yield return new WaitForSeconds(_chestRewardDelay);
            _onFinishedChestOpen?.Invoke();
        }

        public float PlayChestAnimation()
        {
            float animationLength = _chestAnimator.GetCurrentAnimatorStateInfo(0).length;
            float halfOfAnimationTime = animationLength * 0.5f;

            _chestAnimator.Play(_chestAnimation);
            return halfOfAnimationTime;
        }

        private void ClaimCoinsFound(Chest chest)
        {
            if (chest.CoinsFound > 0)
            {
                _particleBurst.BurstCoins(chest.CoinsFound);
            }
        }
    }
}
