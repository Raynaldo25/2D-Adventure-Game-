using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gbotton : MonoBehaviour
{

    public GameObject gardenDoor;
    public movement movement;   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (movement.gardenBotton == false)
        {
            Collider gardenDoor = GetComponent<Collider>();
            gardenDoor.isTrigger = false;
        }
        if (movement.gardenBotton == true)
        {
            Collider gardenDoor = GetComponent<Collider>();
            gardenDoor.isTrigger = true;
        }
    }

    


}



