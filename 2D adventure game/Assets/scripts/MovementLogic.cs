using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MovementLogic : MonoBehaviour
{
    public static MovementLogic Instance;
    public GameObject player;
    public float speed = 0.01f;
    public Boolean isGardenBotton = false;
    public TextMeshProUGUI AiText;
    

    public List<string> myInventory;
    

    // Start is called before the first frame update

    private void Awake()
    {
        if(Instance == null)
        {
            DontDestroyOnLoad(gameObject);
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }
    void Start()
    {
       
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

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "key")
        {

            isGardenBotton = true;
            Debug.Log("boolean changed to true");
        }



    }

    public void addItem(string item)
    {
        myInventory.Add(item);

    }


}

