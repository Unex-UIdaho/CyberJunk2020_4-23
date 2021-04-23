using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LazerScript : MonoBehaviour
{
    //Player Script
    PlayerScript player;
    //DoorManager Object
    GameObject doorManager;
    //Doormanager Script
    _DoorVars _DoorManager;
    //Lazer Damage
    public int damage = 100;
    Scene currentScene;
    void Start()
    {
        doorManager = GameObject.Find("DoorVariables");

        if (doorManager)
        {
            _DoorManager = doorManager.GetComponent<_DoorVars>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (!doorManager)
        {
            doorManager = GameObject.Find("DoorVariables");

            if (doorManager)
            {
                _DoorManager = doorManager.GetComponent<_DoorVars>();
                Debug.Log("Door Manager Found");
            }
        }
        currentScene = SceneManager.GetActiveScene();
        //Checks Scenes and key variables in _DoorVars.cs 
        if (_DoorManager.doorKeyTest == true && currentScene.name == "TestScene" && this.name == "LazerDoor")
        {
            GameObject lazer = GameObject.Find("LazerDoor");
            Destroy(lazer);
        }
        else if (_DoorManager.doorKeyVet == true && currentScene.name == "VetClinic" && this.name == "LazerDoor")
        {
            GameObject lazer = GameObject.Find("LazerDoor");
            Destroy(lazer);
        }
        else if (_DoorManager.doorKeyPolice == true && currentScene.name == "PoliceStation" && this.name == "LazerDoor")
        {
            GameObject lazer = GameObject.Find("LazerDoor");
            Destroy(lazer); 
        }

        if (_DoorManager.doorBonusKeyTest == true && currentScene.name == "TestScene" && this.name == "BlueLazerDoor")
        {
            GameObject lazer = GameObject.Find("BlueLazerDoor");
            Destroy(lazer);
        }
        if (_DoorManager.doorBonusKeyVet == true && currentScene.name == "VetClinic" && this.name == "BlueLazerDoor")
        {
            GameObject lazer = GameObject.Find("BlueLazerDoor");
            Destroy(lazer);
        }
        if (_DoorManager.doorBonusKeyPolice == true && currentScene.name == "PoliceStation" && this.name == "BlueLazerDoor")
        {
            GameObject lazer = GameObject.Find("BlueLazerDoor");
            Destroy(lazer);
        }


    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            //do damage
            col.GetComponent<PlayerScript>().health -= damage;
        }

    }
}