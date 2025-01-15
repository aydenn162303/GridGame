using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private float horizontalMovement;
    private float VerticalMovement;
    private float waittime = 0.7f;
    private float maxWaitTime = 0.3f;
    private bool activeMiniGameVar = false;

    public void activeMiniGame()
    {
        activeMiniGameVar = true;
    }
    
    public void deactiveMiniGame()
    {
        activeMiniGameVar = false;
    }

    void Update() 
    {
        waittime -= Time.deltaTime;

        if (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift))
        {
            maxWaitTime = 0.15f;
        }
        else
        {
            maxWaitTime = 0.25f;
        }

        if (activeMiniGameVar == false)
        {
            horizontalMovement = Input.GetAxis("Horizontal");
            VerticalMovement = Input.GetAxis("Vertical");

            if (waittime <= 0 && (horizontalMovement != 0 || VerticalMovement != 0))
            {
                if (horizontalMovement > 0)
                {
                    horizontalMovement = 1;
                }
                else if (horizontalMovement < 0)
                {
                    horizontalMovement = -1;
                }

                if (VerticalMovement > 0)
                {
                    VerticalMovement = 1;
                }
                else if (VerticalMovement < 0)
                {
                    VerticalMovement = -1;
                }

                waittime = maxWaitTime;

                transform.position += new Vector3(Mathf.Round(horizontalMovement), Mathf.Round(VerticalMovement), 0);
            }
        }
    }
}
