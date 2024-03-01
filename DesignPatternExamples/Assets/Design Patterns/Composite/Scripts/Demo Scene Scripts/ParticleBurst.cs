using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace Composite
{
    public class ParticleBurst : MonoBehaviour
    {
        [SerializeField] private ParticleSystem _burstParticle;
        [SerializeField] private Sprite _coinTexture;
        [SerializeField] private Sprite _chestTexture;

        public void BurstCoins(int ParticleAmount) => Burst(ParticleAmount, _coinTexture);
        public void BurstChests(int ParticleAmount) => Burst(ParticleAmount, _chestTexture);

        private void Burst(int particleAmount, Sprite particleTexture)
        {
            float particleDuration = _burstParticle.main.duration;
            StartCoroutine(BurstRoutine(particleAmount, particleTexture, particleDuration, _burstParticle));
        }

        private IEnumerator BurstRoutine(int particleAmount, Sprite particleTexture, float particleDuration, ParticleSystem burstParticle)
        {
            ParticleSystem.EmissionModule emission = burstParticle.emission;
            emission.rateOverTime = particleAmount;
            burstParticle.textureSheetAnimation.SetSprite(0, particleTexture);
            burstParticle.Play();

            yield return new WaitForSeconds(particleDuration);
        }
    }
}
