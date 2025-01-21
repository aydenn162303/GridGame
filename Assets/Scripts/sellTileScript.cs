using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sellTileScript : MonoBehaviour
{

    private bool playerTouching = false;
    public GameObject gameManager;
    public GameObject player;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            playerTouching = true;
            gameManager.GetComponent<GameManager>().playerHasEntered();
            Debug.Log("Player has entered");
        }
    }
    
    void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            playerTouching = false;
            gameManager.GetComponent<GameManager>().playerHasExited();
            Debug.Log("Player has exited");
        }
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
