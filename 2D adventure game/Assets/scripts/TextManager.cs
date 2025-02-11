using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextManager : MonoBehaviour
{

    public TextMeshProUGUI dialogueDisplay;
    public string[] dialogue = new string[5];
    public int currentIndex = 0;
    public MovementLogic list;

    private void Awake()
    {
        list = FindAnyObjectByType<MovementLogic>();
    }

    // Start is called before the first frame update
    void Start()
    {

      
    }

    // Update is called once per frame
    void Update()
    {
        if (dialogueDisplay != null)
        {
            dialogueDisplay.text = dialogue[currentIndex];
        }

        if (list.myInventory.Contains("metal")) 
        {
            currentIndex = 1;
        }

        if (list.myInventory.Contains("fuel"))
        {
            currentIndex = 2;
        }

        if (list.myInventory.Contains("nails"))
        {
            currentIndex = 3;
        }

        if (list.myInventory.Contains("sandwich"))
        {
            currentIndex = 4;
        }

    }
}
