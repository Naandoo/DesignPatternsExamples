using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class AudioMixerSingleton : MonoBehaviour
{
    [SerializeField] private AudioSource _audioSource;
    [SerializeField] private float minimumSoundDelayPitch = 2;
    [SerializeField] private float minimumSoundDelay;
    [SerializeField] private TMP_Text _audioMixerButtonText;
    [SerializeField] private float minPitch = 0.75f;
    private static AudioMixerSingleton _instance;
    private Dictionary<AudioClip, AudioHistory> _recordedSounds = new();
    private bool isMixerEnabled = true;
    private float _originalPitch;
    private AudioMixerSingleton() { }

    private void Awake()
    {
        if (_instance == null)
        {
            _instance = this;
            DontDestroyOnLoad(this);
        }
        else
        {
            Destroy(gameObject);
        }

        _originalPitch = _audioSource.pitch;
    }

    public static AudioMixerSingleton GetInstance() => _instance;

    public void Play(AudioClip sound)
    {
        if (isMixerEnabled)
        {
            if (IsSoundUnavailableToPlay(sound)) return;
            if (IsPitchAvailable(sound)) return;
        }

        NormalizePitch();
        _audioSource.PlayOneShot(sound);
    }

    private bool IsSoundUnavailableToPlay(AudioClip sound)
    {
        if (_recordedSounds.ContainsKey(sound))
        {
            if (Time.time - _recordedSounds[sound].LastTimePlayed < minimumSoundDelay)
            {
                _recordedSounds[sound].LastTimePlayed = Time.time;
                return true;
            }

            _recordedSounds[sound].LastTimePlayed = Time.time;
        }

        else _recordedSounds.Add(sound, new AudioHistory { LastTimePlayed = Time.time });
        return false;
    }

    private bool IsPitchAvailable(AudioClip sound)
    {
        if (_recordedSounds.ContainsKey(sound))
        {
            if (Time.time - _recordedSounds[sound].LastTimePlayedOnPitch < minimumSoundDelayPitch)
            {
                PlayPitchVariation(sound, _recordedSounds[sound], GetLastPitchRegistered(_recordedSounds[sound]));
                return true;
            }

            _recordedSounds[sound].LastTimePlayedOnPitch = Time.time;
        }
        else _recordedSounds.Add(sound, new AudioHistory { LastTimePlayedOnPitch = Time.time });

        return false;
    }

    private void PlayPitchVariation(AudioClip sound, AudioHistory audioHistory, float lastPitchRegisteredOnSound)
    {
        audioHistory.LastTimePlayedOnPitch = Time.time;
        _audioSource.pitch = lastPitchRegisteredOnSound;
        _audioSource.pitch = Mathf.Clamp(_audioSource.pitch - 0.1f, minPitch, 1);
        audioHistory.LastPitchRegistered = _audioSource.pitch;
        _audioSource.PlayOneShot(sound);
    }

    private float GetLastPitchRegistered(AudioHistory audioHistory) => audioHistory.LastPitchRegistered;

    private void NormalizePitch() => _audioSource.pitch = _originalPitch;

    public void ToggleAudioMixer()
    {
        isMixerEnabled = !isMixerEnabled;

        if (isMixerEnabled)
        {
            _audioMixerButtonText.text = "Disable Audio Mixer";
        }
        else
        {
            _audioMixerButtonText.text = "Enable Audio Mixer";
        }
    }
}

