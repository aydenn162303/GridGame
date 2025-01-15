using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomItemScript : MonoBehaviour
{
    private GameObject GameManager;
    private int rolls = 1;

    void Start()
    {
        GameManager = GameObject.Find("GameManager");
        if (GameManager == null)
        {
            Debug.LogError("GameManager not found in the scene.");
            return;
        }
        GameManager.GetComponent<GameManager>().ShowDiggingText();
        rolls = GameManager.GetComponent<GameManager>().EquiptedPickAxeLuckMult;
        StartCoroutine(ToggleVisibility());
    }

    IEnumerator ToggleVisibility()
    {
        for (int i = 0; i < 8; i++)
        {
            GameManager.GetComponent<GameManager>().ShowDiggingText();
            yield return new WaitForSeconds(1f);
            GameManager.GetComponent<GameManager>().HideDiggingText();
            yield return new WaitForSeconds(0.2f);
        }
        GenerateRandom();
    }

    void GenerateRandom()
    {
        for (int i = -1; i < rolls; i++)
        {
            Debug.Log("Random generation logic executed.");
        }
    }
}
