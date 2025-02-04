using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemName : MonoBehaviour
{
    public string ItemName;

    public movement myPlayer;
    // Start is called before the first frame update
    void Start()
    {
        myPlayer = FindObjectOfType<movement>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        myPlayer.addItem(ItemName);
        Destroy(gameObject);
    }
}
