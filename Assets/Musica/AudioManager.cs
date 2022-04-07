using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;



public class AudioManager : MonoBehaviour
{
    public AudioMixer musicMixer, effectsMixer;
    [Space]
    public AudioSource backgroundGamePlay, backgroundMenu, PlayerDeath;

    public static AudioManager instance; 

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    void Start()
    {


    }

    void Update()
    {
        
    }

    public void PlayAudio(AudioSource audio)
    {
        audio.Play();
    }
}
