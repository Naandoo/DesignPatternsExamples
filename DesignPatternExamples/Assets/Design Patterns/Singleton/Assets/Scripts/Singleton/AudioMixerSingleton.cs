using System.Collections.Generic;
using UnityEngine;

public class AudioMixerSingleton : MonoBehaviour
{
    private static AudioMixerSingleton _instance;
    [SerializeField] private AudioSource _audioSource;
    [SerializeField] private float minimumSoundDelay;
    private Dictionary<AudioClip, AudioHistory> _recordedSounds = new();
    private bool isMixerEnabled = true;

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
    }
    public static AudioMixerSingleton GetInstance() => _instance;

    public void Play(AudioClip sound)
    {
        if (isMixerEnabled)
        {
            if (_recordedSounds.ContainsKey(sound))
            {
                if (_recordedSounds[sound].lastTimePlayed + minimumSoundDelay < Time.time)
                {
                    _recordedSounds[sound].lastTimePlayed = Time.time;
                }
                else return;
            }
            else
            {
                _recordedSounds.Add(sound, new AudioHistory { lastTimePlayed = Time.time });
            }
        }

        _audioSource.PlayOneShot(sound);
    }

    public void EnableAudioMixer() => isMixerEnabled = true;
    public void DisableAudioMixer() => isMixerEnabled = false;
}

