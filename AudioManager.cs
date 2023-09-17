using UnityEngine.Audio;
using System;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public sounds[] Sounds;
    // Start is called before the first frame update
    void Awake()
    {
        foreach (sounds s in Sounds)
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;

            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
        }
    }

    public void Play(string name)
    {
       sounds s = Array.Find(Sounds,sound => sound.name == name);
        s.source.Play();
    }
}
