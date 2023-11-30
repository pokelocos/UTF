using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Radio : MonoBehaviour
{
    public List<AudioClip> musics;

    public AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        PlayRandomSong();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayRandomSong()
    {
        audioSource.clip = musics[Random.Range(0, musics.Count)];
        audioSource.Play();
        Invoke("PlayRandomSong", audioSource.clip.length * 0.95f);
    }
}
