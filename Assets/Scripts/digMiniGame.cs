using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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

    public GameObject left1;
    public GameObject left2;
    public GameObject left3;
    public GameObject right1;
    public GameObject right2;
    public GameObject right3;
    //should work

    void Start()
    {
        player = GameObject.Find("Player");
        Random.InitState((int)player.transform.position.x + (int)player.transform.position.y);
        player.GetComponent<Movement>().activeMiniGame();
        //create things

        left1 = Instantiate(left1Prefab, new Vector3(player.transform.position.x - 1, player.transform.position.y + 5, 0), Quaternion.identity);
        left2 = Instantiate(left2Prefab, new Vector3(player.transform.position.x - 1, player.transform.position.y + 4, 0), Quaternion.identity);
        left3 = Instantiate(left3Prefab, new Vector3(player.transform.position.x - 1, player.transform.position.y + 3, 0), Quaternion.identity);

        right1 = Instantiate(right1Prefab, new Vector3(player.transform.position.x + 1, player.transform.position.y + 5, 0), Quaternion.identity);
        right2 = Instantiate(right2Prefab, new Vector3(player.transform.position.x + 1, player.transform.position.y + 4, 0), Quaternion.identity);
        right3 = Instantiate(right3Prefab, new Vector3(player.transform.position.x + 1, player.transform.position.y + 3, 0), Quaternion.identity);

        StartCoroutine(WaitForSpaceBar());
    }

    IEnumerator WaitForSpaceBar()
    {
        while (!Input.GetKeyDown(KeyCode.Space))
        {
            yield return null;
        }

        //left1.GetComponent<LScript>().stopmoving();
        //left2.GetComponent<LScript>().stopmoving();
        //left3.GetComponent<LScript>().stopmoving();

        if (left2.transform.position.y == right2.transform.position.y)
        {
            DugSuccess();
        }

        player.GetComponent<Movement>().deactiveMiniGame();

        Destroy(left1);
        Destroy(left2);
        Destroy(left3);
        Destroy(right1);
        Destroy(right2);
        Destroy(right3);
        Destroy(gameObject);
    }

    void DugSuccess()
    {
        print("You dug yay!!");
    }

    public void StartDigging()
    {
        //hi
    }
}
