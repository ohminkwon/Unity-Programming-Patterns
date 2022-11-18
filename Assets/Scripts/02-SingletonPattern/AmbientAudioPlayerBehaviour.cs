using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmbientAudioPlayerBehaviour : MonoBehaviour
{
    private static AmbientAudioPlayerBehaviour i = null;
    private void Awake()
    {
        if(i == null)
        {
            i = this;
            DontDestroyOnLoad(gameObject);
        }
        else if (i != this)
        {
            Destroy(gameObject);
        }      
    }

    public void FadeMusic(AudioClip clip)
    {
        // TODO
    }
}
