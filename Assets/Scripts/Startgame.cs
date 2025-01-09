using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Begin : MonoBehaviour
{

    public void SwitchToGameScene()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Game");
    }

}
