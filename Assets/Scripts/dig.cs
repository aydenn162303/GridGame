using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

    private int amountDug = 0;
    private int layer = 1;

    private float digCoolDown = 0;

    public GameObject minigameStarterPrefab;


    private bool playerInTrigger = false;
    
    void Update()
    {
        if (digCoolDown > 0)
        {
            digCoolDown -= Time.deltaTime;
        }
        
        if (playerInTrigger && Input.GetMouseButtonDown(0) && digCoolDown <= 0)
        {
            Debug.Log("Dug");
            StartMinigame();
            digCoolDown = 35.0f;
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
        }
    }

    private void StartMinigame()
    {
        Instantiate(minigameStarterPrefab, new Vector3(0,0,0), Quaternion.identity);
    }


}
