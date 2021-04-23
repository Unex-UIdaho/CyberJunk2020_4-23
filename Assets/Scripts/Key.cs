using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key
{
    //Doormanager gameobject
    protected GameObject doorManager;
    //Doormanager script
    protected _DoorVars _DoorManager;

    //Opens red lazer door with gold key
    public virtual void OpenDoor()
    {
        //Get doormanager object
        doorManager = GameObject.Find("DoorVariables");
        //Get doormanager components
        if (doorManager)
        {
            _DoorManager = doorManager.GetComponent<_DoorVars>();
            Debug.Log("Door Manager Found");

        }
        //Sets doormanager variables to true to turn of red lazer
        _DoorManager.doorKeyPolice = true;
        _DoorManager.doorKeyVet = true;
        _DoorManager.doorKeyTest = true;
        _DoorManager.doorKey3 = true;
    }
}
//Opens blue lazer door with blue key
public class BonusKey : Key
{
    public override void OpenDoor()
    {
        //Get doormanager object
        doorManager = GameObject.Find("DoorVariables");
        //Get doormanager components
        if (doorManager)
        {
            _DoorManager = doorManager.GetComponent<_DoorVars>();
            Debug.Log("Door Manager Found");
        }
        //Sets doormanager variables to true to turn of blue (bonus) lazer
        _DoorManager.doorBonusKeyPolice = true;
        _DoorManager.doorBonusKeyVet = true;
        _DoorManager.doorBonusKeyTest = true;
        _DoorManager.doorBonusKey3 = true;
    }
}