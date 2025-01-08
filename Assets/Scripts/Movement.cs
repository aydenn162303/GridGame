using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    private float horizontalMovement;
    private float VerticalMovement;
    private float waittime = 0.2f;


    void Update() 
    {
        waittime -= Time.deltaTime;

        horizontalMovement = Input.GetAxis("Horizontal");
        VerticalMovement = Input.GetAxis("Vertical");

        if (waittime <= 0 && (horizontalMovement != 0 || VerticalMovement != 0))
        {
            waittime = 0.2f;
            transform.position += new Vector3(Mathf.Round(horizontalMovement), Mathf.Round(VerticalMovement), 0);
        }

            
        

    }
}
