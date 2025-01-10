using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using random = UnityEngine.Random;

public class digMiniGame : MonoBehaviour
{
    public GameObject player;
    private int miniGameLayout = 0;

    public GameObject right1Prefab;
    public GameObject right2Prefab;
    public GameObject right3Prefab;
    public GameObject left1Prefab;
    public GameObject left2Prefab;
    public GameObject left3Prefab;

    void Start()
    {
        player = GameObject.Find("Player");
        Random.InitState((int)player.transform.position.x + (int)player.transform.position.y);
    }

    public void StartDigging()
    {
        player.GetComponent<Movement>().activeMiniGame = true;
        if (miniGameLayout == 0)
        {
            miniGameLayout = Random.Range(1, 4); // Changed to 4 to include layout 3
        }

        if (miniGameLayout == 1) 
        {
            Instantiate(right1Prefab, new Vector3(player.transform.position.x + 5, player.transform.position.y + 5, 0), Quaternion.identity);
        }   
        else if (miniGameLayout == 2)
        {
            Instantiate(right2Prefab, new Vector3(player.transform.position.x + 5, player.transform.position.y + 5, 0), Quaternion.identity);
        }
        else if (miniGameLayout == 3)
        {
            Instantiate(right3Prefab, new Vector3(player.transform.position.x + 5, player.transform.position.y + 5, 0), Quaternion.identity);
        }
    }
}
