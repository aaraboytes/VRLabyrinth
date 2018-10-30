using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySound : MonoBehaviour {
    bool playing = false;
    public void PlaySoundNow()
    {
        if (!playing)
        {
            GetComponent<AudioSource>().Play();
            playing = true;
        }
    }
    public void StopSound()
    {
        GetComponent<AudioSource>().Stop();
        playing = false;
    }
}
