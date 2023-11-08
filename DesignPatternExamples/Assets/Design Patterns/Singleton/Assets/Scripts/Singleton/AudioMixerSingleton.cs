using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

namespace Singleton
{
    public class AudioMixerSingleton : MonoBehaviour
    {
        [SerializeField] private AudioSource _audioSource;
        [SerializeField] private float _minimumSoundDelayPitch = 2;
        [SerializeField] private float _minimumSoundDelay;
        [SerializeField] private TMP_Text _audioMixerButtonText;
        [SerializeField] private float _minPitch = 0.75f;
        private static AudioMixerSingleton _instance;
        private Dictionary<AudioClip, AudioHistory> _recordedSounds = new();
        private bool _isMixerEnabled = true;
        private float _originalPitch;
        private AudioMixerSingleton() { }

        private void Awake() => _originalPitch = _audioSource.pitch;

        public static AudioMixerSingleton GetInstance()
        {
            if (_instance == null)
            {
                _instance = FindObjectOfType<AudioMixerSingleton>();

                if (_instance == null)
                {
                    GameObject singletonObject = new GameObject("AudioMixerSingleton");
                    _instance = singletonObject.AddComponent<AudioMixerSingleton>();
                    _instance.SetIndestructible();
                }
            }
            return _instance;
        }

        private void SetIndestructible() => DontDestroyOnLoad(gameObject);

        public void Play(AudioClip sound)
        {
            if (_isMixerEnabled)
            {
                if (IsSoundUnavailableToPlay(sound)) return;
                if (PlayPitchIfAvailable(sound)) return;
            }

            NormalizePitch();
            _audioSource.PlayOneShot(sound);
        }

        private bool IsSoundUnavailableToPlay(AudioClip sound)
        {
            if (_recordedSounds.ContainsKey(sound))
            {
                if (Time.time - _recordedSounds[sound].LastTimePlayed < _minimumSoundDelay)
                {
                    _recordedSounds[sound].LastTimePlayed = Time.time;
                    return true;
                }

                _recordedSounds[sound].LastTimePlayed = Time.time;
            }

            else
                _recordedSounds.Add(sound, new AudioHistory { LastTimePlayed = Time.time });

            return false;
        }

        private bool PlayPitchIfAvailable(AudioClip sound)
        {
            if (_recordedSounds.ContainsKey(sound))
            {
                if (Time.time - _recordedSounds[sound].LastTimePlayedOnPitch < _minimumSoundDelayPitch)
                {
                    PlayPitchVariation(sound, _recordedSounds[sound], _recordedSounds[sound].LastPitchRegistered);
                    return true;
                }

                _recordedSounds[sound].LastTimePlayedOnPitch = Time.time;
            }
            else
                _recordedSounds.Add(sound, new AudioHistory { LastTimePlayedOnPitch = Time.time });

            return false;
        }

        private void PlayPitchVariation(AudioClip sound, AudioHistory audioHistory, float lastPitchRegisteredOnSound)
        {
            _audioSource.pitch = lastPitchRegisteredOnSound;
            _audioSource.pitch = Mathf.Clamp(_audioSource.pitch - 0.1f, _minPitch, 1);
            audioHistory.LastTimePlayedOnPitch = Time.time;
            audioHistory.LastPitchRegistered = _audioSource.pitch;
            _audioSource.PlayOneShot(sound);
        }

        private void NormalizePitch() => _audioSource.pitch = _originalPitch;

        public void ToggleAudioMixer()
        {
            _isMixerEnabled = !_isMixerEnabled;

            _audioMixerButtonText.text = _isMixerEnabled ? "Disable Audio Mixer" : "Enable Audio Mixer";
        }
    }

}