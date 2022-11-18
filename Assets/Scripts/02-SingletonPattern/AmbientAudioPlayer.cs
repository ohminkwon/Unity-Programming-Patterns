using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmbientAudioPlayer : MonoBehaviour
{
    private static AmbientAudioPlayer i = null;
    public static AmbientAudioPlayer GetInstance()
    {
        if(i == null)
        {
            i = new AmbientAudioPlayer();
        }
        return i;
    }
    // private constructor
    private AmbientAudioPlayer()
    {
    }

    public void FadeMusic(AudioClip clip)
    {

    }
}
