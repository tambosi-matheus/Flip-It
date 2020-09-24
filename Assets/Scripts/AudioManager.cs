using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [System.Serializable]
    public class Sound
    {
        public string name;

        public AudioClip clip;

        [Range(0f, 1f)]
        public float volume = .1f;
        [Range(.1f, 3f)]
        public float pitch = 1;
        public bool loop;

        [HideInInspector]
        public AudioSource source;
    }
    
    public Sound[] sounds;

    private void Awake()
    {
        foreach(Sound s in sounds)
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;
            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
            s.source.loop = s.loop;
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
            Array.Find(sounds, s => s.name == "Tendinite - Inhale Exhale").source.Play();

        
    }
}
