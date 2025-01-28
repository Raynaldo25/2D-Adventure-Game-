using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public GameObject player;
    public float speed = 0.01f;

    // Start is called before the first frame update
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
            Destroy(collision.gameObject);
        }
        
    }
}

