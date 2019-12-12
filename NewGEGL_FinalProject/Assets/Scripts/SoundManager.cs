using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SoundManager : SingletonManager<SoundManager>
{
    //public AudioSource sAudio;
    public static SoundManager instance;

    public AudioMixer mixer;
    public void SetLevel(float sliderValue)
    {
        mixer.SetFloat("MasterVol", Mathf.Log10( sliderValue) *20);
    }
}
