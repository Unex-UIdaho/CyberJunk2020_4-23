using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyScript : MonoBehaviour
{
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        //If key collides with player and key type is of type key
        if (col.gameObject.tag == "Player" && this.name == "Key")
        {
            Destroy(gameObject);

            //Start Key OpenDoor Function
            Key key = new Key();
            key.OpenDoor();
        }
        //If key collides with player and key type is of type BonusKey
        else if (col.gameObject.tag == "Player" && this.name == "BonusKey")
        {
            Destroy(gameObject);

            //Start BonusKey OpenDoor Function
            BonusKey key = new BonusKey();
            key.OpenDoor();
        }
    }
}
