using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gbotton : MonoBehaviour
{

    public Collider2D gardenDoor;
    public MovementLogic movement;   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (movement.isGardenBotton == false)
        {
            gardenDoor = GetComponent<Collider2D>();
            gardenDoor.isTrigger = false;
        }
        if (movement.isGardenBotton == true)
        {
            gardenDoor = GetComponent<Collider2D>();
            gardenDoor.isTrigger = true;
        }
    }

    


}



