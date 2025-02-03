using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class movement : MonoBehaviour
{
    public GameObject player;
    public float speed = 0.01f;
    public Boolean hasKey = false;
    public TextMeshProUGUI AiText;

    // Start is called before the first frame update
    void Start()
    {
        AiText.text = "Lets get this rocket on the way! /nWe are going to need some metal first. That should be in our room.";
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            player.transform.position += Vector3.up * speed;
        }
        if (Input.GetKey(KeyCode.S))
        {
            player.transform.position += Vector3.down * speed; 
        }
        if (Input.GetKey(KeyCode.D))
        {
            player.transform.position += Vector3.right * speed;
        }
        if (Input.GetKey(KeyCode.A))
        {
            player.transform.position += Vector3.left * speed;
        }




    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "key") 
        { 
            Destroy(collision.gameObject);
            hasKey = true;
        }
        
    }
}

