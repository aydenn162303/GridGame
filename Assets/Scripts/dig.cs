using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

    private int amountDug = 0;
    private int layer = 1;

    public GameObject minigameStarterPrefab;
    private bool readyToDig = true;
    private bool playerInTrigger = false;
    
    void Update()
    {
        if (playerInTrigger && Input.GetMouseButtonDown(0) && readyToDig)
        {
            Debug.Log("Dug");
            StartMinigame();
            amountDug += 1;
        }
    }
    
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            playerInTrigger = true;
        }
    }
    
    void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            playerInTrigger = false;
            readyToDig = true;
        }
    }

    private void StartMinigame()
    {
        Instantiate(minigameStarterPrefab, new Vector3(0,0,0), Quaternion.identity);
    }


}
