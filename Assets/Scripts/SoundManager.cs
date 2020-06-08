using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SoundManager : MonoBehaviour
{
    public static SoundManager Instance;

    public AudioMixer mixer;

    public float music;
    public float sound;

    void Awake()
    {
        if (Instance == null)
        {
            DontDestroyOnLoad(gameObject);
            Instance = this;
            mixer.SetFloat("Music", music);
            mixer.SetFloat("Sounds", sound);
        }
        else if (Instance != this)
        {
            Destroy(gameObject);
        }
    }
}
