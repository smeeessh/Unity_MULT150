using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioScript : MonoBehaviour
{
    AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            ToggleAudio();
        }
    }

    bool ToggleAudio()
    {
        if (audioSource.isPlaying == true)
        { 
            audioSource.Stop(); 
            return false;
        }
        else 
        { 
            audioSource.Play(); 
            return true;
        }
    }
}
