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
        private List<ParticleSystem> _particleSystems = new List<ParticleSystem>();
        private int _burstParticleAmount = 30;

        private void Start()
        {
            for (int i = 0; i < _burstParticleAmount; i++)
            {
                GenerateNewBurstParticle();
            }
        }

        private void GenerateNewBurstParticle()
        {
            ParticleSystem newParticleSystem = Instantiate(_burstParticle, transform);
            _particleSystems.Add(newParticleSystem);
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.C))
            {
                BurstChests(10);
            }
            if (Input.GetKeyDown(KeyCode.V))
            {
                BurstCoins(10);
            }
        }

        public void BurstCoins(int ParticleAmount) => Burst(ParticleAmount, _coinTexture);
        public void BurstChests(int ParticleAmount) => Burst(ParticleAmount, _chestTexture);

        private void Burst(int particleAmount, Sprite particleTexture)
        {
            if (_particleSystems.Count > 0)
            {
                ParticleSystem burstParticle = _particleSystems[0];
                float particleDuration = burstParticle.main.duration;
                StartCoroutine(BurstRoutine(particleAmount, particleTexture, particleDuration, burstParticle));
            }
            else
            {
                GenerateNewBurstParticle();
                Burst(particleAmount, particleTexture);
            }
        }

        private IEnumerator BurstRoutine(int particleAmount, Sprite particleTexture, float particleDuration, ParticleSystem burstParticle)
        {
            _particleSystems.Remove(burstParticle);

            ParticleSystem.EmissionModule emission = burstParticle.emission;
            emission.rateOverTime = particleAmount;
            burstParticle.textureSheetAnimation.SetSprite(0, particleTexture);
            burstParticle.Play();

            yield return new WaitForSeconds(particleDuration);

            _particleSystems.Add(burstParticle);
        }
    }
}
