using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LScript : MonoBehaviour
{
    public GameObject player;
    public GameObject MinigameStarter;
    public float speed = 0.3f; // Assuming digminigame.speed is 1.0f, you can set it accordingly
    private bool isMoving = true;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        MinigameStarter = GameObject.FindGameObjectWithTag("DigMiniGame");
        StartCoroutine(ChangePosition());
        speed = MinigameStarter.GetComponent<digMiniGame>().randomTime;
    }

    IEnumerator ChangePosition()
    {
        while (true)
        {
            yield return new WaitForSeconds(speed);
            if (isMoving)
            {
                transform.position += new Vector3(0, -1, 0);
                if (gameObject.transform.position.y < player.transform.position.y + 3)
                {
                    transform.position += new Vector3(0, 3, 0);
                }
            }
        }
    }

    public void stopmoving()
    {
        isMoving = false;
        print("stop");
    }
}
