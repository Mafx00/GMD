using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SettingsManager : MonoBehaviour
{
    public AudioMixer mixer;

    public float music;
    public float sound;

    void Start()
    {
        mixer = SoundManager.Instance.mixer;
        music = SoundManager.Instance.music;
    }
    public void SetMusicVolume(float music)
    {
        mixer.SetFloat("Music", music);

        SoundManager.Instance.mixer.SetFloat("Music", music);
        SoundManager.Instance.music = music;
    }

    public void SetSoundVolume(float sound)
    {
        mixer.SetFloat("Sounds", sound);

        SoundManager.Instance.mixer.SetFloat("Sounds", sound);
        SoundManager.Instance.sound = sound;
    }
}
