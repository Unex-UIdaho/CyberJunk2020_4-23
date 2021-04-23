using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class CoinPickup : MonoBehaviour
{
    /*public AudioClip coinPickup;
    public AudioSource audio;*/
    SoundHandler soundHandler;
    public enum loot{COIN, AMMO};
    public loot currentLoot;
    public int quantity; //value of coins collected
    
    public void Start()
    {
        soundHandler = GetComponent<SoundHandler>();
        
    }

    public void Collected()
    {
        if(soundHandler)
        {
            soundHandler.PlayCoinPickup();
        }    
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag == "Player")
        {
            
            Destroy(gameObject);
        }
    }
}
