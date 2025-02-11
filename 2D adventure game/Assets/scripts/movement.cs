using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class movement : MonoBehaviour
{
    public static movement Instance;
    public GameObject player;
    public float speed = 0.01f;
    public Boolean gardenBotton = false;
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

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "key")
        {

            gardenBotton = true;
            Debug.Log("boolean changed to true");
        }



    }

    public void addItem(string item)
    {
        myInventory.Add(item);

    }


}

