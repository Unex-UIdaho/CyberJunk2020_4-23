using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Singleton
public class _DoorVars : MonoBehaviour
{
    public static _DoorVars Instance { get; private set; }
    //Doors for each level
    public bool doorKeyTest;
    public bool doorKeyVet;
    public bool doorKeyPolice;
    public bool doorKey3;
    public bool doorBonusKeyTest;
    public bool doorBonusKeyVet;
    public bool doorBonusKeyPolice;
    public bool doorBonusKey3;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            doorKeyTest = false;
            doorKeyVet = false;
            doorKeyPolice = false;
            doorKey3 = false;
            doorBonusKeyTest = false;
            doorBonusKeyVet = false;
            doorBonusKeyPolice = false;
            doorBonusKey3 = false;
        DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
