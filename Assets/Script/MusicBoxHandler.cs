using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class MusicBoxHandler : MonoBehaviour
{
    int MusicToBePlayed;
    [SerializeField] AudioClip[] Music;
    [SerializeField] AudioSource NOISE;
    // Start is called before the first frame update
    void Awake()
    {
        MusicToBePlayed = Random.Range(0, Music.Length);
        NOISE.clip = Music[MusicToBePlayed];
        NOISE.Play();
    }

    // Update is called once per frame
    void Update()
    {
        if(NOISE.isPlaying == false)
        { 
            MusicToBePlayed = Random.Range(0, Music.Length);
            NOISE.clip = Music[MusicToBePlayed];
            NOISE.Play();
        }
    }
}
