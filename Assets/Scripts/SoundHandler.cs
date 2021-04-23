using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SoundHandler : MonoBehaviour
{
    public AudioClip objectSound; //audio clip assigned to object
    public AudioSource sfx; //AudioSource component on prefab game object

    // Start is called before the first frame update
    void Start()
    {
        sfx = GetComponent<AudioSource>();
        objectSound = sfx.clip;
    }

    public void PlaySound()
    {
        sfx.Play();
    }
    public void PlayCoinPickup()
    {
        AudioSource.PlayClipAtPoint(objectSound, transform.position);
    }
}
